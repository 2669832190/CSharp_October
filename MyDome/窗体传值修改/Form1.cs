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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace 窗体传值修改 {
	public partial class Form1 : Form {
		List<string> UserMessages = File.ReadAllLines(@"./UserMessage.txt").ToList();
		public Form1() {
			InitializeComponent();
		}
		private void Form1_Load(object sender , EventArgs e) {
			for ( int i = 0; i < UserMessages.Count; i++ ) {
				listBox1.Items.Add(segmentation(UserMessages[i]));
			}
		}

		private void button1_Click(object sender , EventArgs e) {
			try {
				int indexNum = listBox1.SelectedIndex;
				string index = UserMessages[indexNum];
				Update update = new Update(index);
				update.ShowDialog();
				UserMessages[indexNum] = update.newindex;
				File.WriteAllLines(@"./UserMessage.txt" , UserMessages);
				listBox1.Items.Clear();
				Form1_Load(sender , e);
			} catch ( Exception ) {}
		}
		private string segmentation(string index) {
			string[] UserMessages = index.Split(';');
			string temp = UserMessages[0] + "\t" + UserMessages[1];
			return temp;
		}
	}
}
