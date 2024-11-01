using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02窗口传值
{
    public partial class Form2 : Form
    {
        int money = 0;

        public Form2(int a)
        {
            money = a;
            InitializeComponent();
        }

        //窗体加载时的事件
        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = money + "";
        }
    }
}
