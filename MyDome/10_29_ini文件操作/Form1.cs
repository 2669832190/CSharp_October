using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10_29_ini文件操作 {
	public partial class Form1 : Form {
		public Form1() {
			InitializeComponent();
		}
		/*Dictionary<string,int> keyValues = new Dictionary<string, int>{
		

		};*/
		string path = Directory.GetCurrentDirectory() + "\\ini\\init.ini";
		
		private void Form1_Load(object sender , EventArgs e) {
			//写
			/*if ( Ini.IniAPI.INIWriteItems(path , "节点1" , "曝光=200\0增益=10") ) {
				MessageBox.Show("写入成功" , "提示");
			} else {
				MessageBox.Show("写入失败","提示");
			}*/

			//读
			//MessageBox.Show("节点1，曝光值为" + Ini.IniAPI.GetPrivateProfileInt("节点1" , "曝光" , 100 , path));

		}
	}
}
