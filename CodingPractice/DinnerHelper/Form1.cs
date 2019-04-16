using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace DinnerHelper
{
    public partial class Form1 : Form
    {
        List<Dinner> d = new List<Dinner>();
        public Form1()
        {
            InitializeComponent();

            string[] AryDinner = System.Configuration.ConfigurationManager.AppSettings["DinnerList"].Split(',');
            foreach (var item in AryDinner)
            {
                d.Add(new Dinner { Restaurant = item });
            }

            dataGridView1.DataSource = d;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int qq = d.Count();
            label1.Text = d[rnd.Next(0, d.Count())].Restaurant;
        }
    }

    class Dinner
    {
        public string Restaurant { get; set; }
    }
}
