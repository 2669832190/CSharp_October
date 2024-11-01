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
using Cognex.VisionPro.ImageProcessing;

namespace TB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //创建VisionproVPP类
        VisionproVPP vision = new VisionproVPP();

        private void Form1_Load(object sender, EventArgs e)
        {
            //加载VPP
            if (!vision.LoadVpp())
            {
                //加载失败了
                MessageBox.Show("VPP加载失败!");
            }
            
        }

        //拍照按钮
        private void button1_Click(object sender, EventArgs e)
        {
            //相机工具运行
            vision.acqFifoTool.Run();
            //显示图片
            cogRecordDisplay1.Image = vision.acqFifoTool.OutputImage;
            cogRecordDisplay1.Fit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //关闭相机
            vision.CloseCam();
        }

        //运行TB按钮
        private void button2_Click(object sender, EventArgs e)
        {
            //彩色图转灰度图
            CogImageConvertTool convertTool = new CogImageConvertTool();
            //输入彩色图
            convertTool.InputImage = vision.acqFifoTool.OutputImage;
            //运行
            convertTool.Run();
            //获取输出
            CogImage8Grey cogImage8Grey = convertTool.OutputImage as CogImage8Grey;



            //把图像 给 TB 的输入
            vision.TB.Inputs["InputImage"].Value = cogImage8Grey;
            //运行
            vision.TB.Run();
            //判断TB运行是否成功
            if(vision.TB.RunStatus.Result == CogToolResultConstants.Accept)
            {
                //拿到结果
                widthLabel.Text = vision.TB.Outputs["Width"].Value.ToString();
            }
            else
            {
                MessageBox.Show("运行失败!");
            }

            //显示运行结果
            cogRecordDisplay2.Record = vision.TB.CreateLastRunRecord().SubRecords["CogPMAlignTool1.InputImage"];
            cogRecordDisplay2.Fit();
        }
    }
}
