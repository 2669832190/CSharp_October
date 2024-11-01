using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using 学生管理.Mode;

namespace 学生管理
{
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
        }

        //加到单例的信息里
        List<string> infoList = StudentInfo.GetStudentInfo().infoList;

        private void button1_Click(object sender, EventArgs e)
        {
            //学号不能重复
            for (int i = 0; i < infoList.Count; i++)
            {
                //学号重复了
                if (infoList[i].Split(';')[0].Split(':')[1] == idtextBox.Text)
                {
                    MessageBox.Show("学号已经重复了，请重新输入");
                    return;
                }
            }
            //手机号验证
            //正则表达式 Regex.IsMatch(要验证的字符串,规则)
            if (!Regex.IsMatch(phonetextBox.Text, @"^1[3-9][0-9]{9}$"))
            {
                MessageBox.Show("手机号格式不正确");
                return;
            }

            //把信息拼接为字符串
            string s = $"StudentId:{idtextBox.Text};Name:{nametextBox.Text};" +
                $"Age:{agetextBox.Text};Sex:{gendercomboBox.SelectedItem};" +
                $"Class:{classtextBox.Text};Address:{distextBox.Text};" +
                $"Phone:{phonetextBox.Text}";
            //追加到文本
            File.AppendAllText(@"./studentInfo.txt", "\n" + s);
            infoList.Add(s);
            //关闭窗体
            this.Close();
        }
    }
}
