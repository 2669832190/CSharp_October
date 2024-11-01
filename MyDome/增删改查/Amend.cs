using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 增删改查 {
	public partial class Amend : Form {
		List<string> messages;
		int index;
		public Amend(int index , ref List<string> messages) {
			this.index = index;
			this.messages = messages;
			InitializeComponent();
		}
		private void Amend_Load(object sender , EventArgs e) {
			string NewMessage = messages[index];
			messages.RemoveAt(index);
			string[] newmessagesall = NewMessage.Split(';');
			string[] New = new string[newmessagesall.Length];
			for ( int i = 0; i < newmessagesall.Length; i++ ) {
				New[i] = newmessagesall[i].Split(':')[1];
			}
			IDText.Text = New[0];
			NameText.Text = New[1];
			SexText.Text = New[2];
			AgeText.Text = New[3];
			ClassText.Text = New[4];
			AddressText.Text = New[5];
			PhoneText.Text = New[6];

		}
		private void button1_Click(object sender , EventArgs e) {
			string New = "ID:" + IDText.Text + ";Name:" + NameText.Text + ";Sex:" + SexText.Text + ";Age:" + AgeText.Text + ";Class:" + ClassText.Text + ";Address:" + AddressText.Text + ";Phone:" + PhoneText.Text;
			messages.Insert(index,New);
			this.Close();
		}
	}
}
