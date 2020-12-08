using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom9_RentingDisk_XDPM
{
    public partial class ReturnDVDForm : Form
    {
        public ReturnDVDForm()
        {
            InitializeComponent();
        }

        private void txt_numberPhone_Click(object sender, EventArgs e)
        {
            pnl_numberPhone.BackColor = Color.FromArgb(20, 173, 196);
        }

        private void txt_nameCustomer_Click(object sender, EventArgs e)
        {
            pnl_nameCustomer.BackColor = Color.FromArgb(20, 173, 196);
        }

        private void txt_searchDiskReturn_Click(object sender, EventArgs e)
        {
            pnl_searchItemReturn.BackColor = Color.FromArgb(20, 173, 196);
        }
    }
}
