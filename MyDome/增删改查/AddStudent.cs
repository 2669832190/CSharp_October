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
	public partial class AddStudent : Form {
		public AddStudent() {
			InitializeComponent();
		}
		private void button1_Click(object sender , EventArgs e) {
			string Id = IDText.Text;
			string Name = NameText.Text;
			string Sex = SexText.Text;
			string Age = AgeText.Text;
			string Class = ClassText.Text;
			string Address = AddressText.Text;
			string Phone = PhoneText.Text;
			string NewMessage = "ID:"+ Id + ";Name:"+ Name + ";Sex:"+ Sex + ";Age:"+ Age + ";Class:"+ Class + ";Address:"+ Address + ";Phone:"+ Phone;
			List<string> messages = File.ReadAllLines(@"./StudentsMessages.txt").ToList();
			messages.Add(NewMessage);
			File.WriteAllLines(@"./StudentsMessages.txt",messages);
			this.Close();
		}
	}
}
