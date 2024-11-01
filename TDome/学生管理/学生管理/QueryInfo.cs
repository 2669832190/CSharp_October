using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 学生管理.Mode;

namespace 学生管理
{
    enum queryOption
    {
        学号 = 0,
        姓名,
        年龄,
        性别,
        班级,
        住址,
        联系方式
    }

    public partial class QueryInfo : Form
    {
        public QueryInfo()
        {
            InitializeComponent();
        }

        List<string> infoList = StudentInfo.GetStudentInfo().infoList;

        private void button1_Click(object sender, EventArgs e)
        {
            resultBox.Controls.Clear();
            //行号
            int row = 1;

            for (int i = 0; i < infoList.Count; i++)
            {
                string[] student = infoList[i].Split(';');
                //字符串转枚举
                queryOption option = (queryOption)Enum.Parse(typeof(queryOption), comboBox1.SelectedItem.ToString());
                //枚举转int
                int index = (int)option;
                //找到这个学生对应的值
                string correspondingValue = student[index].Split(':')[1];
                //学生的对应信息中是否包含要查询的信息
                if (correspondingValue.Contains(conditionTextBox.Text))
                {
                    Label l = new Label();
                    l.Location = new Point(0,row * 30);
                    l.Text = infoList[i];
                    l.AutoSize = true;
                    resultBox.Controls.Add(l);

                    row++;
                }
            }
        }
    }
}
