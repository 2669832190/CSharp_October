using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cognex.VisionPro;
using MvCamCtrl.NET;

namespace HikDLL
{
    public class EnumCamDevice
    {
        static MyCamera.MV_CC_DEVICE_INFO_LIST m_pDeviceList;
        //创建一个字典集合 用于存储相机  键-相机名称  值-相机
        public static Dictionary<string, MyCamera> camList = new Dictionary<string, MyCamera>();
        /// <summary>
        /// 枚举相机
        /// </summary>
        public static bool DeviceListAcq()
        {
            bool bFindCamera = false;//查找相机的标志位
            string camName = string.Empty;//相机名称
            string camSN = string.Empty;//相机的序列号

            int nRet;
            // ch:创建设备列表 || en: Create device list
            System.GC.Collect();
           
            nRet = MyCamera.MV_CC_EnumDevices_NET(MyCamera.MV_GIGE_DEVICE | MyCamera.MV_USB_DEVICE, ref m_pDeviceList);
            if (MyCamera.MV_OK != nRet)
            {
                MessageBox.Show("Enum Devices Fail");
                return false;
            }

            // ch:在窗体列表中显示设备名 || Display the device'name on window's list
            for (int i = 0; i < m_pDeviceList.nDeviceNum; i++)
            {
                MyCamera.MV_CC_DEVICE_INFO device = (MyCamera.MV_CC_DEVICE_INFO)Marshal.PtrToStructure(m_pDeviceList.pDeviceInfo[i], typeof(MyCamera.MV_CC_DEVICE_INFO));
                if (device.nTLayerType == MyCamera.MV_GIGE_DEVICE)
                {
                    IntPtr buffer = Marshal.UnsafeAddrOfPinnedArrayElement(device.SpecialInfo.stGigEInfo, 0);
                    MyCamera.MV_GIGE_DEVICE_INFO gigeInfo = (MyCamera.MV_GIGE_DEVICE_INFO)Marshal.PtrToStructure(buffer, typeof(MyCamera.MV_GIGE_DEVICE_INFO));
                    if (gigeInfo.chUserDefinedName != "")
                    {
                        camName ="GigE: " + gigeInfo.chUserDefinedName + " (" + gigeInfo.chSerialNumber + ")";
                    }
                    else
                    {
                       camName ="GigE: " + gigeInfo.chManufacturerName + " " + gigeInfo.chModelName + " (" + gigeInfo.chSerialNumber + ")";
                    }
                }
                else if (device.nTLayerType == MyCamera.MV_USB_DEVICE)
                {
                    IntPtr buffer = Marshal.UnsafeAddrOfPinnedArrayElement(device.SpecialInfo.stUsb3VInfo, 0);
                    MyCamera.MV_USB3_DEVICE_INFO usbInfo = (MyCamera.MV_USB3_DEVICE_INFO)Marshal.PtrToStructure(buffer, typeof(MyCamera.MV_USB3_DEVICE_INFO));
                    if (usbInfo.chUserDefinedName != "")
                    {
                        camName = "USB: " + usbInfo.chUserDefinedName + " (" + usbInfo.chSerialNumber + ")";
                    }
                    else
                    {
                        camName = "USB: " + usbInfo.chManufacturerName + " " + usbInfo.chModelName + " (" + usbInfo.chSerialNumber + ")";
                    }
                }

                MyCamera m_pMyCamera = new MyCamera();
                nRet = m_pMyCamera.MV_CC_CreateDevice_NET(ref device);
                if (MyCamera.MV_OK != nRet)
                {
                    return false;
                }

                camList.Add(camName, m_pMyCamera);

            }

            //.ch: 选择第一项 || en: Select the first item
            if (m_pDeviceList.nDeviceNum != 0)
            {
                bFindCamera = true;
            }
            return bFindCamera;
        }
    }

    public class HikCam
    {
        private string _camParamPath = Directory.GetCurrentDirectory() + "\\Cam\\Camera.ini";
        
        private MyCamera m_pMyCamera;
        bool m_bGrabbing;
        byte[] m_pDataForRed = new byte[20 * 1024 * 1024];
        byte[] m_pDataForGreen = new byte[20 * 1024 * 1024];
        byte[] m_pDataForBlue = new byte[20 * 1024 * 1024];
        UInt32 g_nPayloadSize = 0;
        UInt32 m_nRowStep = 0;

