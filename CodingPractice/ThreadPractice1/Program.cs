using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadPractice1
{
    class Program
    {
        static ManualResetEvent MR = new ManualResetEvent(true);
        static AutoResetEvent AR = new AutoResetEvent(true);
        static List<Thread> lst = new List<Thread>();  
     
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                Thread t = new Thread(ThreadJob);
                t.Start();
                t.Name = i.ToString();
                lst.Add(t);
                Thread.Sleep(1000);
            }

            foreach (var item in lst)
            {
                Console.WriteLine(string.Format("ThreadID=[{0}], ThreadName=[{1}], ThreadStatus=[{2}]", item.ManagedThreadId, item.Name, item.ThreadState));
            }

            /*****AutoResetEvent*****/
            //AR.Set();
            //AR.Set();
            /*
            1.AutoResetEvent一次只能喚醒一個執行緒，要一個一個喚醒
            2.先RUN的執行緒會先被喚醒
            3.AutoResetEvent預設如果為false(non-signaled)，執行緒遇到.WaitOne()狀態會變成WaitSleepJoin，要等到執行緒遇到.Set()才會繼續執行。
              AutoResetEvent預設如果為true(signaled)，第一個執行緒遇到.WaitOne()會繼續往下執行，執行緒狀態完成作業變成Stopped。                                       
            */
            /*****AutoResetEvent*****/

            /*****ManualResetEvent*****/
            MR.Set();
            MR.Reset();
            /*****ManualResetEvent*****/

            Console.ReadLine();
        }

        private static void ThreadJob() {
            Console.WriteLine(string.Format("ThreadID=[{0}], ThreadName=[{1}]", Thread.CurrentThread.ManagedThreadId, Thread.CurrentThread.Name));
                        
            /*****AutoResetEvent*****/
            //AR.WaitOne();
            /*****AutoResetEvent*****/
            
            /*****ManualResetEvent*****/
            MR.WaitOne();           
            /*****ManualResetEvent*****/          
            Console.WriteLine(string.Format("ThreadID=[{0}], ThreadName=[{1}]   STOP RUNNING BEFORE SET()", Thread.CurrentThread.ManagedThreadId, Thread.CurrentThread.Name));                        
        }
    }
}
