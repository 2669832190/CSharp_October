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

namespace TB_Ran事件
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Vision vision = new Vision();

        private void Form1_Load(object sender, EventArgs e)
        {
            vision.LoadVPP();

            vision.TB.Ran += tb_Ran;
        }

        //TB运行完以后 会自动运行这个方法
        private void tb_Ran(object sender, EventArgs e)
        {
            string count = vision.TB.Outputs["Count"].Value.ToString();
            countLabel.Text = count;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dirPath = Directory.GetCurrentDirectory() + "\\image";
            //加载图片
            string[] files = Directory.GetFiles(dirPath);
            //先清空listBox里原有的内容
            listBox1.Items.Clear();
            //遍历加载
            foreach (string file in files)
            {
                listBox1.Items.Add(file);
            }
        }

        //选中的项 更改时 触发
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //拿到选中的行的内容 实际上就拿到了路径
            string filePath = listBox1.SelectedItem.ToString();
            //Bitmap格式
            Bitmap bmp = new Bitmap(filePath);
            //转换为24位彩色图
            CogImage24PlanarColor image = new CogImage24PlanarColor(bmp);

            //检测
            vision.TB.Inputs["InputImage"].Value = image;
            vision.TB.Run();
            //显示图像
            cogRecordDisplay1.Record = vision.TB.CreateLastRunRecord().SubRecords[0];
            cogRecordDisplay1.Fit();
        }
    }
}
