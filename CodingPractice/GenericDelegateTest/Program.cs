using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDelegateTest
{
    class Program
    {
        //委派方法簽章(有回傳值)
        public delegate TResult DelAdd<T, TResult>(T t1, T t2);
                
        static void Main(string[] args)
        {
            //寫法1. 一般泛型委派寫法，先建立委派簽章，再宣告委派
            DelAdd<int, int> ExcuteDelAdd = new DelAdd<int, int>(AddMethod);
            Console.WriteLine(ExcuteDelAdd.Invoke(3, 3).ToString());
            Console.ReadLine();

            //寫法2. 值接封裝成Func，不用建立委派簽章，也不用宣告委派
            Func<int, int, int> ExcuteDelAdd2 = AddMethod;
            Console.WriteLine(ExcuteDelAdd2.Invoke(3, 3).ToString());
            Console.ReadLine();
        }

        //static private T Calculator<T>(T t1, T t2){
        //    return t1 * t2;//Calculator()不知道T是什麼型別，所以不能回傳運算結果
        //}

        static public int AddMethod(int i1, int i2)
        {
            return i1 * i2;
        }

    }
}
