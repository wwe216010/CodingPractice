using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace DelegateTest
{
    class Program
    {
        public delegate void Del(object state);

        static void Main(string[] args)
        {

            Data data = new Data { Name = "Hao", Age = 30 };


            //Program P = new Program();
            //Del d = P.test;
            //d(data);
            //或下面寫法
            Del d = new Del(test);
            d(data);
        }

        private static void test(object o)
        {
            if (o is Data)//檢查o是否為Data類別向上轉型
            {
                var qq = o as Data;//向下轉型，qq才能使用Data的成員。Data繼承qq
                Console.WriteLine(qq.Name + qq.Age);
                Console.ReadLine();   
            }
        }
    }

    public class Data
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
