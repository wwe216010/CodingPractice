using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAction
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<String> names = new List<String>();
            //names.Add("Bruce");
            //names.Add("Alfred");
            //names.Add("Tim");
            //names.Add("Richard");

            //names.ForEach(n => Print(n));//Action<T>只接受一個T參數，如果Print()有兩個參數則會出錯
            ////names.ForEach(Print);
            //Console.Read();

            Linq10();
        }
        private static void Print(string s)
        {
            Console.WriteLine(s);
        }

        private static void Linq10(){
                int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 }; 
    string[] strings = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" }; 
  
    var digitOddEvens = 
        from n in numbers 
        select new { Digit = strings[n], Even = (n % 2 == 0) }; 
  
    foreach (var d in digitOddEvens) 
    { 
        Console.WriteLine("The digit {0} is {1}.", d.Digit, d.Even ? "even" : "odd"); 
    } 
        }
    }
}
