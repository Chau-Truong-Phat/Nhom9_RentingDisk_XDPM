using Business;
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
    public partial class CustomerForm : Form
    {
        BindingSource bindingSource;
        CustomerBLL customerBLL;
        public CustomerForm()
        {
            customerBLL = new CustomerBLL();
            bindingSource = new BindingSource();
            InitializeComponent();
            CreateDataGridView();
            Clear_TextBox();
        }

        private void CreateDataGridView()
        {
            bindingSource.DataSource = customerBLL.GetAllCustomer();
            dataGridView_customer.DataSource = bindingSource;

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

        private void Clear_TextBox()
        {
            txt_customerName.Clear();
            txt_addressName.Clear();
            txt_email.Clear();
            txt_numberPhone.Clear();
            txt_dateBirth.Value = DateTime.Now;
        }
        
        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_searchItem_KeyUp(object sender, KeyEventArgs e)
        {
            int txt = Convert.ToInt32(txt_searchItem.Text.ToString().Trim());
            CreateDataGridView();
            bindingSource.DataSource = customerBLL.getListCustomerbyID(txt);
        }
        private void FillTextBox()
        {
            txt_addressName.DataBindings.Clear();
            txt_customerName.DataBindings.Clear();
            txt_email.DataBindings.Clear();
            txt_numberPhone.DataBindings.Clear();
            txt_dateBirth.DataBindings.Clear();

            txt_addressName.DataBindings.Add("Text", bindingSource, "address");
            txt_customerName.DataBindings.Add("Text", bindingSource, "name");
            txt_email.DataBindings.Add("Text", bindingSource, "email");
            txt_numberPhone.DataBindings.Add("Text", bindingSource, "phoneNumber");
            txt_dateBirth.DataBindings.Add("Value", bindingSource, "birthDate");
        }
        private void dataGridView_customer_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if(btn_updateCustomer.LabelText == "Lưu")
            {
                FillTextBox();
            }    
        }

        private void btn_addCustomer_Click(object sender, EventArgs e)
        {
            if (btn_addCustomer.LabelText == "Thêm")
            {
                btn_addCustomer.LabelText = "Lưu";
                Clear_TextBox();
            }
            else
            {
                btn_addCustomer.LabelText = "Thêm";
            }
        }

        private void btn_updateCustomer_Click(object sender, EventArgs e)
        {
            if (btn_updateCustomer.LabelText == "Sửa")
            {
                btn_updateCustomer.LabelText = "Lưu";
            }
            else
            {
                btn_updateCustomer.LabelText = "Sửa";
            }
        }

        private void btn_deleteCustomer_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Hãy Chắc Rằng Bạn Muốn Xóa Khách Hàng Này.\nXác Nhận Xóa Khách Hàng ?", "Xóa Khách hàng", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dr == DialogResult.Yes)
            {
                dataGridView_customer.Rows.RemoveAt(dataGridView_customer.CurrentRow.Index);
                //Đéo hiểu sao không xóa được
                customerBLL.delete(Convert.ToInt32(dataGridView_customer.CurrentRow.Cells["idCustomer"].Value));
            }
            else
            {
                return;
            }
        }
    }
}
