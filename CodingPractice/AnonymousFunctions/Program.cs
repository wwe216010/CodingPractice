using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sample : Area\ShortMileageStaticFeeSetting
            Work();
        }

        static private bool Work()
        {
            //bool va = DoCreateOrUpdate((a, b) => a*b);//無指定委派方法，直接相乘
            bool va = DoCreateOrUpdate((a, b) => DoSave(a, b));//透過指定委派方法做相乘
            return va;
        }

        static private int DoSave(int a, int b)
        {
            return a * b;
        }

        //like DoCreateOrUpdate
        static private bool DoCreateOrUpdate(Func<int, int, int> doSomething)
        {
            //指定參數給匿名委派方法Func
            int a = 3;
            int b = 2;
            return SerializeToJson(doSomething(a, b));//執行實際方法DoSave
        }

        static private bool SerializeToJson(int p)
        {
            bool res = false;
            int i;
            if (int.TryParse(p.ToString(), out i))
            {
                res = true;
            }
            return res;
        }
    }
}
