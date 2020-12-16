﻿using Business;
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
    public partial class TitleForm : Form
    {
        BindingSource bindingSource;
        TitleBLL titleBLL;
        DiskBLL diskBLL;
        CategoryBLL categoryBLL;
        BindingSource bindingSource2;
        public TitleForm()
        {
            InitializeComponent();
            titleBLL = new TitleBLL();
            diskBLL = new DiskBLL();
            categoryBLL = new CategoryBLL();
            bindingSource = new BindingSource();
            bindingSource2 = new BindingSource();

            CreateDataGridViewTitle();
            CreateDataGridViewDisk();
            //Thêm đĩa
            //DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            //dgv_title.Columns.Add(btn);
            //btn.HeaderText = "Thêm đĩa";
            //btn.Name = "btn_addDisk";
            //btn.Text = "thêm";
            //btn.UseColumnTextForButtonValue = true;
            // xóa đĩa 
            DataGridViewButtonColumn btn2 = new DataGridViewButtonColumn();
            dgv_disk.Columns.Add(btn2);
            btn2.HeaderText = "Xóa đĩa";
            btn2.Text = "Xóa";
            btn2.Name = "btn_deteleDisk";
            btn2.UseColumnTextForButtonValue = true;

        }
        private void CreateDataGridViewTitle()
        {
            dgv_title.MultiSelect = false;
            dgv_title.ReadOnly = true;
            dgv_title.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_title.ClearSelection();
            
        }
        private void CustomDataGridViewTitle()
        {
            dgv_title.Columns["idTitle"].HeaderText = "Mã tiêu đề";
            dgv_title.Columns["name"].HeaderText = "Tên tiêu đề";
            dgv_title.Columns["numberOfCopies"].HeaderText = "Số bản sao";
            dgv_title.Columns["idCategory"].HeaderText = "Loại";
            dgv_title.Columns["Disks"].Visible = false;
            dgv_title.Columns["Category"].Visible = false;

            dgv_title.Columns["idTitle"].Width = 140;
            dgv_title.Columns["name"].Width = 380;
            dgv_title.Columns["numberOfCopies"].Width = 140;
            dgv_title.Columns["idCategory"].Width = 140;
        }
        private void TitleForm_Load(object sender, EventArgs e)
        {
            DataBindings.Clear();
            bindingSource.DataSource = titleBLL.GetListTitleByID("1");
            dgv_title.DataSource = bindingSource;
            CustomDataGridViewTitle();
        }
        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
        private void btn_DatLaiGiaThue_Click(object sender, EventArgs e)
        {
            int typeTT = 1;
            if (cbx_titleType_updateFee.Text == "CD")
            {
                typeTT = 2;
            }
            Category category = new Category()
            {
                rentalCharge = (float)Convert.ToDecimal(txt_fee.Text.ToString()),
                rentalPeriod = Convert.ToInt32(txt_rent_date.Text),
                lateFee = 1,
                idCategory = typeTT
            };
            Result result = null;
            var taskCreate = Task.Factory.StartNew(() => result = categoryBLL.update(category));
            taskCreate.Wait();

            if (!result.isSuccess)
            {
                bindingSource.DataSource = titleBLL.GetListTitleByID("1");
                dgv_title.DataSource = bindingSource;
                CustomDataGridViewTitle();
            }
            if (result.isSuccess)
            {
                MessageBox.Show(result.message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show(result.message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            bindingSource.DataSource = titleBLL.GetItemTitleById(txt_idTitle.Text);
            dgv_title.DataSource = bindingSource;
            CustomDataGridViewTitle();
        }

        private void btn_back_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        public void CreateDataGridViewDisk()
        {
            dgv_disk.MultiSelect = false;
            dgv_disk.ReadOnly = true;
            dgv_disk.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_disk.ClearSelection();
        }

        private void txt_searchTitle_KeyUp(object sender, KeyEventArgs e)
        {
            string id = txt_searchTitle.Text.ToString();
            TitleCreateDataGridView(id);
        }

        private void dgv_title_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            
            if (dgv_title.SelectedRows.Count > 0 && dgv_title.SelectedRows[0].Cells[0].Value != null)
            {
               string id = dgv_title.SelectedRows[0].Cells[0].Value.ToString();
               DiskCreateDataGridView(id);
               FillTextBox();
            }    
        }
        private void ClearTXT()
        {
            txt_idTitle.Clear();
            txt_titleName.Clear();
            txt_searchTitle.Clear();
            txt_fee.Clear();
            txt_rent_date.Clear();
        }
        private void DiskCreateDataGridView(string id)
        {
            bindingSource2.DataSource = diskBLL.GetListDiskByIDtitle(id);
            dgv_disk.DataSource = bindingSource2;
            //đang bug
        }
        private void TitleCreateDataGridView(string id)
        {
            bindingSource.DataSource = titleBLL.GetListTitleByID(id);
            dgv_title.DataSource = bindingSource;
            CustomDataGridViewTitle();
        }
        private void FillTextBox()
        {
            txt_addDiskID.DataBindings.Clear();
            txt_addDiskName.DataBindings.Clear();

            txt_addDiskID.DataBindings.Add("Text", bindingSource, "idTitle");
            txt_addDiskName.DataBindings.Add("Text", bindingSource, "name");
        }
        private void btn_add_title_Click(object sender, EventArgs e)
        {
            int typeTT = 1;
            if(cbx_titleType_addTitle.Text == "CD")
            {
                typeTT = 2;
            }
            Title title = new Title()
            {
                idTitle = txt_idTitle.Text.ToString().Trim(),
                name = txt_titleName.Text.ToString().Trim(),
                numberOfCopies = 0,
                idCategory = typeTT
            };
            Result result = null;
            var taskCreate = Task.Factory.StartNew(() => result = titleBLL.addTitle(title));
            taskCreate.Wait();
         
            if (result.isSuccess)
            {
                MessageBox.Show(result.message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show(result.message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            
        }

        private void materialLabel7_Click(object sender, EventArgs e)
        {

        }

        private void dgv_disk_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                DialogResult dr = MessageBox.Show("Bạn muốn XÓA đĩa này", "Xác Nhận Xóa ?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                var csID = dgv_disk.Rows[e.RowIndex].Cells["idDisk"].Value.ToString().Trim();
                if (dr == DialogResult.Yes && csID != null)
                {
                    dgv_disk.Rows.RemoveAt(dgv_disk.Rows[e.RowIndex].Index);
                    diskBLL.delete(csID);
                }
                else
                {
                    return;
                }
            }    
        }

        private void btn_addDisk_Click(object sender, EventArgs e)
        {
            if(txt_addDiskID.Text == "" || txt_addDiskName.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn tiêu đề");
                return;
            }    
            Disk disk = new Disk()
            {
                idDisk = "200" + txt_addDiskID.Text.ToString().Trim(),
                name = txt_addDiskID.Text.ToString().Trim() + " - " + txt_addDiskName.Text.ToString().Trim(),
                status = DataAccess.Entities.Enum.Status.OnShelf,
                idTitle = txt_addDiskID.Text.ToString().Trim(),
            };
            Result result = null;
            var taskCreate = Task.Factory.StartNew(() => result = diskBLL.add(disk));
            taskCreate.Wait();

            if (result.isSuccess)
            {
                MessageBox.Show(result.message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show(result.message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
    }
}
