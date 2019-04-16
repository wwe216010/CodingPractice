using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverridePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Human h = new Human();
            Westerners w = new Westerners();

            //子類別使用父類別的function時，父類別function內的後續流程，會以子類別的參考繼續執行            
            h.GetData();
            w.GetData();
            Console.ReadLine();
        }
    }

    class Human
    {
        public void GetData() 
        {
            Sex s = GetSex();//如果是Westerners執行GetData()，則會執行Westerners的override GetSex()
            Console.WriteLine(s != null ? s.sex : "Data Null!!");                  
        }

        public virtual Sex GetSex() 
        { 
            return null; 
        }
    }

    class Westerners:Human
    {
        public override Sex GetSex()
        {
            Sex s = new Sex();
            s.sex = "Westerners-Male";
            return s;
        }
    }

    class Sex
    {
        public string sex { get; set; }
    }
}
