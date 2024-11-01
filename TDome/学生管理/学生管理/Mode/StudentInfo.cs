using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 学生管理.Mode
{
    //单例模式
    //这个类只能有一个对象
    internal class StudentInfo
    {
        public List<string> infoList = File.ReadAllLines(@"./studentInfo.txt").ToList();

        //2.创建一个唯一的对象
        private static StudentInfo studentInfo;

        //4.加锁 解决线程安全问题
        private readonly static object _lock = new object();

        //1.私有构造函数 不让new
        private StudentInfo() { }

        //3.有一个获取对象的公开方法
        public static StudentInfo GetStudentInfo()
        {
            //5.保证线程安全
            if (studentInfo == null)
            {
                lock (_lock)
                {
                    if (studentInfo == null)
                    {
                        studentInfo = new StudentInfo();
                    }
                }
            }
            return studentInfo;
        }
    }
}
