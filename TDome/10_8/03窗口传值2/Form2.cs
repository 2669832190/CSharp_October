using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03窗口传值2
{
    public partial class Form2 : Form
    {
        Form1 form1;

        public Form2(Form1 form1)
        {
            this.form1 = form1;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            MessageBox.Show(form1.age + "");
            MessageBox.Show(form1.name);
            MessageBox.Show(form1.id + "");
            MessageBox.Show(form1.gender);
        }
    }
}