        string CamName;//相机名称
        string camKey;
        /// <summary>
        /// 曝光时间
        /// </summary>
        public float Exposure;
        public float Gain;
        public ICogImage Image;

        //声明委托用于传递图片
        public delegate void CamAcqCompleteDelegate(string camName, ICogImage image);
        //声明该委托类型的事件
        public event CamAcqCompleteDelegate CamAcqCompleteEvent;
        
        public HikCam(string camName)
        {
            this.CamName = camName;
            string[] cams = Ini.IniAPI.INIGetAllSectionNames(_camParamPath);
            for (int i = 0; i < cams.Length; i++)
            {
                if (cams[i].Contains(CamName))
                {
                    this.Exposure = (float)Ini.IniAPI.GetPrivateProfileDouble(cams[i], "Exposure", 20, _camParamPath);
                    OpenCamBySN(camName);
                }
            }
        }

        /// <summary>
        /// 传入相机名称，根据ini文件中对应的序列号，打开相机
        /// </summary>
        /// <param name="camName">相机名称</param>
        private void OpenCamBySN(string camName)
        {
            string SN = Ini.IniAPI.INIGetStringValue(_camParamPath, camName, "SN", "");
            OpenCam(SN);
        }

        /// <summary>
        /// 打开相机
        /// </summary>
        /// <param name="camName">相机名称</param>
        private void OpenCam(string camName)
        {
            try
            {
                int nRet = -1;

                foreach (string  key in EnumCamDevice.camList.Keys)
                {
                    if (key.Contains(camName))
                    {
                        camKey = key;
                        break;
                    }
                }
                if (camKey == null)
                {
                    return;
                }


                m_pMyCamera = EnumCamDevice.camList[camKey];

                // ch:打开设备 | en:Open device
                nRet = m_pMyCamera.MV_CC_OpenDevice_NET();
                if (MyCamera.MV_OK != nRet)
                {
                    MessageBox.Show("Open Device Fail");
                    return;
                }

                // ch:获取包大小 || en: Get Payload Size
                MyCamera.MVCC_INTVALUE stParam = new MyCamera.MVCC_INTVALUE();
                nRet = m_pMyCamera.MV_CC_GetIntValue_NET("PayloadSize", ref stParam);
                if (MyCamera.MV_OK != nRet)
                {
                    MessageBox.Show("Get PayloadSize Fail");
                    return;
                }
                g_nPayloadSize = stParam.nCurValue;

                // ch:获取高 || en: Get Height
                nRet = m_pMyCamera.MV_CC_GetIntValue_NET("Height", ref stParam);
                if (MyCamera.MV_OK != nRet)
                {
                    MessageBox.Show("Get Height Fail");
                    return;
                }
                uint nHeight = stParam.nCurValue;

                // ch:获取宽 || en: Get Width
                nRet = m_pMyCamera.MV_CC_GetIntValue_NET("Width", ref stParam);
                if (MyCamera.MV_OK != nRet)
                {
                    MessageBox.Show("Get Width Fail");
                    return;
                }
                uint nWidth = stParam.nCurValue;

                // ch:获取步长 || en: Get nRowStep
                m_nRowStep = nWidth * nHeight;

                // ch:设置触发模式为off || en:set trigger mode as off
                m_pMyCamera.MV_CC_SetEnumValue_NET("AcquisitionMode", 2);
                m_pMyCamera.MV_CC_SetEnumValue_NET("TriggerMode", 0);


                SetSoftWare();//设置软触发模式
                StartGrabbing();
            }
            catch (Exception ex)
            {
                
                
            }
           
        }
        /// <summary>
        /// 开始采集
        /// </summary>
        private void StartGrabbing()
        {
            try
            {
                int nRet;
                // ch:开启抓图 | en:start grab
                nRet = m_pMyCamera.MV_CC_StartGrabbing_NET();
                if (MyCamera.MV_OK != nRet)
                {
                    MessageBox.Show("Start Grabbing Fail");
                    return;
                }
                m_bGrabbing = true;

                Thread hReceiveImageThreadHandle = new Thread(ReceiveImageWorkThread);
                hReceiveImageThreadHandle.Start(m_pMyCamera);
            }
            catch (Exception ex)
            {

                
            }
        }
        /// <summary>
        /// 拍照
        /// </summary>
        public void Run()
        {

            int nRet;

            // ch: 触发命令 || en: Trigger command
            nRet = m_pMyCamera.MV_CC_SetCommandValue_NET("TriggerSoftware");
            if (MyCamera.MV_OK != nRet)
            {
                MessageBox.Show("Trigger Fail");
            }
        }
        //接收图片的线程
        private void ReceiveImageWorkThread(object obj)
        {
           
            
            
            int nRet = MyCamera.MV_OK;
            MyCamera device = obj as MyCamera;
            MyCamera.MV_FRAME_OUT_INFO_EX pFrameInfo = new MyCamera.MV_FRAME_OUT_INFO_EX();
            IntPtr pData = Marshal.AllocHGlobal((int)g_nPayloadSize);
            if (pData == IntPtr.Zero)
            {
                return;
            }
            IntPtr pImageBuffer = Marshal.AllocHGlobal((int)m_nRowStep * 3);
            if (pImageBuffer == IntPtr.Zero)
            {
                return;
            }

            IntPtr pTemp = IntPtr.Zero;
            Byte[] byteArrImageData = new Byte[m_nRowStep * 3];

            while (m_bGrabbing)
            {
                nRet = device.MV_CC_GetOneFrameTimeout_NET(pData, g_nPayloadSize, ref pFrameInfo, 1000);
                if (MyCamera.MV_OK == nRet)
                {
                    MyCamera.MvGvspPixelType pixelType = MyCamera.MvGvspPixelType.PixelType_Gvsp_RGB8_Packed;
                    if (IsColorPixelFormat(pFrameInfo.enPixelType))    // 彩色图像处理
                    {
                        if (pFrameInfo.enPixelType == MyCamera.MvGvspPixelType.PixelType_Gvsp_RGB8_Packed)
                        {
                            pTemp = pData;
                        }
                        else
                        {
                            // 其他格式彩色图像转为RGB
                            nRet = ConvertToRGB(obj, pData, pFrameInfo.nHeight, pFrameInfo.nWidth, pFrameInfo.enPixelType, pImageBuffer);
                            if (MyCamera.MV_OK != nRet)
                            {
                                return;
                            }
                            pTemp = pImageBuffer;
                        }

                        // Packed转Plane
                        unsafe
                        {
                            byte* pBufForSaveImage = (byte*)pTemp;

                            UInt32 nSupWidth = (pFrameInfo.nWidth + (UInt32)3) & 0xfffffffc;

                            for (int nRow = 0; nRow < pFrameInfo.nHeight; nRow++)
                            {
                                for (int col = 0; col < pFrameInfo.nWidth; col++)
                                {
                                    byteArrImageData[nRow * nSupWidth + col] = pBufForSaveImage[nRow * pFrameInfo.nWidth * 3 + (3 * col)];
                                    byteArrImageData[pFrameInfo.nWidth * pFrameInfo.nHeight + nRow * nSupWidth + col] = pBufForSaveImage[nRow * pFrameInfo.nWidth * 3 + (3 * col + 1)];
                                    byteArrImageData[pFrameInfo.nWidth * pFrameInfo.nHeight * 2 + nRow * nSupWidth + col] = pBufForSaveImage[nRow * pFrameInfo.nWidth * 3 + (3 * col + 2)];
                                }
                            }
                            pTemp = Marshal.UnsafeAddrOfPinnedArrayElement(byteArrImageData, 0);
                        }
                    }
                    else if (IsMonoPixelFormat(pFrameInfo.enPixelType))    // Mono图像处理
                    {
                        if (pFrameInfo.enPixelType == MyCamera.MvGvspPixelType.PixelType_Gvsp_Mono8)
                        {
                            pTemp = pData;
                        }
                        else
                        {
                            // 其他格式Mono转为Mono8
                            nRet = ConvertToMono8(device, pData, pImageBuffer, pFrameInfo.nHeight, pFrameInfo.nWidth, pFrameInfo.enPixelType);
                            if (MyCamera.MV_OK != nRet)
                            {
                                return;
                            }
                            pTemp = pImageBuffer;
                        }
                        pixelType = MyCamera.MvGvspPixelType.PixelType_Gvsp_Mono8;
                    }
                    else
                    {
                        continue;
                    }
                    Image = ConvertToICogImage(pFrameInfo.nHeight, pFrameInfo.nWidth, pTemp, pixelType);
                    //if (CamAcqCompleteEvent != null)
                    //{
                    //    CamAcqCompleteEvent(this.CamName, Image);
                    //}
                    //上面代码的简写方式
                    CamAcqCompleteEvent?.Invoke(this.CamName, Image);
                }
                else
                {
                    continue;
                }
            }
            if (pData != IntPtr.Zero)
            {
                Marshal.FreeHGlobal(pData);
            }
            if (pImageBuffer != IntPtr.Zero)
            {
                Marshal.FreeHGlobal(pImageBuffer);
            }
            return;
        }

