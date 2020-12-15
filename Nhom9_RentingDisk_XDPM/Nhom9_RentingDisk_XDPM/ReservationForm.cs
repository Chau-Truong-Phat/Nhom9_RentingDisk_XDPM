using Business;
using DataAccess.DTO;
using DataAccess.Entities;
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
    public partial class ReservationForm : Form
    {
        BindingSource bindingSource;
        CustomerBLL customerBLL;
        TitleBLL titleBLL;
        HoldingBLL holdingBLL;
        AutoCompleteStringCollection autoText;
        AutoCompleteStringCollection autoText2;

        public ReservationForm()
        {
            InitializeComponent();
            bindingSource = new BindingSource();
            customerBLL = new CustomerBLL();
            titleBLL = new TitleBLL();
            holdingBLL = new HoldingBLL();
            CreateDataGridView();
            autoText = new AutoCompleteStringCollection();
            autoText2 = new AutoCompleteStringCollection();
        }
        private void CreateDataGridView()
        {
            bindingSource.DataSource = holdingBLL.GetAllHoding().Reverse<Holding>();
            dgv_Reservation.DataSource = bindingSource;

            dgv_Reservation.MultiSelect = false;
            dgv_Reservation.ReadOnly = true;
            dgv_Reservation.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //dataGridView_customer.Columns["idCustomer"].Visible = false;
            ////dataGridView_customer.Columns["Orders"].Visible = false;
            dgv_Reservation.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_Reservation.ClearSelection();
            dgv_Reservation.Rows[0].Selected = false;
        }
        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_searchItem_KeyUp(object sender, KeyEventArgs e)
        {
            if (txt_searchItem.Text != "")
            {
                int txt = Convert.ToInt32(txt_searchItem.Text.ToString().Trim());
                CreateDataGridView();
                bindingSource.DataSource = holdingBLL.getListReservationByCustomerID(txt);
            }
            else
            {
                return;
            }
        }

        

        private void ReservationForm_Load(object sender, EventArgs e)
        {
            foreach (var item in customerBLL.GetAllCustomer())
            {
                autoText.Add(item.idCustomer.ToString());
            }
            txt_customerID.AutoCompleteCustomSource = autoText;

            foreach (var item in titleBLL.GetAlltt())
            {
                autoText2.Add(item.idTitle.ToString());
            }
            txt_titleID.AutoCompleteCustomSource = autoText2;
        }

        private void txt_customerID_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                txt_customerName.Text = customerBLL.searchCustomerbyId(Convert.ToInt32(txt_customerID.Text)).name;
                txt_numberPhone.Text = customerBLL.searchCustomerbyId(Convert.ToInt32(txt_customerID.Text)).phoneNumber;
            }
        }

        private void txt_titleID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_titleName.Text = titleBLL.GetItemTitleById(txt_titleID.Text.Trim()).name;
            }
        }

        private void btn_DatHang_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Xác nhận đặt đĩa này.\nXác Nhận ?", "Không", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dr == DialogResult.Yes)
            {
                Holding cus = new Holding()
                {
                    idCustomer = Convert.ToInt32(txt_customerID.Text),
                    idTitle = txt_titleID.Text,
                    reservationTime = DateTime.Now
                };
                Result result = null;
                var taskCreate = Task.Factory.StartNew(() => result = holdingBLL.add(cus));
                taskCreate.Wait();

                if (result.isSuccess)
                {
                    MessageBox.Show(result.message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    bindingSource.DataSource = holdingBLL.GetAllHoding().Reverse<Holding>();
                    dgv_Reservation.DataSource = bindingSource;
                }
                else
                {
                    MessageBox.Show(result.message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }

            }
            else
            {
                return;
            }
        }
    }
}
