using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 大鱼吃小鱼
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //玩家的鲨鱼图片
        PictureBox UserFish;
        //通过一个布尔变量 来确定是否已经开始游戏 如果为true 表示游戏已经开始了
        bool isStartPlay = false;


        //开始游戏的点击事件
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //打开创建鱼的计时器
            timer1.Enabled = true;
            //打开鱼移动的计时器
            timer2.Enabled = true;


            //窗体最大化
            this.WindowState = FormWindowState.Maximized;

            //清除所有的控件
            this.Controls.Clear();
            //生成玩家的鲨鱼
            UserFish = new PictureBox();
            UserFish.Image = Image.FromFile(@"./img/sy.png");
            UserFish.BackColor = Color.Transparent;
            UserFish.SizeMode = PictureBoxSizeMode.StretchImage;
            //图片大小 设置宽高
            UserFish.Width = 100;
            UserFish.Height = 60;
            //把图片控件添加到窗体
            this.Controls.Add(UserFish);

            //标记游戏已经开始了
            isStartPlay = true;

        }

        //当鼠标经过窗体时触发这个事件
        //object sender 触发事件的控件他本身
        //MouseEventArgs e 鼠标的信息
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            //如果游戏已经开始了 才运行这些代码
            //if(判断括号里的内容 如果为true 才运行代码体)
            if (isStartPlay)
            {
                //鲨鱼向左还是向右
                if (e.X > UserFish.Location.X)
                {
                    //向右移动
                    UserFish.Image = Image.FromFile(@"img/sy.png");
                }
                else if (e.X < UserFish.Location.X)
                {
                    UserFish.Image = Image.FromFile(@"img/sy2.png");
                }
                //位置
                UserFish.Location = e.Location;
            }

        }


        Random ran = new Random();
        //鱼的图片路径
        string[] fishPaths =
        {
            @"img/xy1.png",
            @"img/xy2.png",
            @"img/xy3.png",
            @"img/xy4.png",

            @"img/xy12.png",
            @"img/xy22.png",
            @"img/xy32.png",
            @"img/xy42.png",
        };

        //生成小鱼
        private void timer1_Tick(object sender, EventArgs e)
        {
            //生成一条鱼
            PictureBox fish = new PictureBox();
            // 是哪条鱼 ？ 向左的鱼还是向右的鱼 ？
            //随机出来鱼的索引
            int fishIndex = ran.Next(fishPaths.Length);
            //无论向左向右都要进行的设置

            //设置宽高
            fish.Width = ran.Next(10, 300);
            fish.Height = (int)(fish.Width * 0.6);
            //设置鱼的图片
            fish.Image = Image.FromFile(fishPaths[fishIndex]);
            //鱼的背景
            fish.BackColor = Color.Transparent;
            //鱼的大小模式
            fish.SizeMode = PictureBoxSizeMode.StretchImage;

            //小于4 向左游的鱼
            if (fishIndex < 4)
            {
                //修改鱼的坐标 X为窗体宽度 Y为随机数(0-当前窗体的高度)
                fish.Location = new Point(this.Width, ran.Next(this.Height));
                //标记为向左游的鱼
                fish.Tag = "向左的鱼";
            }
            else
            {
                fish.Location = new Point(0 - fish.Width, ran.Next(this.Height));
                fish.Tag = "向右的鱼";
            }

            //绑定事件
            fish.MouseMove += fish_MouseMove;

            //把鱼添加到窗体控件
            this.Controls.Add(fish);
        }

        //鼠标经过小鱼的时候触发的事件
        private void fish_MouseMove(object sender, MouseEventArgs e)
        {
            //小鱼
            PictureBox fish = sender as PictureBox;
            //判断面积 或者 判断某个属性
            if(UserFish.Width * UserFish.Height > fish.Width * fish.Height)
            {
                //删除小鱼
                this.Controls.Remove(fish);
                //鲨鱼长大
                UserFish.Width = (int)(UserFish.Width * 1.2);
                UserFish.Height = (int)(UserFish.Width * 0.6);
            }
            else
            {
                this.Controls.Clear();
                timer1.Enabled = false;
                timer2.Enabled = false;
                MessageBox.Show("游戏结束,你的鲨鱼太小了!");
                this.Close();
            }
        }

        //移动速度
        int speed = 30;
        //用于让鱼移动的计时器
        private void timer2_Tick(object sender, EventArgs e)
        {
            //遍历所有的控件
            for (int i = 0; i < this.Controls.Count; i++)
            {
                //如果这个控件没有标签 说明不是鱼
                if (this.Controls[i].Tag == null)
                {
                    continue;
                }


                //如果第i个控件的标签是向左的鱼
                if (this.Controls[i].Tag == "向左的鱼")
                {
                    this.Controls[i].Location = new Point(this.Controls[i].Location.X - speed, this.Controls[i].Location.Y);
                }
                if (this.Controls[i].Tag == "向右的鱼")
                {
                    this.Controls[i].Location = new Point(this.Controls[i].Location.X + speed, this.Controls[i].Location.Y);
                }

                //如果鱼的标签里有"的鱼"这两个字
                if (this.Controls[i].Tag.ToString().Contains("的鱼"))
                {
                    //超出屏幕
                    if ((this.Controls[i].Location.X > this.Width + this.Controls[i].Width) ||
                        (this.Controls[i].Location.X < 0 - this.Controls[i].Width))
                    {
                        //删除这条鱼
                        this.Controls.Remove(this.Controls[i]);
                        //防止漏掉下一条鱼
                        i--;
                    }
                }
            }
        }
    }
}
