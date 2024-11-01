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

namespace 作业
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Vision Vision = new Vision();
        int od = 0;
        int result = 0;
        string iniPath = Directory.GetCurrentDirectory() + "\\ini\\filename.ini";

        FileOperate FileOperate = new FileOperate();

        private void Form1_Load(object sender, EventArgs e)
        {
            Vision.LoadVpp();
            //ToolBlock运行完以后的事件
            Vision.TB.Ran += tb_Ran;
            //读取ini文件
            od = Ini.IniAPI.GetPrivateProfileInt("imgNum", "od", 0, iniPath);
            result = Ini.IniAPI.GetPrivateProfileInt("imgNum", "result", 0, iniPath);
        }

        #region 第一题
        //TB运行完成后的事件
        private void tb_Ran(object sender, EventArgs e)
        {
            string count = Vision.TB.Outputs["Count"].Value.ToString();
            countLabel.Text = count;

            //检测完成了 写入csv文件
            FileOperate.WriteCSV(count);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = Directory.GetCurrentDirectory() + "\\img";

            string[] files = Directory.GetFiles(path);

            listBox1.Items.Clear();
            foreach (string file in files)
            {
                listBox1.Items.Add(file);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string fileName = listBox1.SelectedItem.ToString();

            Bitmap bmp = new Bitmap(fileName);
            //转为彩色图
            CogImage24PlanarColor img24Planar = new CogImage24PlanarColor(bmp);

            Vision.TB.Inputs["InputImage"].Value = img24Planar;
            Vision.TB.Run();

            //显示图片
            cogRecordDisplay1.Record = Vision.TB.CreateLastRunRecord().SubRecords[0];
            cogRecordDisplay1.Fit();
        }

        #endregion

        private void button2_Click(object sender, EventArgs e)
        {
            string path = listBox1.SelectedItem.ToString();
            Bitmap bmp = new Bitmap(path);

            //找到对应的文件夹
            string filePath = Directory.GetCurrentDirectory() + "\\image\\od\\";
            //图片保存的文件名
            string fileName = filePath + $"\\{od}.bmp";

            if (!Directory.Exists(filePath))
            {
                Directory.CreateDirectory(filePath);
            }
            //保存图片
            bmp.Save(fileName,System.Drawing.Imaging.ImageFormat.Bmp);


            //保存完图片 od+1 再保存回ini文件
            od++;
            Ini.IniAPI.INIWriteValue(iniPath, "imgNum", "od", od.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {

            //找到对应的文件夹
            string filePath = Directory.GetCurrentDirectory() + "\\image\\result\\";
            //图片保存的文件名
            string fileName = filePath + $"\\{result}.bmp";

            if (!Directory.Exists(filePath))
            {
                Directory.CreateDirectory(filePath);
            }
            //获取到图片
            Bitmap bmp = cogRecordDisplay1.CreateContentBitmap(Cognex.VisionPro.Display.CogDisplayContentBitmapConstants.Image) as Bitmap;
            bmp.Save(fileName, System.Drawing.Imaging.ImageFormat.Bmp);

            //保存完图片 result+1 再保存回ini文件
            result++;
            Ini.IniAPI.INIWriteValue(iniPath, "imgNum", "result", result.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            StringBuilder sb = FileOperate.ReadCSV();
            MessageBox.Show(sb.ToString());
        }
    }
}
