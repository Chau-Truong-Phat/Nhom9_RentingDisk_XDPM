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
    public partial class TitleForm : Form
    {
        public TitleForm()
        {
            InitializeComponent();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_DatHang_Click_1(object sender, EventArgs e)
        {
            TitleForm_AddTitle ttaddForm = new TitleForm_AddTitle();
            ttaddForm.Show();
        }

        private void btn_DatLaiGiaThue_Click(object sender, EventArgs e)
        {
            TitleForm_UpdatePrice titleForm_UpdatePrice = new TitleForm_UpdatePrice();
            titleForm_UpdatePrice.Show();
        }
    }
}
