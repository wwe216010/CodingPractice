using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatePractice
{
    public class Program
    {
        static void Main(string[] args)
        {
            ClassA A = new ClassA();
            ClassB B = new ClassB();
        }
    }

    public class ClassA
    {
        //public ClassA()
        //{
        //    ClassB B = new ClassB();
        //    B.MethodB();
        //}

        //public void MethodA()
        //{
        //    Console.WriteLine("A被呼叫了~~");
        //    Console.ReadLine();
        //}


        public ClassA()
        {
            ClassB.MyDelegate Del = new ClassB.MyDelegate(MethodA);
            Del("Hello World~~");
        }

        public void MethodA(string i)
        {
            Console.WriteLine(i);
            Console.ReadLine();
        }
    }

    public class ClassB
    {
        //public ClassB()
        //{
        //    ClassA A = new ClassA();
        //    A.MethodA();
        //}

        //public void MethodB()
        //{
        //    Console.WriteLine("B被呼叫了~~");
        //    Console.ReadLine();
        //}


        public delegate void MyDelegate(string Para1);
        public MyDelegate Del;

        public ClassB()
        {
            Del = new MyDelegate(MethodB);
            Del("World Hello~~");
        }

        public void MethodB(string i)
        {
            Console.WriteLine(i);
            Console.ReadLine();
        }
    }
}
