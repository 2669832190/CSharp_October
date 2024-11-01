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
using 学生管理.Mode;

namespace 学生管理
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Login login = new Login();
            login.ShowDialog();

            if (login.flag)
            {
                //登录成功，开始加载数据
                Loading();
            }
            else
            {
                this.Close();
            }
        }
        //数据
        List<string> infoList;

        private void Loading()
        {
            //清空容器内的控件
            infoBox.Controls.Clear();
            //行号赋值为1
            int row = 1;
            //获取数据
            //StudentInfo.GetStudentInfo() 获取到单例的对象
            infoList = StudentInfo.GetStudentInfo().infoList;
            //遍历数据
            for (int i = 0; i < infoList.Count; i++)
            {
                //把一个学生的数据拆分为数组
                string[] student = infoList[i].Split(';');


                //学号
                Label studentID = new Label();
                studentID.Location = new Point(idlabel.Location.X - infoBox.Location.X, row * 40);
                studentID.AutoSize = true;
                //student[0] => StudentId:2024004
                studentID.Text = student[0].Split(':')[1];
                //new Font(字体名称,字体大小)
                studentID.Font = new Font("Size", 20);
                studentID.Tag = row + "";
                infoBox.Controls.Add(studentID);

                //姓名
                Label studentName = new Label();
                studentName.Location = new Point(namelabel.Location.X - infoBox.Location.X, row * 40);
                studentName.AutoSize = true;
                studentName.Text = student[1].Split(':')[1];
                studentName.Font = new Font("Size", 20);
                studentName.Tag = row + "";
                infoBox.Controls.Add(studentName);

                Label studentAge = new Label();
                studentAge.Location = new Point(agelabel.Location.X - infoBox.Location.X, row * 40);
                studentAge.AutoSize = true;
                studentAge.Text = student[2].Split(':')[1];
                studentAge.Font = new Font("Size", 20);
                studentAge.Tag = row + "";
                infoBox.Controls.Add(studentAge);

                Label studentGender = new Label();
                studentGender.Location = new Point(genderlabel.Location.X - infoBox.Location.X, row * 40);
                studentGender.AutoSize = true;
                studentGender.Text = student[3].Split(':')[1];
                studentGender.Font = new Font("Size", 20);
                studentGender.Tag = row + "";
                infoBox.Controls.Add(studentGender);

                Label studentClass = new Label();
                studentClass.Location = new Point(classlabel.Location.X - infoBox.Location.X, row * 40);
                studentClass.AutoSize = true;
                studentClass.Text = student[4].Split(':')[1];
                studentClass.Font = new Font("Size", 20);
                studentClass.Tag = row + "";
                infoBox.Controls.Add(studentClass);

                Label studentDis = new Label();
                studentDis.Location = new Point(dislabel.Location.X - infoBox.Location.X, row * 40);
                studentDis.AutoSize = true;
                studentDis.Text = student[5].Split(':')[1];
                studentDis.Font = new Font("Size", 20);
                studentDis.Tag = row + "";
                infoBox.Controls.Add(studentDis);

                Label studentphone = new Label();
                studentphone.Location = new Point(phonelabel.Location.X - infoBox.Location.X, row * 40);
                studentphone.AutoSize = true;
                studentphone.Text = student[6].Split(':')[1];
                studentphone.Font = new Font("Size", 20);
                studentphone.Tag = row + "";
                infoBox.Controls.Add(studentphone);

                //删除按钮
                Button delBtn = new Button();
                delBtn.Location = new Point(studentphone.Location.X + 250, studentphone.Location.Y);
                delBtn.AutoSize = true;
                delBtn.Text = "删除信息";
                delBtn.Font = new Font("Size", 20);
                delBtn.Tag = row + "";
                delBtn.Click += delBtn_click;
                infoBox.Controls.Add(delBtn);

                //修改按钮
                Button updateBtn = new Button();
                updateBtn.Location = new Point(delBtn.Location.X + 150, delBtn.Location.Y);
                updateBtn.AutoSize = true;
                updateBtn.Text = "修改信息";
                updateBtn.Font = new Font("Size", 20);
                updateBtn.Tag = row + "";
                updateBtn.Click += update_click;
                infoBox.Controls.Add(updateBtn);


                //每次循环结束后
                row++;
            }
        }

        //删除按钮点击时 根据tag删除
        private void delBtn_click(object sender, EventArgs e)
        {
            //拿到删除按钮上的行号
            Button delBtn = sender as Button;
            //行号 delBtn.Tag
            int index = int.Parse(delBtn.Tag.ToString());
            //index -1 获取到infoList的对应的索引
            infoList.RemoveAt(index - 1);
            //覆盖写入文本文件
            File.WriteAllLines(@"./studentInfo.txt", infoList);
            //重新加载容器
            Loading();
        }

        //修改按钮的点击事件
        private void update_click(object sender, EventArgs e)
        {
            Button updateBtn = sender as Button;

            UpdateInfo updateInfo = new UpdateInfo(updateBtn.Tag.ToString());
            updateInfo.ShowDialog();

            Loading();
        }

        //点击添加学生按钮
        private void button1_Click(object sender, EventArgs e)
        {
            AddStudent addStudent = new AddStudent();
            addStudent.ShowDialog();
            //重新加载数据
            Loading();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            QueryInfo queryInfo = new QueryInfo();
            queryInfo.ShowDialog();
        }
    }
}
