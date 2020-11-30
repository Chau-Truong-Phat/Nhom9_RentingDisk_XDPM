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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

        }

        private void lb_Title_Click(object sender, EventArgs e)
        {
            Application.OpenForms.Cast<Form>().Where(x => !(x is MainForm))
           .ToList().ForEach(x => x.Close());
            TitleForm titleForm = new TitleForm();
            titleForm.TopLevel = false;
            titleForm.Parent = pnl_FormConnect;
            titleForm.Show();
        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lb_CD.BackColor = Color.FromArgb(26, 32, 40);
            btn_KhachHang.BackColor = Color.FromArgb(26, 32, 40);
            lb_Report.BackColor = Color.FromArgb(26, 32, 40);
            lb_Title.BackColor = Color.FromArgb(26, 32, 40);
            //TitleLogo.BackColor = 
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lb_Customer_Click(object sender, EventArgs e)
        {
            Application.OpenForms.Cast<Form>().Where(x => !(x is MainForm))
              .ToList().ForEach(x => x.Close());
            CustomerForm CF = new CustomerForm();
            CF.TopLevel = false;
            CF.Parent = pnl_FormConnect;
            CF.Show();
        }

        private void btn_Menu_Click(object sender, EventArgs e)
        {
            if (pnl_MenuOption.Width == 200)
            {
                pnl_MenuOption.Width = 50;
            }
            else
            {
                pnl_MenuOption.Width = 200;
            }
        }

        private void lb_CD_Click(object sender, EventArgs e)
        {
            if (pnl_CD_DVD.Visible == true)
            {
                pnl_CD_DVD.Visible = false;

            }
            else
            {
                pnl_CD_DVD.Visible = true;
            }
        }

        private void btn_ThueDVD_Click(object sender, EventArgs e)
        {
            Application.OpenForms.Cast<Form>().Where(x => !(x is MainForm))
              .ToList().ForEach(x => x.Close());
            RentingForm rentForm = new RentingForm();
            rentForm.TopLevel = false;
            rentForm.Parent = pnl_FormConnect;
            rentForm.Show();
        }

        private void btn_TraDVD_Click(object sender, EventArgs e)
        {
            Application.OpenForms.Cast<Form>().Where(x => !(x is MainForm))
              .ToList().ForEach(x => x.Close());
            ReturnDVDForm returnDVDForm = new ReturnDVDForm();
            returnDVDForm.TopLevel = false;
            returnDVDForm.Parent = pnl_FormConnect;
            returnDVDForm.Show();
        }

        private void btn_DatVD_Click(object sender, EventArgs e)
        {
            Application.OpenForms.Cast<Form>().Where(x => !(x is MainForm))
              .ToList().ForEach(x => x.Close());
            ReservationForm reservationForm = new ReservationForm();
            reservationForm.TopLevel = false;
            reservationForm.Parent = pnl_FormConnect;
            reservationForm.Show();
        }
    }
}
