using Cognex.VisionPro;
using Cognex.VisionPro.ToolBlock;
using Cognex.VisionPro.ToolGroup;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TB
{
    //用来处理VPP
    internal class VisionproVPP
    {
        #region vpp的声明
        //相机工具
        public CogAcqFifoTool acqFifoTool {  get; set; }
        public CogToolBlock TB {  get; set; }
        #endregion

        #region vpp路径
        private string acqPath = Directory.GetCurrentDirectory() + "\\vpp\\AcqFifoTool.vpp";
        private string TBPath = Directory.GetCurrentDirectory() + "\\vpp\\ToolBlock.vpp";

        #endregion


        #region vpp加载关闭
        /// <summary>
        /// 加载VPP
        /// </summary>
        /// <returns>是否加载成功</returns>
        public bool LoadVpp()
        {
            acqFifoTool = CogSerializer.LoadObjectFromFile(acqPath) as CogAcqFifoTool;
            TB = CogSerializer.LoadObjectFromFile(TBPath) as CogToolBlock;

            //曝光
            acqFifoTool.Operator.OwnedExposureParams.Exposure = 200;

            if(acqFifoTool == null || TB == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// 关闭相机
        /// </summary>
        public void CloseCam()
        {
            if(acqFifoTool != null)
            {
                acqFifoTool.Dispose();
            }
        }
        #endregion

    }
}
