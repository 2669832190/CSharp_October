using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01复习文件读写
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //写
            File.AppendAllText(@"./new.txt","\n姓名:赵六;性别:未知;年龄:30");
        }

        void Read()
        {
            //读
            string[] strs = File.ReadAllLines(@"./new.txt");

            foreach (string str in strs)
            {
                //姓名:张三;性别:男;年龄:20
                string[] splitStr = str.Split(';');
                //splitStr[0] 姓名:张三
                //splitStr[1] 性别:男
                //splitStr[2] 年龄:20


                string[] splitStrName = splitStr[0].Split(':');
                //splitStrName[0] 姓名
                //splitStrName[1] 张三

                string[] splitStrGender = splitStr[1].Split(':');
                //splitStrGender[0] 性别
                //splitStrGender[1] 男
                Console.WriteLine(splitStrGender[1]);
            }
        }
    }
}
