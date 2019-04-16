using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractPractice
{
    /**
     * 1.基礎抽象類別裡面的方法成員可以直接撰寫內容屬性成員也可以先給值，
     * 繼承基礎抽象類別的子類別也可以直接使用基礎類別的方法及屬性。
     * 但如果基礎類別裡面有抽象成員，則子類別一定要實作
     * 
     * 2.子類別實作基礎類別的方法時，要使用override複寫的方式，不像介面直接
     * 實作一個簽名一樣的方法成員即可
     * 
     * 3.一個子類別只能繼承一個抽象類別，與介面的最大不同是，介面可以一次
     * 繼承多個
     * 
     * 4.抽象類別不能產生實例
     **/
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Duck duck = new Duck();
            //MessageBox.Show(duck.Name + duck.Eat() + duck.Fly());
            Duck2 d = new Duck2();
            if (d is Duck)
	        {
                d.Fly();
	        }
        }
    }

     abstract class Birds
    {
        //abstract public string Fly();

        public string Name = "I am a Bird,";

        public string Eat(){
            return "I can eat bug";
        }
    }

    abstract class Duck:Birds
    {
        public abstract string Fly();
    }

    class Duck2 : Duck
    {
        public override string Fly()
        {
            return "I can fly more high";
        }
    }
}
