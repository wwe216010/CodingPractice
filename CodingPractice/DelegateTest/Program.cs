using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateTest
{
    class Program
    {
        public delegate void Del(object state);

        static void Main(string[] args)
        {
            Data d1 = new Data { Name = "Hao", Age = 30 };


            Program P = new Program();
            Del d = P.test;
            d(d1);
        }

        public void test(object o)
        {
            var qq = o as Data;//向下轉型，qq才能使用Data的成員。Data:qq
            Console.WriteLine(qq.Name + qq.Age);
            Console.ReadLine();
        }
    }

    public class Data
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
