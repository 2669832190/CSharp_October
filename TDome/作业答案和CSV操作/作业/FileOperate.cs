using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 作业
{
    internal class FileOperate
    {
        string path = Directory.GetCurrentDirectory() + "\\Data\\data.csv";

        /// <summary>
        /// 往csv文件里写入数据
        /// </summary>
        /// <param name="data">数据</param>
        public void WriteCSV(string data)
        {
            //文件是否存在 不存在的话 创建文件 同时生成表头
            if(!File.Exists(path))
            {
                //文件流和字符流写入
                FileStream fs = new FileStream(path,FileMode.Create,FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs,Encoding.Default);

                //可变长字符串
                StringBuilder sb = new StringBuilder();
                //表头
                sb.Append("日期").Append(",").Append("检测出的缺陷数量");
                //使用字符流写入字符串
                sw.WriteLine(sb);

                sw.Close();
                fs.Close();
                sw.Dispose();
                fs.Dispose();

                /*
                //语法糖格式
                using(FileStream fs1 = new FileStream(path, FileMode.Create, FileAccess.Write))
                {
                    using(StreamWriter sw1 = new StreamWriter(fs, Encoding.Default))
                    {
                        //可变长字符串
                        StringBuilder sb1 = new StringBuilder();
                        //表头
                        sb1.Append("日期").Append(",").Append("检测出的缺陷数量");
                        //使用字符流写入字符串
                        sw1.Write(sb1);
                    }
                }
                */
            }

            using(StreamWriter sw = new StreamWriter(path, true, Encoding.Default))
            {
                string str = DateTime.Now.ToString() + "," + data;
                sw.WriteLine(str);
            }
        }

        /// <summary>
        /// 读取CSV文件内容
        /// </summary>
        public StringBuilder ReadCSV()
        {
            using (StreamReader sr = new StreamReader(path, Encoding.Default))
            {
                StringBuilder sb = new StringBuilder();

                string str;
                while ((str = sr.ReadLine()) != null)
                {
                    sb.Append(str +"\n");
                }

                return sb;
            }
        }
    }
}
