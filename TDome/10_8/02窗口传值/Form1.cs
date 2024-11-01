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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int money = 200;

        private void button1_Click(object sender, EventArgs e)
        {
            //new Form2() 无参构造函数
            Form2 form2 = new Form2(money);
            form2.ShowDialog();
        }
    }
}
