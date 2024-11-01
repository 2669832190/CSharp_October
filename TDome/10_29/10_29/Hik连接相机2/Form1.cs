using HikDLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * 写代码之前的步骤
 * 1. 引用MVS的SDK : MVS\Development\DotNet\win64\MvCamCtrl.Net.dll
 * 2. 引用visionpro的SDK : VisionPro\ReferencedAssemblies文件夹下
 *          核心(Core CorePlus) 控件(Controls) 显示屏(Display.Controls) 以及没有后缀的Cognex.VisionPro
 * 3. 导入代码文件 IniAPI(读取INI文件) EnumCamDevice(使用海康SDK连接相机)
 * 4. 项目属性 => 生成 => 目标平台改为64位 允许不安全代码
 */

namespace Hik连接相机2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //1. 声明相机
        HikCam cam1;

        private void Form1_Load(object sender, EventArgs e)
        {
            //2. 找到所有的连接设备 (初始化相机)
            EnumCamDevice.DeviceListAcq();

            //3. 创建相机
            cam1 = new HikCam("相机1");

            //5. 添加事件 当拍照完成后运行的方法
            cam1.CamAcqCompleteEvent += Cam1_CamAcqCompleteEvent;
        }

        private void Cam1_CamAcqCompleteEvent(string camName, Cognex.VisionPro.ICogImage image)
        {
            //拍完照后的图片 赋值给 显示屏
            cogRecordDisplay1.Image = image;
            cogRecordDisplay1.Fit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //4. 拍照
            cam1.Run();
        }

        //6. 关闭窗体的时候 关闭相机
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(cam1 != null)
            {
                cam1.CamAcqCompleteEvent -= Cam1_CamAcqCompleteEvent;
                cam1.CloseCam();
            }
        }
    }
}
