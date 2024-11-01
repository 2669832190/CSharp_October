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

namespace _10_29_连接相机2_ {
	public partial class Form1 : Form {
		public Form1() {
			InitializeComponent();
		}

		//相机配置保存地址
		string path = Directory.GetCurrentDirectory() + "\\vpp\\AcqFifoTool.vpp";

		//相机工具
		CogAcqFifoTool fifoTool;

		private void Form1_Load(object sender , EventArgs e) {
			fifoTool = CogSerializer.LoadObjectFromFile(path) as CogAcqFifoTool;
			cogAcqFifoEditV21.Subject = fifoTool;
		}

		private void Form1_FormClosing(object sender , FormClosingEventArgs e) {
			if ( fifoTool != null && fifoTool.Operator.FrameGrabber != null ) {
				fifoTool.Operator.FrameGrabber.Disconnect(false);
			}
		}

		//拍照
		private void button1_Click(object sender , EventArgs e) {
			if ( fifoTool != null && fifoTool.Operator.FrameGrabber != null ) {

				fifoTool.Run();

				cogRecordDisplay1.Image = fifoTool.OutputImage;
				cogRecordDisplay1.Fit();
			} else {
				MessageBox.Show("无相机连接！","提示");
			}
		}

		//开启实时显示画面
		private void button2_Click(object sender , EventArgs e) {
			cogRecordDisplay1.StartLiveDisplay(fifoTool.Operator,false);
		}

		//关闭实时显示画面
		private void button3_Click(object sender , EventArgs e) {
			cogRecordDisplay1.StopLiveDisplay();

		}

		//保存相机配置
		private void button4_Click(object sender , EventArgs e) {
			CogSerializer.SaveObjectToFile(fifoTool,path);
		}
	}
}
