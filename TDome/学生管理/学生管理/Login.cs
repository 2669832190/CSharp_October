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

namespace 学生管理
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        List<string> list = File.ReadAllLines(@"./user.txt").ToList();
        //标记是否登录成功 如果成功 值为true
        public bool flag;
        private void button1_Click(object sender, EventArgs e)
        {
            //遍历所有的账号密码
            foreach (string s in list)
            {
                //账号:admin;密码:admin
                string[] nameAndPwd = s.Split(';');
                //账号的admin
                //nameAndPwd[0].Split(':')[1];
                //密码的admin
                //nameAndPwd[1].Split(':')[1];
                if(name.Text == nameAndPwd[0].Split(':')[1] && pwd.Text == nameAndPwd[1].Split(':')[1])
                {
                    MessageBox.Show("登录成功");
                    flag = true;
                    this.Close();
                    return;
                }
            }

            MessageBox.Show("登录失败！没有此账号密码");
        }
    }
}
