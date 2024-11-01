using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04窗体传值修改
{
    public partial class UpdateInfo : Form
    {
        //账号:123456;密码:abcdefg
        string info;

        public UpdateInfo(string str)
        {
            info = str;
            InitializeComponent();
        }

        private void UpdateInfo_Load(object sender, EventArgs e)
        {
            string[] splitInfo = info.Split(';');
            //前一半 账号:123456
            string firstHalf = splitInfo[0];
            //后一半 密码:abcdefg
            string lastHalf = splitInfo[1];

            string[] firstHalfs = firstHalf.Split(':');
            nameInfo.Text = firstHalfs[1];

            string[] lastHalfs = lastHalf.Split(':');
            pwdInfo.Text = lastHalfs[1];
        }


        public string pwd;
        private void button1_Click(object sender, EventArgs e)
        {
            //拿到密码
            pwd = pwdInfo.Text;
        }
    }
}
