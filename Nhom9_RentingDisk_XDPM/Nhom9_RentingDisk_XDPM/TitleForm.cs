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
    public partial class TitleForm : Form
    {
        BindingSource bindingSource;
        TitleBLL titleBLL;
        DiskBLL diskBLL;
        BindingSource bindingSource2;
        public TitleForm()
        {
            InitializeComponent();
            titleBLL = new TitleBLL();
            diskBLL = new DiskBLL();
            bindingSource = new BindingSource();
            bindingSource2 = new BindingSource();

            dgv_title.MultiSelect = false;
            dgv_title.ReadOnly = true;
            dgv_title.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_title.ClearSelection();
            CreateDataGridViewDisk();
            
        }
        private void TitleForm_Load(object sender, EventArgs e)
        {
            DataBindings.Clear();
            bindingSource.DataSource = titleBLL.GetListTitleByID("101");
            dgv_title.DataSource = bindingSource;
        }
        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_DatHang_Click_1(object sender, EventArgs e)
        {
            
        }

        private void btn_DatLaiGiaThue_Click(object sender, EventArgs e)
        {
            
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
            bindingSource.DataSource = titleBLL.GetListTitleByID(id);
            dgv_title.DataSource = bindingSource;
        }

        private void dgv_title_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (dgv_title.SelectedRows.Count <= 0) return;
            string id = dgv_title.SelectedRows[0].Cells[0].Value.ToString();
            bindingSource2.DataSource = diskBLL.GetListDiskByIDtitle(id);
            dgv_disk.DataSource = bindingSource2;
        }

        private void materialLabel7_Click(object sender, EventArgs e)
        {

        }
    }
}
