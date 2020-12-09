using Business;
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
    public partial class CheckLateChargeForm : Form
    {
        private const string DATE_FORMAT = "dd/MM/yyyy";
        private CustomerBLL _customerBLL;
        private RecordBLL _recordBLL;
        private TitleBLL _titleBLL;

        private Customer customer;
        private List<Record> records;
        private Title title;
        public CheckLateChargeForm()
        {
            InitializeComponent();
            _customerBLL = new CustomerBLL();
            _recordBLL = new RecordBLL();
            _titleBLL = new TitleBLL();

            customer = new Customer();
            records = new List<Record>();
            title = new Title();
        }
        private void CreateDataGridView()
        {
            dgv_listItem.ColumnCount = 5;
            dgv_listItem.MultiSelect = false;
            dgv_listItem.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_listItem.Columns[0].Name = "STT";
            dgv_listItem.Columns[0].Width = (int)(dgv_listItem.Width * 0.1);
            dgv_listItem.Columns[1].Name = "Mã đĩa";
            dgv_listItem.Columns[1].Width = (int)(dgv_listItem.Width * 0.15);
            dgv_listItem.Columns[2].Name = "Tên tiêu đề";
            dgv_listItem.Columns[2].Width = (int)(dgv_listItem.Width * 0.35);
            dgv_listItem.Columns[3].Name = "Ngày thuê";
            dgv_listItem.Columns[3].Width = (int)(dgv_listItem.Width * 0.16);
            dgv_listItem.Columns[4].Name = "Ngày cần trả";
            dgv_listItem.Columns[4].Width = (int)(dgv_listItem.Width * 0.16);
            var deleteButton = new DataGridViewButtonColumn();
            deleteButton.Name = "dataGridViewDeleteButton";
            deleteButton.HeaderText = "Delete";
            deleteButton.Text = "Delete";
            deleteButton.UseColumnTextForButtonValue = true;
            this.dgv_listItem.Columns.Add(deleteButton);

        }

        private void txt_numberPhone_TextChanged(object sender, EventArgs e)
        {
            if (txt_numberPhone.Text != null)
            {
                customer = _customerBLL.searchCustomerbyPhone(txt_numberPhone.Text.Trim());
                if (customer != null)
                {
                    txt_nameCustomer.Text = customer.name;
                    records = _recordBLL.GetAllRecordIsReturn(customer.idCustomer);
                    int i = 1;
                    if (records.Count > 0)
                    {
                        foreach (var item in records)
                        {
                            title = _titleBLL.GetItemTitleById(item.idTitle);
                            _ = dgv_listItem.Rows.Add(i.ToString(), item.idDisk, title.name, item.rentDate.ToString(DATE_FORMAT), item.dueDate.ToString(DATE_FORMAT));
                            i++;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Khách hàng không nợ phí trả trễ");
                    }

                }
            }
        }

        private void dgv_listItem_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex == dgv_listItem.NewRowIndex || e.RowIndex < 0)
                return;

            if (e.ColumnIndex == dgv_listItem.Columns["dataGridViewDeleteButton"].Index)
            {
                var image = Properties.Resources.delete_sign_16px; //An image
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var x = e.CellBounds.Left + (e.CellBounds.Width - image.Width) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - image.Height) / 2;
                e.Graphics.DrawImage(image, new Point(x, y));

                e.Handled = true;
            }
        }
    }
}
