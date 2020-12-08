using Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom9_RentingDisk_XDPM
{
    public partial class CustomerForm : Form
    {
        MainForm mainForm;
        BindingSource bindingSource;
        CustomerBLL customerBLL;
        public CustomerForm()
        {
            InitializeComponent();
            customerBLL = new CustomerBLL();
            bindingSource = new BindingSource();
            dataGridView_customer.MultiSelect = false;

        }
        private void CustomerForm_Load(object sender, EventArgs e)
        {
            DataBindings.Clear();
            
            CreateDataGridView();
            
        }

        private void CreateDataGridView()
        {
            bindingSource.DataSource = customerBLL.GetAllCustomer();
            dataGridView_customer.DataSource = bindingSource;

            dataGridView_customer.Columns.Add("STT", "STT");
            dataGridView_customer.MultiSelect = false;
            dataGridView_customer.ReadOnly = true;
            dataGridView_customer.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //dataGridView_customer.Columns["idCustomer"].Visible = false;
            ////dataGridView_customer.Columns["Orders"].Visible = false;

            //dataGridView_customer.Columns["Name"].Width = 120;
            //dataGridView_customer.Columns["Points"].Width = 70;
            //dataGridView_customer.Columns["Email"].Width = 150;
            //dataGridView_customer.Columns["STT"].Width = 30;
            //dataGridView_customer.Columns["BirthDate"].Width = 110;
            //dataGridView_customer.Columns["NumberPhone"].Width = 80;
            //dataGridView_customer.Columns["IdentifyNumber"].Width = 80;

            //dataGridView_customer.Columns["Name"].HeaderText = "Họ tên";
            //dataGridView_customer.Columns["BirthDate"].HeaderText = "Ngày sinh";
            //dataGridView_customer.Columns["NumberPhone"].HeaderText = "Số điện thoại";
            //dataGridView_customer.Columns["IdentifyNumber"].HeaderText = "Số CMND";
            //dataGridView_customer.Columns["Points"].HeaderText = "Điểm Thưởng";
            //dataGridView_customer.Columns["Address"].Visible = false;

            dataGridView_customer.ClearSelection();
            dataGridView_customer.Rows[0].Selected = false;
        }

        private void FillTextBox()
        {
            txt_address.DataBindings.Clear();
            txt_customerName.DataBindings.Clear();
            txt_email.DataBindings.Clear();
            txt_numberPhone.DataBindings.Clear();
            dateTimePicker_BirthDate.DataBindings.Clear();

            txt_address.DataBindings.Add("Text", bindingSource, "Name");
            txt_customerName.DataBindings.Add("Text", bindingSource, "Email");
            txt_email.DataBindings.Add("Text", bindingSource, "IdentifyNumber");
            txt_numberPhone.DataBindings.Add("Text", bindingSource, "NumberPhone");
            dateTimePicker_BirthDate.DataBindings.Add("Value", bindingSource, "BirthDate");
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_update_customer_Click(object sender, EventArgs e)
        {
            if (btn_update_customer.LabelText == "Sửa")
            {
                btn_update_customer.LabelText = "Lưu";

            }
            else
            {
                btn_update_customer.LabelText = "Sửa";
            }
        }

        private void btn_add_customer_Click(object sender, EventArgs e)
        {
            if (btn_add_customer.LabelText == "Thêm")
            {
                btn_add_customer.LabelText = "Lưu";
                txt_customerName.Text = "";
                txt_address.Text = "";
                txt_email.Text = "";
                txt_numberPhone.Text = "";

            }
            else
            {
                btn_add_customer.LabelText = "Thêm";
            }
        }

        private void btn_detele_customer_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Hãy Chắc Rằng Bạn Muốn Xóa Khách Hàng Này.\nXác Nhận Xóa Khách Hàng ?", "Xóa Khách hàng", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dr == DialogResult.Yes)
            {
                dataGridView_customer.Rows.RemoveAt(dataGridView_customer.CurrentRow.Index);
                customerBLL.delete(dataGridView_customer.CurrentRow.Index);
            }
            else
            {
                return;
            }
        }

        private void txt_search_customer_KeyPress(object sender, KeyPressEventArgs e)
        {
            String txt = txt_search_customer.Text.ToString().Trim();
            CreateDataGridView();
            bindingSource.DataSource = customerBLL.GetListCustomerFromPhone(txt);
            //if (IsNumber(txt) == true)
            //{
            //    CreateDataGridView();
            //    bindingSource.DataSource = customerBLL.searchCustomerbyId(txt);
            //}
            //else if (IsNumber(txt) == false)
            //{
            //    CreateDataGridView();
            //    bindingSource.DataSource = customerBLL.GetListCustomerFromPhone(txt);
            //}
        }
        private bool IsNumber(string pText)
        {
            char s = pText.Trim().First();
            String a = Convert.ToString(s);
            //while (s.IndexOf(" ") >= 0)        
            //    s = s.Replace("  ", "");             
            Regex regex = new Regex(@"^[0-9]{1}$");
            return regex.IsMatch(a);
        }
    }   
}
