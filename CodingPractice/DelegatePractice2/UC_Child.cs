using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DelegatePractice2
{
    public partial class UC_Child : UserControl
    {
        /*程式解說(UserControl)
        * http://www.blueshop.com.tw/board/FUM20050124191756KKC/BRD20081028111445KAM.html
        * 1.宣告委派(Delegate)
        * 2.宣告事件(Event)
        * 3.在UserControl的Click事件裡面，寫入要引發的事件                           
        */

        public delegate void MyDel(object sender, EventArgs e);
        public event MyDel UC_Click;

        public UC_Child()
        {            
            InitializeComponent();            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UC_Click(sender, e);
        }

    }
}
