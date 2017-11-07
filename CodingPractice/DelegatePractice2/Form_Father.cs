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
    public partial class Form_Father : Form
    {
        /*程式解說(Form_Father(Mother))
        * 新增一個事件委派函式(uC_Child1_UC_Click)
        * 事件(UC_Click)掛載事件委派函式(uC_Chile1_UC_Click)       
        */

        public Form_Father()
        {
            InitializeComponent();
        }

        private void Form_Father_Load(object sender, EventArgs e)
        {
            uC_Child1.UC_Click += new UC_Child.MyDel(uC_Child1_UC_Click);
        }

        private void uC_Child1_UC_Click(object sender, EventArgs e)
        {
            label1.Text = "Father~~";
        }
    }
}
