﻿using System;
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
            lb_Customer.BackColor = Color.FromArgb(26, 32, 40);
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
    }
}
