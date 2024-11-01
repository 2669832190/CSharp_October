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

namespace 增删改查 {
	public partial class Login : Form {
		public bool IsTrue;
		public Login() {
			InitializeComponent();
		}
		/// <summary>
		/// 登录功能
		/// </summary>
		private void button1_Click(object sender , EventArgs e) {
			string Name;
			string Password;
			//接收备用
			string userName = UserNameText.Text;
			string userPasw = UserPassWordText.Text;
			//分割
			List<string> UMList = File.ReadAllLines(@"./UserMessages.txt").ToList();
			for ( int i = 0; i < UMList.Count; i++ ) { 
				Name = UMList[i].Split(';')[0].Split(':')[1];
				Password = UMList[i].Split(';')[1].Split(':')[1];
				if ( userName == Name && userPasw == Password ) {
					this.Hide();
					StudentMessages studentMessages = new StudentMessages();
					studentMessages.ShowDialog();
					break;
				} else if(i == UMList.Count - 1){
					MessageBox.Show("账号或密码错误","提示");
				}
			}
			
		}
	}
}
