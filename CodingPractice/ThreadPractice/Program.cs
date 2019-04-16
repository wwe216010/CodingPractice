using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadPractice
{
    class Program
    {
        private int count = 0;
        Thread A;
        Thread B;

        static void Main(string[] args)
        {
            Program pro = new Program();
            pro.start();
            Console.ReadLine();
        }

        private void start()
        {
            A = new Thread(new ThreadStart(ThreadAJob));
            B = new Thread(new ThreadStart(ThreadBJob));
            A.Name = "執行緒A_"; 
            B.Name = "執行緒B_";
            A.Start();           
            B.Start();

            Thread.Sleep(3000);//主執行緒會執行休眠3秒
            Console.WriteLine("主執行緒主執行緒主執行緒主執行緒主執行緒主執行緒主執行緒");
        }

        private void ThreadAJob()
        {
            for (int i = 1; i <= 1000; i++)
            {
                lock (this)
                {
                    count += 1;
                    Console.WriteLine(Thread.CurrentThread.Name + "Run Number：" + count.ToString() + "。" + Thread.CurrentThread.ThreadState);
                    //Thread.Sleep(1000);//ThreadA休眠1秒

                    //if (count == 333)
                    //{
                    //    break3second();
                    //}
                }

                //if (count == 500)
                //{
                //    B.Join();//先中止目前的A執行緒，完成B執行緒，Join()不能放在lock裡面
                //}
            }
        }

        private void ThreadBJob()
        {
            for (int i = 1001; i <= 2000; i++)
            {
                lock (this)
                {
                    count += 1;
                    Console.WriteLine(Thread.CurrentThread.Name + "Run Number：" + count.ToString() + "。" + Thread.CurrentThread.ThreadState);
                    //Thread.Sleep(2000);//ThreadB休眠2秒

                    //if (count == 333)
                    //{                        
                    //    break3second();
                    //}
                }

                //if (count == 500)
                //{
                //    A.Join();//先中止目前的B執行緒，完成A執行緒，Join()不能放在lock裡面
                //}
            }
        }

        private void break3second(){
            Thread.Sleep(1000);
            Console.WriteLine("break 1 SECOND break 1 SECOND break 1 SECOND break 1 SECOND break 1 SECOND");
            Console.WriteLine(Thread.CurrentThread.Name + "break 1 SECOND Run Number：" + count.ToString() + "。" + Thread.CurrentThread.ThreadState);
        }
    }
}
