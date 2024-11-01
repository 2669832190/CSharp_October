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
	public partial class StudentMessages : Form {
		public StudentMessages() {
			InitializeComponent();
		}

		private void StudentMessages_Load(object sender , EventArgs e) {
			List<string> studentMessages = File.ReadAllLines(@"./StudentsMessages.txt").ToList();
			string[] strings = new string[7];
			for ( int i = 0; i < studentMessages.Count; i++ ) {
				string[] messages = studentMessages[i].Split(';');
				for ( int j = 0; j < messages.Length; j++ ) {
					string[] Messages = messages[j].Split(':');
					strings[j] = Messages[1];
				}
				//Id
				Label Id = new Label();
				Id.Font = new Font("宋体" , 18);
				Id.Text = strings[0];
				Id.Location = new Point(StudentID.Location.X , StudentID.Location.Y + ( 50 * ( i + 1 ) ));
				this.Controls.Add(Id);
				//姓名
				Label Name = new Label();
				Name.AutoSize = true;
				Name.Font = new Font("宋体" , 18);
				Name.Text = strings[1];
				Name.Location = new Point(StudentName.Location.X , StudentName.Location.Y + ( 50 * ( i + 1 ) ));
				this.Controls.Add(Name);
				//性别
				Label Sex = new Label();
				Sex.AutoSize = true;
				Sex.Font = new Font("宋体" , 18);
				Sex.Text = strings[2];
				Sex.Location = new Point(StudentSex.Location.X , StudentSex.Location.Y + ( 50 * ( i + 1 ) ));
				this.Controls.Add(Sex);
				//年龄
				Label Age = new Label();
				Age.AutoSize = true;
				Age.Font = new Font("宋体" , 18);
				Age.Text = strings[3];
				Age.Location = new Point(StudentAge.Location.X , StudentAge.Location.Y + ( 50 * ( i + 1 ) ));
				this.Controls.Add(Age);
				//班级
				Label Class = new Label();
				Class.AutoSize = true;
				Class.Font = new Font("宋体" , 18);
				Class.Text = strings[4];
				Class.Location = new Point(StudentClass.Location.X - 40 , StudentClass.Location.Y + ( 50 * ( i + 1 ) ));
				this.Controls.Add(Class);
				//地址
				Label Address = new Label();
				Address.Font = new Font("宋体" , 18);
				Address.AutoSize = true;
				Address.Text = strings[5];
				Address.Location = new Point(StudentAddress.Location.X , StudentAddress.Location.Y + ( 50 * ( i + 1 ) ));
				this.Controls.Add(Address);
				//电话
				Label Phone = new Label();
				Phone.Font = new Font("宋体" , 18);
				Phone.AutoSize = true;
				Phone.Text = strings[6];
				Phone.Location = new Point(StudentPhone.Location.X , StudentPhone.Location.Y + ( 50 * ( i + 1 ) ));
				this.Controls.Add(Phone);
				//删除按钮
				Button Remove = new Button();
				Remove.Location = new Point(StudentPhone.Location.X + 300 , StudentPhone.Location.Y + ( 50 * ( i + 1 ) - 10 ));
				Remove.Size = new Size(150 , 50);
				Remove.Text = "删除信息";
				Remove.Name = "RemoveMessage";
				Remove.Tag = i;
				Remove.Click += new EventHandler(RemoveMessage_Click);
				Remove.Font = new Font("宋体" , 18);
				this.Controls.Add(Remove);
				//修改按钮
				Button Amend = new Button();
				Amend.Location = new Point(StudentPhone.Location.X + 500 , StudentPhone.Location.Y + ( 50 * ( i + 1 ) - 10 ));
				Amend.Size = new Size(150 , 50);
				Amend.Text = "修改信息";
				Amend.Tag = i;
				Amend.Click += new EventHandler(Amend_Click);
				Amend.Name = "Amend";
				Amend.Font = new Font("宋体" , 18);
				this.Controls.Add(Amend);
			}
		}
		/// <summary>
		/// 添加学生信息，打开新的窗体
		/// </summary>
		private void AddStudentMessages_Click(object sender , EventArgs e) {
			AddStudent addStudent = new AddStudent();
			//打开添加学生的窗体进行输入学生信息
			addStudent.ShowDialog();
			//重新加载学生信息
			StudentMessages_Load(sender , e);
		}
		/// <summary>
		/// 关闭学生信息窗体时主程序同时关闭
		/// </summary>
		private void StudentMessages_FormClosed(object sender , FormClosedEventArgs e) {
			Application.Exit();
		}
		/// <summary>
		/// 删除按钮点击时间
		/// </summary>
		private void RemoveMessage_Click(object sender , EventArgs e) {
			//获取行的索引
			Button button = sender as Button;
			//
			List<string> messages = File.ReadAllLines(@"./StudentsMessages.txt").ToList();
			messages.RemoveAt((int)button.Tag);
			File.WriteAllLines(@"./StudentsMessages.txt" , messages);
			this.Controls.Clear();
			InitializeComponent();
			StudentMessages_Load(sender,e);
		}
		private void Amend_Click(object sender , EventArgs e) {
			Button button = sender as Button;
			List<string> messages = File.ReadAllLines(@"./StudentsMessages.txt").ToList();
			int index = (int)button.Tag;
			Amend amend = new Amend(index,ref messages);
			amend.ShowDialog();
			File.WriteAllLines(@"./StudentsMessages.txt" , messages);
			this.Controls.Clear();
			InitializeComponent();
			StudentMessages_Load(sender , e);
		}

		private void InquireMessages_Click(object sender , EventArgs e) {
			List<string> messages = File.ReadAllLines(@"./StudentsMessages.txt").ToList();
			Inquire inquire = new Inquire(messages);
			inquire.ShowDialog();
		}
	}
}