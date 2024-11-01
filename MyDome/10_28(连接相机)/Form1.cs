using Cognex.VisionPro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10_28_连接相机_ {
	public partial class Form1 : Form {
		public Form1() {
			InitializeComponent();
		}
		//新建相机集合
		CogFrameGrabbers grabbers = new CogFrameGrabbers();
		//声明一个相机硬件
		ICogFrameGrabber fg = null;
		//声明一个相机
		ICogAcqFifo fifo = null;
		private void Form1_Load(object sender , EventArgs e) {
			if ( grabbers.Count > 0 ) {
				fg = grabbers[0];
				fifo = grabbers[0].CreateAcqFifo("Generic GigEVision (Mono)" , CogAcqFifoPixelFormatConstants.Format8Grey,0,true);
				fifo.Complete += Fifo_Complete;
				fifo.OwnedExposureParams.Exposure = 200;
			} else {
				MessageBox.Show("没有相机连接！","提示");
			}
		}
		private void Fifo_Complete(object sender , CogCompleteEventArgs e) { 
			int numPendingVal , numReadyVal ;
			bool busyFlay;
			fifo.GetFifoState(out numPendingVal , out numReadyVal , out busyFlay);
			CogImage8Grey image = new CogImage8Grey();
			CogAcqInfo info = new CogAcqInfo();
			if ( numReadyVal > 0 ) {
				image = fifo.CompleteAcquireEx(info) as CogImage8Grey;
				cogRecordDisplay1.Image = image;
				cogRecordDisplay1.Fit();
			}
		}
		private void button1_Click(object sender , EventArgs e) { 
			fifo.StartAcquire();
		}

	}
}
/*
 * 
 //相机集合 所有已经连接的相机
		CogFrameGrabbers grabbers = new CogFrameGrabbers();
		//声明一个相机硬件
		ICogFrameGrabber fg = null;
		//声明一个相机
		ICogAcqFifo fifo = null;
		private void Form1_Load(object sender , EventArgs e) {
			// > 0 说明有相机连接
			if ( grabbers.Count > 0 ) {
				//拿到一个相机
				fg = grabbers[0];
				//创建acq
				//grabbers[0].CreateAcqFifo(视频格式,像素的类型,缓冲区的数量,是否自动触发)
				fifo = grabbers[0].CreateAcqFifo("Generic GigEVision (Mono)" , CogAcqFifoPixelFormatConstants.Format8Grey , 0 , true);

				//绑定事件 图像采集完成后 调用这个方法
				fifo.Complete += Fifo_Complete;

				//曝光
				fifo.OwnedExposureParams.Exposure = 100;
			} else {
				//没有连接到相机
				MessageBox.Show("没有相机连接");
			}
		}
		//拍照完成之后再运行这个方法
		private void Fifo_Complete(object sender , CogCompleteEventArgs e) {
			int numPendingVal, numReadyVal;
			bool busyFlag;
			//fifo.GetFifoState(等待处理的采集请求数量,已经处理的采集请求,是否正在处理采集请求)
			fifo.GetFifoState(out numPendingVal , out numReadyVal , out busyFlag);
			//查看运行结果
			//MessageBox.Show(numPendingVal + "=====" + numReadyVal + "=====" + busyFlag);
			//创建图片
			CogImage8Grey image8Grey = new CogImage8Grey();
			//创建图像的采集信息
			CogAcqInfo info = new CogAcqInfo();
			if ( numReadyVal > 0 ) {
				//接收图像
				image8Grey = fifo.CompleteAcquireEx(info) as CogImage8Grey;
				cogRecordDisplay1.Image = image8Grey;
				//适合图像
				cogRecordDisplay1.Fit();
			}

		}
		//拍照按钮
		private void button1_Click(object sender , EventArgs e) {
			//开始拍照 给采集队列添加了一条拍照请求
			fifo.StartAcquire();
		}

 */