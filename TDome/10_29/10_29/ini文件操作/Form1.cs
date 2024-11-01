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

namespace ini文件操作
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string path = Directory.GetCurrentDirectory() + "\\ini\\init.ini";

        private void Form1_Load(object sender, EventArgs e)
        {
            //写入键值对
            //Ini.IniAPI.INIWriteItems(path,"相机1","曝光=200\0增益=10");

            //Ini.IniAPI.INIWriteValue(path, "相机1", "曝光", "150");

            int a = Ini.IniAPI.GetPrivateProfileInt("相机1", "曝光2", 100, path);
            MessageBox.Show(a + "");
        }
    }
}
