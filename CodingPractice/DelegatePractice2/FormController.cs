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
    public partial class FormController : Form
    {
        /*程式執行流程(Sample:Form_Father)
         * 點選Father按鈕，跳出Father視窗
         * 1.Form_Father.Form_Father_Load(object sender, EventArgs e)//事件綁定委派方法
         * 點選Father視窗的Button1按鈕
         * 2.UC_Child.Button1_Click(object sender, EventArgs e)//執行事件(委派方法)
         * 3.Form_Father.uC_Child1_UC_Click(object sender, EventArgs e)
         */

        public FormController()
        {
            InitializeComponent();
        }

        private void btnMother_Click(object sender, EventArgs e)
        {
            Form_Mother M = new Form_Mother();
            M.ShowDialog();
        }

        private void btnFather_Click(object sender, EventArgs e)
        {
            Form_Father F = new Form_Father();
            F.ShowDialog();
        }
    }
}
