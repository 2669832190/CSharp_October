using Cognex.VisionPro;
using Cognex.VisionPro.ImageProcessing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10_30_TB工具盒_ {
	public partial class Form1 : Form {
		public Form1() {
			InitializeComponent();
		}
		LoadVpp loadVpp = new LoadVpp();
		private void Form1_Load(object sender , EventArgs e) {
			if ( !loadVpp.LoadVPP() ) {
				MessageBox.Show("vpp配置加载失败","提示");
			}
		}

		private void Form1_FormClosing(object sender , FormClosingEventArgs e) {
			loadVpp.CloseCam();
		}

		private void button1_Click(object sender , EventArgs e) {
			//loadVpp.AcqFifo.Run();

			cogDisplay1.Image = loadVpp.AcqFifo.OutputImage;
			cogDisplay1.Fit();
		}

		private void button2_Click(object sender , EventArgs e) {
			CogImageConvertTool cogImageConvertTool = new CogImageConvertTool();
			cogImageConvertTool.InputImage = loadVpp.AcqFifo.OutputImage;
			cogImageConvertTool.Run();
			CogImage8Grey image8Grey = cogImageConvertTool.OutputImage as CogImage8Grey;
			//CogImage8Grey image8Grey = loadVpp.AcqFifo.OutputImage as CogImage8Grey;
			
			loadVpp.ToolBlock.Inputs["InputImg"].Value = image8Grey;
			loadVpp.ToolBlock.Run();

			if ( loadVpp.ToolBlock.RunStatus.Result == CogToolResultConstants.Accept ) {
				label1.Text = "Width:"+loadVpp.ToolBlock.Outputs["Width"].Value.ToString();
			} else {
				MessageBox.Show("运行失败");
			}

			
			cogRecordDisplay1.Record = loadVpp.ToolBlock.CreateLastRunRecord().SubRecords["CogPMAlignTool1.InputImage"];
			cogRecordDisplay1.Fit();
		}	
	}
}
