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

namespace _10_30_TB_Ran_ {
	public partial class Form1 : Form {
		public Form1() {
			InitializeComponent();
		}
		LoadToolBlock loadToolBlock = new LoadToolBlock();
		private void Form1_Load(object sender , EventArgs e) {
			loadToolBlock.Loadvpp();

			loadToolBlock.ToolBlock.Ran += ToolBlock_Ran;
		}

		private void ToolBlock_Ran(object sender , EventArgs e) {
			label2.Text = loadToolBlock.ToolBlock.Outputs["Count"].Value.ToString();
		}
		private void button1_Click(object sender , EventArgs e) {
			string Path = Directory.GetCurrentDirectory() + "\\image";
			string[] filesPath = Directory.GetFiles(Path);
			listBox1.Items.Clear();
            foreach (var item in filesPath)
            {
                listBox1.Items.Add(item);
            }

        }

		private void listBox1_SelectedIndexChanged(object sender , EventArgs e) {
			string path = listBox1.SelectedItem.ToString();

			Bitmap bmp = new Bitmap(path);

			CogImage24PlanarColor img = new CogImage24PlanarColor(bmp);

			loadToolBlock.ToolBlock.Inputs["InputImage"].Value = img;

			loadToolBlock.ToolBlock.Run();

			cogRecordDisplay1.Record = loadToolBlock.ToolBlock.CreateLastRunRecord().SubRecords[0];
			cogRecordDisplay1.Fit();
		}
	}
}
