using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 窗体传值修改 {
	public partial class Update : Form {
		string index;
		public string newindex;
		public string[] UserMessages;
		string[] UserName;
		string[] UserPassword;
		public Update(string index) {
			this.index = index;
			InitializeComponent();
		}
		
		private void Update_Load(object sender , EventArgs e) {
			UserMessages = index.Split(';');
			UserName = UserMessages[0].Split(':');
			UserPassword = UserMessages[1].Split(':');
			UserNameText.Text = UserName[1];
			UserPassWordText.Text = UserPassword[1];
		}
		private void button1_Click(object sender , EventArgs e) {
			newindex = UserName[0] + ":" + UserName[1] + ";" + UserPassword[0] + ":" + UserPassWordText.Text;
			this.Close();
		}
	}
}
