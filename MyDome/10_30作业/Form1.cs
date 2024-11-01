using Cognex.VisionPro;
using Cognex.VisionPro.ImageFile;
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

namespace _10_30作业 {
	public partial class Form1 : Form {
		public Form1() {
			InitializeComponent();
		}
		LoadVPP loadVPP = new LoadVPP();
		
		/// <summary>
		/// 窗体加载时
		/// </summary>
		private void Form1_Load(object sender , EventArgs e) {
			loadVPP.LoadToolBlock();
			loadVPP.toolBlock.Ran += ToolBlock_Ran;
		}
		/// <summary>
		/// 加载图片
		/// </summary>
		private void button1_Click(object sender , EventArgs e) {
			string Path = Directory.GetCurrentDirectory() + "\\Img";
			string[] filesPath = Directory.GetFiles(Path);
			listBox1.Items.Clear();
            foreach (var item in filesPath)
            {
				listBox1.Items.Add(item);
            }
        }

		/// <summary>
		/// 选中文件运行工具得到缺陷处的个数
		/// </summary>
		private void listBox1_SelectedIndexChanged(object sender , EventArgs e) {
			string path = listBox1.SelectedItem as string;
			Bitmap bitmap = new Bitmap(path);
			CogImage24PlanarColor cogImage24 = new CogImage24PlanarColor(bitmap);
			loadVPP.toolBlock.Inputs["InputImage"].Value = cogImage24;

			loadVPP.toolBlock.Run();
			cogRecordDisplay1.Record = loadVPP.toolBlock.CreateLastRunRecord().SubRecords[0];
			cogRecordDisplay1.Fit();
		}

		/// <summary>
		/// 选中文件后缺陷数目的显示
		/// </summary>
		private void ToolBlock_Ran(object sender , EventArgs e) { 
			label1.Text = "缺陷数目:" + loadVPP.toolBlock.Outputs["Count"].Value.ToString();
		}
		/// <summary>
		/// 保存图片逻辑
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void button2_Click(object sender , EventArgs e) {
			string iniFilePath = Directory.GetCurrentDirectory() + "\\ini\\init.ini";
			string Path = Directory.GetCurrentDirectory() + "\\Image\\Former";
			string path = Directory.GetCurrentDirectory() + "\\Image\\New";
			//获取ini节点数
			string[] Name = Ini.IniAPI.INIGetAllSectionNames(iniFilePath);
			int i = 0;
			if ( Name.Length != 0 ) {
				i = Name.Length;
			}
			i++;
			#region 开始处理保存图片的逻辑
			//原图路径
			string FileName = Path + "\\"+i+".bmp";
			Bitmap bitmap = new Bitmap(listBox1.SelectedItem.ToString());
			bitmap.Save(FileName , System.Drawing.Imaging.ImageFormat.Bmp);

			//检测后的图像
			string fileName = path + "\\"+i+".bmp";
			Bitmap bmp = cogRecordDisplay1.CreateContentBitmap(Cognex.VisionPro.Display.CogDisplayContentBitmapConstants.Image) as Bitmap;
			bmp.Save(fileName , System.Drawing.Imaging.ImageFormat.Bmp);

			//运行完成提示
			if ( Ini.IniAPI.INIWriteItems(iniFilePath , i.ToString() , "FormerImage=" + i + "\0NewImage=" + i) ) {
				MessageBox.Show("保存成功，图片名称为：" + i + ".bmp" , "提示");
			}
			#endregion
		}
	}
}
