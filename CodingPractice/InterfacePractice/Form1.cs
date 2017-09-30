using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfacePractice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Alien allen = new Alien();            
            allen.fly();
        }
    }

    class Alien
    {
        ICanFly swan = new Swan();
        ICanFly duck = new Duck();
        public void fly()
        {
            swan.Name = "Alien!!!!!";
            swan.fly();

            duck.fly();
        }
    }

    class Duck : ICanFly
    {
        private string _Name = "John";
        public string Name { get { return _Name; } set { _Name = value; } }

        public void fly()
        {
            MessageBox.Show("Duck's fly method" + "-Duck Name：" + _Name);
        }
    }

    class Swan : ICanFly
    {
        private string _Name = "Kevin";
        public string Name { get { return _Name; } set { _Name = value; } }

        public void fly()
        {
            MessageBox.Show("Swan's fly method" + "-Swan Name：" + _Name);
        }
    }

    public interface ICanFly
    {
        string Name { get; set; }

        void fly();             
    }
}
