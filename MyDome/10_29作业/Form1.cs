using HikDLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MvCamCtrl.NET;
using Cognex.VisionPro;
using System.IO;

namespace _10_29作业 {
	public partial class Form1 : Form {
		public Form1() {
			InitializeComponent();
		}

		/*
		 * 写代码之前的步骤
		 * 1. 引用MVS的SDK : MVS\Development\DotNet\win64\MvCamCtrl.Net.dll
		 * 2. 引用visionpro的SDK : VisionPro\ReferencedAssemblies文件夹下
		 *          核心(Core CorePlus) 控件(Controls) 显示屏(Display.Controls) 以及没有后缀的Cognex.VisionPro
		 * 3. 导入代码文件 IniAPI(读取INI文件) EnumCamDevice(使用海康SDK连接相机)
		 * 4. 项目属性 => 生成 => 目标平台改为64位 允许不安全代码
		 */

		//声明相机
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
				MessageBox.Show("无相机连接！" , "提示");
			}
		}

		
	}
}
