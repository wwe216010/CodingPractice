using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethoParamOutRefTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //ref
            //ref參數一定要再使用方法前先初始化參數
            int i = 1;

            //out
            //out參數不用先初始化參數，但一定要在方法內初始化參數
            int ii;

            Console.Write("ref：" + RefTest(ref i).ToString() + "。 out：" + OutTest(out ii).ToString());
            Console.ReadLine();
        }

        private static int RefTest(ref int i)
        {
            return i;
        }

        private static int OutTest(out int i)
        {
            i = 5;
            return i;
        }
    }
}
