using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cognex.VisionPro;
using HikDLL;

namespace Hik连接相机
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //声明相机
        HikCam cam1;

        private void Form1_Load(object sender, EventArgs e)
        {

            //枚举相机
            EnumCamDevice.DeviceListAcq();

            cam1 = new HikCam("相机1");

            cam1.CamAcqCompleteEvent += Cam1_CamAcqCompleteEvent;

            /*string path = Directory.GetCurrentDirectory() + "\\Cam\\Camera.ini";
            Ini.IniAPI.INIWriteValue(path, "相机1", "SN", "DA1540992");
            Ini.IniAPI.INIWriteValue(path, "相机1", "Exposure", "200");
            Ini.IniAPI.INIWriteValue(path, "相机1", "Gain", "10");*/
        }

        //相机名 图片
        public void Cam1_CamAcqCompleteEvent(string camName, ICogImage image)
        {
            //显示图片
            cogRecordDisplay1.Image = image;
            cogRecordDisplay1.Fit();
        }

        //拍照
        private void button1_Click(object sender, EventArgs e)
        {
            cam1.Run();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            cam1.CamAcqCompleteEvent -= Cam1_CamAcqCompleteEvent;
            //释放相机
            cam1.CloseCam();
        }
    }
}
