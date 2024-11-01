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
    public partial class UpdateInfo : Form
    {
        string tag;
        public UpdateInfo(string tag)
        {
            this.tag = tag;
            InitializeComponent();
        }

        List<string> infoList = StudentInfo.GetStudentInfo().infoList;

        private void UpdateInfo_Load(object sender, EventArgs e)
        {
            int index = int.Parse(tag) - 1;

            string[] student = infoList[index].Split(';');

            idtextBox.Text = student[0].Split(':')[1];
            nametextBox.Text = student[1].Split(':')[1];
            agetextBox.Text = student[2].Split(':')[1];
            gendercomboBox.SelectedItem = student[3].Split(':')[1];
            classtextBox.Text = student[4].Split(':')[1];
            distextBox.Text = student[5].Split(':')[1];
            phonetextBox.Text = student[6].Split(':')[1];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index = int.Parse(tag) - 1;
            //infoList[index] 需要修改的那一行信息
            infoList[index] = $"StudentId:{idtextBox.Text};Name:{nametextBox.Text};" +
                $"Age:{agetextBox.Text};Sex:{gendercomboBox.SelectedItem};" +
                $"Class:{classtextBox.Text};Address:{distextBox.Text};" +
                $"Phone:{phonetextBox.Text}";
            //覆盖写入文本
            File.WriteAllLines(@"./studentInfo.txt", infoList);

            this.Close();
        }
    }
}
