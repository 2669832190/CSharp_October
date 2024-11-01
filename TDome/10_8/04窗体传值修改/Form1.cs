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

namespace _04窗体传值修改
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
            List<string> infoList = File.ReadAllLines(@"./info.txt").ToList();
        private void Form1_Load(object sender, EventArgs e)
        {

            foreach (string info in infoList)
            {
                listBox1.Items.Add(info);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //先获取到选中的哪一行数据
            string info = listBox1.SelectedItem.ToString();

            UpdateInfo updateInfo = new UpdateInfo(info);
            updateInfo.ShowDialog();

            //新窗体中的pwd属性
            //通过updateInfo.pwd 获取到updateInfo窗体的pwd属性
            //接下来 找到infoList中对应的账号 修改密码
            //再保存回文本文件
        }
    }
}
