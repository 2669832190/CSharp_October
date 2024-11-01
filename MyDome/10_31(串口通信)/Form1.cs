using System;
using System.IO.Ports;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10_31_串口通信_ {
	public partial class Form1 : Form {
		public Form1() {
			InitializeComponent();
		}
		SerialPort port = new SerialPort();
		private void Form1_Load(object sender , EventArgs e) {
			port.PortName = "COM2";
			port.BaudRate = 9600;
			port.Parity = Parity.None;
			port.StopBits = StopBits.One;
			port.DataReceived += port_Date;

			port.Open();
		}
		private void port_Date(object sender , SerialDataReceivedEventArgs e) { 
			int size = port.BytesToRead;

			byte[] data = new byte[size];

			port.Read(data, 0, size);

			string msg = Encoding.UTF8.GetString(data);

			if ( msg.Contains("T1") ) {
				port.WriteLine("OK");
			} else {
				port.WriteLine("");
			}
		}
	}
}
