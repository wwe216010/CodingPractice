using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadPractice2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int MainIdex = 1;  MainIdex <= 5;  MainIdex++)
            {
                Thread T1 = new Thread(ThreadMain);
                T1.Name = MainIdex.ToString();
                T1.Start();

                Thread.Sleep(1000);
            }

            Console.ReadLine();
        }

        private static void ThreadMain()
        {
            Console.WriteLine(string.Format("{0} Running Main Process!", "MainThread" + Thread.CurrentThread.Name));

            Thread T2 = new Thread(ThreadDetail);
            T2.Start();
        }

        private static void ThreadDetail()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(string.Format("{0} Running Detail Process!", "DetailThread" + i));
            }
        }
    }
}
