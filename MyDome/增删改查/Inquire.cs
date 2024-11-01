using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 增删改查 {
	public partial class Inquire : Form {
		List<string> messages;
		List<string[]> message;
		public Inquire(List<string> messages) {
			this.messages = messages;
			InitializeComponent();
		}
		private void Inquire_Load(object sender , EventArgs e) {
			message = new List<string[]>();
			for(int i = 0; i <  messages.Count; i++ ) {
				string[] strings = messages[i].Split(';');
				string[] strings1 = new string[strings.Length];
				for (int j = 0; j < strings.Length; j++ ) {
					int p = 1;
					string item = strings[j].Split(':')[p];
					strings1[j] = item;
					p += 2;
				}
				message.Add(strings1);
			}
		}
		private void button1_Click(object sender , EventArgs e) {
			string type = TypeText.Text;
			string item = ItemText.Text;
			List<int> index = new List<int>();
			index.Clear();
			for ( int i = 5; i < this.Controls.Count; i++ ) {
				this.Controls.RemoveAt(i);
				i--;
			}
			switch ( type ) {
				case "学号":
					algorithm(item , ref index , 0);
					break;
				case "姓名":
					algorithm(item , ref index , 1);
					break;
				case "性别":
					algorithm(item , ref index , 2);
					break;
				case "年龄":
					algorithm(item , ref index , 3);
					break;
				case "班级":
					algorithm(item , ref index , 4);
					break;
				case "地址":
					algorithm(item , ref index , 5);
					break;
				case "电话":
					algorithm(item , ref index , 6);
					break;
				case "模糊查询":
					for ( int i = 0; i < message.Count; i++ ) {
						for ( int j = 0; j < message[i].Length; j++ ) {
							if ( message[i][j] == item ) {
								index.Add(i);
							}
						}
					}
					if ( index.Count != 0 ) {
						for ( int i = 0; i < index.Count; i++ ) {
							string[] Messages = message[index[i]];
							Label label = new Label();
							label.Text = "学号：" + Messages[0] + "    姓名：" + Messages[1] + "    性别：" + Messages[2] + "    年龄：" + Messages[3] + "    班级：" + Messages[4] + "    地址：" + Messages[5] + "    电话：" + Messages[6];
							label.Location = new Point(50 , 100 + ( 30 * ( i + 1 ) ));
							label.AutoSize = true;
							label.Font = new Font("宋体" , 18);
							label.Tag = label;
							this.Controls.Add(label);
						}
					} else {
						MessageBox.Show("未查询到相关信息，请确认信息是否正确！" , "提示");
					}
					break;
			}
		}
		private void algorithm(string item,ref List<int> index , int Index) {
			for ( int i = 0; i < message.Count; i++ ) {
				if ( message[i][Index] == item ) {
					index.Add(i);
				}
			}
			if ( index.Count != 0 ) {
				for ( int i = 0; i < index.Count; i++ ) {
					string[] Messages = message[index[i]];
					Label label = new Label();
					label.Text = "学号：" + Messages[0] + "    姓名：" + Messages[1] + "    性别：" + Messages[2] + "    年龄：" + Messages[3] + "    班级：" + Messages[4] + "    地址：" + Messages[5] + "    电话：" + Messages[6];
					label.Location = new Point(50 , 100 + ( 30 * ( i + 1 ) ));
					label.AutoSize = true;
					label.Font = new Font("宋体" , 18);
					this.Controls.Add(label);
				}
			} else {
				MessageBox.Show("未查询到相关信息，请确认信息是否正确！","提示");	
			}
		}
	}
}
