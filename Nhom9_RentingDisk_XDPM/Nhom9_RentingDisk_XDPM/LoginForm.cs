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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.DialogResult = DialogResult.No;
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (txt_userName.Text == "admin" && txt_password.Text == "admin")
            {
                this.DialogResult = DialogResult.Yes;
                this.Close();
            }
            else
            {
                MessageBox.Show("Tài khoản mật khẩu không chính xác");
                this.DialogResult = DialogResult.No;
            }
        }

        private void pbo_closeForm_Click(object sender, EventArgs e)
        {

        }
    }
}