using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cognex.VisionPro;

//复习


namespace FrameGrabber连接相机
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //相机的集合
        CogFrameGrabbers cogFrameGrabbers = new CogFrameGrabbers();

        //相机硬件
        ICogFrameGrabber fg = null;

        //相机采集队列
        ICogAcqFifo fifo = null;

        //窗体加载时连接相机
        private void Form1_Load(object sender, EventArgs e)
        {
            if(cogFrameGrabbers.Count < 1)
            {
                MessageBox.Show("没有连接到设备");
                return;
            }

            fg = cogFrameGrabbers[0];
            fifo = cogFrameGrabbers[0].CreateAcqFifo("Generic GigEVision (Mono)",CogAcqFifoPixelFormatConstants.Format8Grey,0,true);

            fifo.OwnedExposureParams.Exposure = 200;

            fifo.Complete += Fifo_Complete;
        }

        private void Fifo_Complete(object sender, CogCompleteEventArgs e)
        {
            CogAcqInfo info = new CogAcqInfo();
            CogImage8Grey image8Grey = fifo.CompleteAcquireEx(info) as CogImage8Grey;

            cogRecordDisplay1.Image = image8Grey;
            //适合图像
            cogRecordDisplay1.Fit();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            fifo.StartAcquire();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //释放连接(是否允许重新连接)
            fg.Disconnect(false);
        }
    }
}
