using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodBankSystem
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ProfileImg_Click(object sender, EventArgs e)
        {
            if (prfPnl.Visible)
            {
                prfPnl.Visible = false;
            }
            else
            {
                prfPnl.Visible = true;
            }
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }
    }
}
