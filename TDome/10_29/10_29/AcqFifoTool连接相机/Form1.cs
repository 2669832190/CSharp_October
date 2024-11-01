using Cognex.VisionPro;
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



namespace AcqFifoTool连接相机
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //相机工具的vpp路径
        string path = Directory.GetCurrentDirectory() + "\\vpp\\AcqFifoTool.vpp";

        //声明visionpro里的照相机工具
        CogAcqFifoTool fifoTool;

        private void Form1_Load(object sender, EventArgs e)
        {
            //序列化 读取文件
            fifoTool = CogSerializer.LoadObjectFromFile(path) as CogAcqFifoTool;

            //工具赋值给窗体上的控件
            cogAcqFifoEditV21.Subject = fifoTool;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //加个判断 有相机才能释放
            if(fifoTool != null && fifoTool.Operator.FrameGrabber != null)
            {
                //释放相机
                fifoTool.Operator.FrameGrabber.Disconnect(false);
            }
        }

        //拍照
        private void button1_Click(object sender, EventArgs e)
        {
            //相机工具里有没有相机
            //fifoTool.Operator.FrameGrabber 相机工具.工具里的相机的配置等信息.相机
            if (fifoTool != null && fifoTool.Operator.FrameGrabber != null)
            {
                //运行拍照工具
                fifoTool.Run();

                //图像显示出来
                cogRecordDisplay1.Image = fifoTool.OutputImage;
                cogRecordDisplay1.Fit();
            }
        }

        //实时显示按钮
        private void button2_Click(object sender, EventArgs e)
        {
            //屏幕.实时显示(哪个相机？,是否优化性能(会有限制))
            cogRecordDisplay1.StartLiveDisplay(fifoTool.Operator,false);
        }

        //关闭实时显示
        private void button3_Click(object sender, EventArgs e)
        {
            cogRecordDisplay1.StopLiveDisplay();
        }

        //保存按钮
        private void button4_Click(object sender, EventArgs e)
        {
            CogSerializer.SaveObjectToFile(fifoTool, path);
        }

		private void cogAcqFifoEditV21_Load(object sender , EventArgs e) {

		}
	}
}