        /// <summary>
        /// 转成VP支持的图像格式
        /// </summary>
        /// <param name="nHeight">高</param>
        /// <param name="nWidth">宽</param>
        /// <param name="pImageBuf">图片数据</param>
        /// <param name="enPixelType">像素格式</param>
        private ICogImage ConvertToICogImage(UInt32 nHeight, UInt32 nWidth, IntPtr pImageBuf, MyCamera.MvGvspPixelType enPixelType)
        {
            ICogImage cogImage = null;
            // ch: 显示 || display
            try
            {
                if (enPixelType == MyCamera.MvGvspPixelType.PixelType_Gvsp_Mono8)
                {
                    CogImage8Root cogImage8Root = new CogImage8Root();
                    cogImage8Root.Initialize((Int32)nWidth, (Int32)nHeight, pImageBuf, (Int32)nWidth, null);

                    CogImage8Grey cogImage8Grey = new CogImage8Grey();
                    cogImage8Grey.SetRoot(cogImage8Root);
                    cogImage = cogImage8Grey.ScaleImage((int)nWidth, (int)nHeight);
                    System.GC.Collect();
                }
                else
                {
                    CogImage8Root image0 = new CogImage8Root();
                    IntPtr ptr0 = new IntPtr(pImageBuf.ToInt64());
                    image0.Initialize((int)nWidth, (int)nHeight, ptr0, (int)nWidth, null);

                    CogImage8Root image1 = new CogImage8Root();
                    IntPtr ptr1 = new IntPtr(pImageBuf.ToInt64() + m_nRowStep);
                    image1.Initialize((int)nWidth, (int)nHeight, ptr1, (int)nWidth, null);

                    CogImage8Root image2 = new CogImage8Root();
                    IntPtr ptr2 = new IntPtr(pImageBuf.ToInt64() + m_nRowStep * 2);
                    image2.Initialize((int)nWidth, (int)nHeight, ptr2, (int)nWidth, null);

                    CogImage24PlanarColor colorImage = new CogImage24PlanarColor();
                    colorImage.SetRoots(image0, image1, image2);

                    cogImage = colorImage.ScaleImage((int)nWidth, (int)nHeight);
                    System.GC.Collect();
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }
            return cogImage;
        }
        /// <summary>
        /// 设置软触发
        /// </summary>
        private void SetSoftWare()
        {
            int nRet = 0;
            //设置触发模式打开
            nRet = m_pMyCamera.MV_CC_SetEnumValue_NET("TriggerMode", 1);
            if (nRet != MyCamera.MV_OK)
            {
                MessageBox.Show("Set TriggerMode Fail");
                return;
            }

            // ch: 触发源选择:0 - Line0 || en :TriggerMode select;
            //           1 - Line1;
            //           2 - Line2;
            //           3 - Line3;
            //           4 - Counter;
            //           7 - Software;
            //设置软触发
            nRet = m_pMyCamera.MV_CC_SetEnumValue_NET("TriggerSource", 7);
            if (nRet != MyCamera.MV_OK)
            {
                MessageBox.Show("Set TriggerSource Fail");
                return;
            }
        }

        /// <summary>
        /// 图像是否为Mono格式
        /// </summary>
        /// <param name="enType"></param>
        /// <returns></returns>
        private bool IsMonoPixelFormat(MyCamera.MvGvspPixelType enType)
        {
            switch (enType)
            {
                case MyCamera.MvGvspPixelType.PixelType_Gvsp_Mono8:
                case MyCamera.MvGvspPixelType.PixelType_Gvsp_Mono10:
                case MyCamera.MvGvspPixelType.PixelType_Gvsp_Mono10_Packed:
                case MyCamera.MvGvspPixelType.PixelType_Gvsp_Mono12:
                case MyCamera.MvGvspPixelType.PixelType_Gvsp_Mono12_Packed:
                    return true;
                default:
                    return false;
            }
        }

        /// <summary>
        /// 图像是否为彩色
        /// </summary>
        /// <param name="enType"></param>
        /// <returns></returns>
        private bool IsColorPixelFormat(MyCamera.MvGvspPixelType enType)
        {
            switch (enType)
            {
                case MyCamera.MvGvspPixelType.PixelType_Gvsp_RGB8_Packed:
                case MyCamera.MvGvspPixelType.PixelType_Gvsp_BGR8_Packed:
                case MyCamera.MvGvspPixelType.PixelType_Gvsp_RGBA8_Packed:
                case MyCamera.MvGvspPixelType.PixelType_Gvsp_BGRA8_Packed:
                case MyCamera.MvGvspPixelType.PixelType_Gvsp_YUV422_Packed:
                case MyCamera.MvGvspPixelType.PixelType_Gvsp_YUV422_YUYV_Packed:
                case MyCamera.MvGvspPixelType.PixelType_Gvsp_BayerGR8:
                case MyCamera.MvGvspPixelType.PixelType_Gvsp_BayerRG8:
                case MyCamera.MvGvspPixelType.PixelType_Gvsp_BayerGB8:
                case MyCamera.MvGvspPixelType.PixelType_Gvsp_BayerBG8:
                case MyCamera.MvGvspPixelType.PixelType_Gvsp_BayerGB10:
                case MyCamera.MvGvspPixelType.PixelType_Gvsp_BayerGB10_Packed:
                case MyCamera.MvGvspPixelType.PixelType_Gvsp_BayerBG10:
                case MyCamera.MvGvspPixelType.PixelType_Gvsp_BayerBG10_Packed:
                case MyCamera.MvGvspPixelType.PixelType_Gvsp_BayerRG10:
                case MyCamera.MvGvspPixelType.PixelType_Gvsp_BayerRG10_Packed:
                case MyCamera.MvGvspPixelType.PixelType_Gvsp_BayerGR10:
                case MyCamera.MvGvspPixelType.PixelType_Gvsp_BayerGR10_Packed:
                case MyCamera.MvGvspPixelType.PixelType_Gvsp_BayerGB12:
                case MyCamera.MvGvspPixelType.PixelType_Gvsp_BayerGB12_Packed:
                case MyCamera.MvGvspPixelType.PixelType_Gvsp_BayerBG12:
                case MyCamera.MvGvspPixelType.PixelType_Gvsp_BayerBG12_Packed:
                case MyCamera.MvGvspPixelType.PixelType_Gvsp_BayerRG12:
                case MyCamera.MvGvspPixelType.PixelType_Gvsp_BayerRG12_Packed:
                case MyCamera.MvGvspPixelType.PixelType_Gvsp_BayerGR12:
                case MyCamera.MvGvspPixelType.PixelType_Gvsp_BayerGR12_Packed:
                    return true;
                default:
                    return false;
            }
        }

        /// <summary>
        /// 其他黑白格式转为Mono8
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="pInData">输出图片数据</param>
        /// <param name="pOutData">输出图片数据</param>
        /// <param name="nHeight">高</param>
        /// <param name="nWidth">宽</param>
        /// <param name="nPixelType">像素格式</param>
        /// <returns></returns>
        public Int32 ConvertToMono8(object obj, IntPtr pInData, IntPtr pOutData, ushort nHeight, ushort nWidth, MyCamera.MvGvspPixelType nPixelType)
        {
            if (IntPtr.Zero == pInData || IntPtr.Zero == pOutData)
            {
                return MyCamera.MV_E_PARAMETER;
            }

            int nRet = MyCamera.MV_OK;
            MyCamera device = obj as MyCamera;
            MyCamera.MV_PIXEL_CONVERT_PARAM stPixelConvertParam = new MyCamera.MV_PIXEL_CONVERT_PARAM();

            stPixelConvertParam.pSrcData = pInData;//源数据
            if (IntPtr.Zero == stPixelConvertParam.pSrcData)
            {
                return -1;
            }

            stPixelConvertParam.nWidth = nWidth;//图像宽度
            stPixelConvertParam.nHeight = nHeight;//图像高度
            stPixelConvertParam.enSrcPixelType = nPixelType;//源数据的格式
            stPixelConvertParam.nSrcDataLen = (uint)(nWidth * nHeight * ((((uint)nPixelType) >> 16) & 0x00ff) >> 3);

            stPixelConvertParam.nDstBufferSize = (uint)(nWidth * nHeight * ((((uint)MyCamera.MvGvspPixelType.PixelType_Gvsp_RGB8_Packed) >> 16) & 0x00ff) >> 3);
            stPixelConvertParam.pDstBuffer = pOutData;//转换后的数据
            stPixelConvertParam.enDstPixelType = MyCamera.MvGvspPixelType.PixelType_Gvsp_Mono8;
            stPixelConvertParam.nDstBufferSize = (uint)(nWidth * nHeight * 3);

            nRet = device.MV_CC_ConvertPixelType_NET(ref stPixelConvertParam);//格式转换
            if (MyCamera.MV_OK != nRet)
            {
                return -1;
            }

            return nRet;
        }

        /// <summary>
        /// 其他彩色格式转为RGB8
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="pSrc"></param>
        /// <param name="nHeight"></param>
        /// <param name="nWidth"></param>
        /// <param name="nPixelType"></param>
        /// <param name="pDst"></param>
        /// <returns></returns>
        private Int32 ConvertToRGB(object obj, IntPtr pSrc, ushort nHeight, ushort nWidth, MyCamera.MvGvspPixelType nPixelType, IntPtr pDst)
        {
            if (IntPtr.Zero == pSrc || IntPtr.Zero == pDst)
            {
                return MyCamera.MV_E_PARAMETER;
            }

            int nRet = MyCamera.MV_OK;
            MyCamera device = obj as MyCamera;
            MyCamera.MV_PIXEL_CONVERT_PARAM stPixelConvertParam = new MyCamera.MV_PIXEL_CONVERT_PARAM();

            stPixelConvertParam.pSrcData = pSrc;//源数据
            if (IntPtr.Zero == stPixelConvertParam.pSrcData)
            {
                return -1;
            }

            stPixelConvertParam.nWidth = nWidth;//图像宽度
            stPixelConvertParam.nHeight = nHeight;//图像高度
            stPixelConvertParam.enSrcPixelType = nPixelType;//源数据的格式
            stPixelConvertParam.nSrcDataLen = (uint)(nWidth * nHeight * ((((uint)nPixelType) >> 16) & 0x00ff) >> 3);

            stPixelConvertParam.nDstBufferSize = (uint)(nWidth * nHeight * ((((uint)MyCamera.MvGvspPixelType.PixelType_Gvsp_RGB8_Packed) >> 16) & 0x00ff) >> 3);
            stPixelConvertParam.pDstBuffer = pDst;//转换后的数据
            stPixelConvertParam.enDstPixelType = MyCamera.MvGvspPixelType.PixelType_Gvsp_RGB8_Packed;
            stPixelConvertParam.nDstBufferSize = (uint)nWidth * nHeight * 3;

            nRet = device.MV_CC_ConvertPixelType_NET(ref stPixelConvertParam);//格式转换
            if (MyCamera.MV_OK != nRet)
            {
                return -1;
            }

            return MyCamera.MV_OK;
        }

        /// <summary>
        /// 设置曝光
        /// </summary>
        /// <param name="exposure"></param>
        public void SetExposure(float exposure)
        {
            int nRet = 0;
            nRet = m_pMyCamera.MV_CC_ClearImageBuffer_NET();
            nRet = m_pMyCamera.MV_CC_SetFloatValue_NET("ExposureTime", exposure);
            if (MyCamera.MV_OK != nRet)
            {
                MessageBox.Show("设置曝光失败");
            }
        }
        /// <summary>
        /// 设置增益
        /// </summary>
        /// <param name="gain"></param>
        public void SetGain(float gain)
        {
            int nRet = 0;
            nRet = m_pMyCamera.MV_CC_ClearImageBuffer_NET();
            nRet = m_pMyCamera.MV_CC_SetFloatValue_NET("Gain", gain);
            if (MyCamera.MV_OK != nRet)
            {
                MessageBox.Show("设置增益失败");
            }
        }
        /// <summary>
        /// 关闭相机
        /// </summary>
        public void CloseCam()
        {
            if (m_bGrabbing)
            {
                m_bGrabbing = false;
                // ch:停止抓图 || en:Stop grab image
                m_pMyCamera.MV_CC_StopGrabbing_NET();
            }
            // ch:关闭设备 || en: Close device
            m_pMyCamera.MV_CC_CloseDevice_NET();
            m_bGrabbing = false;
        }
    }
}
