using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DelegatePractice2
{
    public partial class Form_Mother : Form
    {
        public Form_Mother()
        {
            InitializeComponent();

            uC_Child1.UC_Click += new UC_Child.MyDel(uC_Child1_UC_Click);
        }

        private void uC_Child1_UC_Click(object sender, EventArgs e)
        {
            label1.Text = "Mother~~";
        }
    }
}
