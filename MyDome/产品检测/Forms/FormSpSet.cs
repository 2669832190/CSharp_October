using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 产品检测.Forms {
	public partial class FormSpSet1 : Form {
		/// <summary>
		/// 串口数据数组
		/// </summary>
		string[] portSet = new string[5];
		
		public FormSpSet1(ref string[] portSet) {
			InitializeComponent();
			this.portSet = portSet;
		}

		private void button1_Click(object sender , EventArgs e) {
			portSet[0] = SpName.Text;
			portSet[1] = Btl.Text;
			portSet[2] = Sjw.Text;
			portSet[3] = Jyw.Text;
			portSet[4] = Tzw.Text;
			//运行完成提示！
		}

		private void FormSpSet_Load(object sender , EventArgs e) {
			if ( portSet != null ) {
				SpName.Text = portSet[0];
				Btl.Text = portSet[1];
				Sjw.Text = portSet[2];
				Jyw.Text = portSet[3];
				Tzw.Text = portSet[4];
			}
		}

		private void button2_Click(object sender , EventArgs e) {
			this.Close();
		}

		private void FormSpSet1_FormClosed(object sender , FormClosedEventArgs e) {

		}
	}
}
