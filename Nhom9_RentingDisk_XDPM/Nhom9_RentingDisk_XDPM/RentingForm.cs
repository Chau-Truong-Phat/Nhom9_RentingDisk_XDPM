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
    public partial class RentingForm : Form
    {
        public RentingForm()
        {
            InitializeComponent();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {

        }

        private void txt_numberPhone_Click(object sender, EventArgs e)
        {
            pnl_numberPhone.BackColor = Color.FromArgb(20, 173, 196);
        }

        private void txt_nameCustomer_Click(object sender, EventArgs e)
        {
            pnl_nameCustomer.BackColor = Color.FromArgb(20, 173, 196);

        }

        private void txt_searchItem_Click(object sender, EventArgs e)
        {
            pnl_searchItem.BackColor = Color.FromArgb(20, 173, 196);

        }

    }
}
