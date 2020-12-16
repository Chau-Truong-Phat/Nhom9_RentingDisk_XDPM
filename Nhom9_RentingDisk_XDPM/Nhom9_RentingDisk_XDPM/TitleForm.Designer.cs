namespace Nhom9_RentingDisk_XDPM
{
    partial class TitleForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_update_information_disk = new Bunifu.Framework.UI.BunifuTileButton();
            this.btn_back = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txt_rent_date = new System.Windows.Forms.TextBox();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.txt_fee = new System.Windows.Forms.TextBox();
            this.cbx_titleType_updateFee = new System.Windows.Forms.ComboBox();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.cbx_titleType_addTitle = new System.Windows.Forms.ComboBox();
            this.txt_idTitle = new System.Windows.Forms.TextBox();
            this.txt_titleName = new System.Windows.Forms.TextBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.btn_add_title = new Bunifu.Framework.UI.BunifuTileButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgv_title = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.dgv_disk = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.txt_searchTitle = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.btn_addDisk = new Bunifu.Framework.UI.BunifuTileButton();
            this.txt_addDiskID = new System.Windows.Forms.TextBox();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.txt_addDiskName = new System.Windows.Forms.TextBox();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_title)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_disk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_update_information_disk
            // 
            this.btn_update_information_disk.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_update_information_disk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(173)))), ((int)(((byte)(196)))));
            this.btn_update_information_disk.color = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(173)))), ((int)(((byte)(196)))));
            this.btn_update_information_disk.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(135)))), ((int)(((byte)(205)))));
            this.btn_update_information_disk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_update_information_disk.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update_information_disk.ForeColor = System.Drawing.Color.White;
            this.btn_update_information_disk.Image = null;
            this.btn_update_information_disk.ImagePosition = 20;
            this.btn_update_information_disk.ImageZoom = 50;
            this.btn_update_information_disk.LabelPosition = 30;
            this.btn_update_information_disk.LabelText = "Thay Đổi";
            this.btn_update_information_disk.Location = new System.Drawing.Point(26, 195);
            this.btn_update_information_disk.Margin = new System.Windows.Forms.Padding(6);
            this.btn_update_information_disk.Name = "btn_update_information_disk";
            this.btn_update_information_disk.Size = new System.Drawing.Size(226, 40);
            this.btn_update_information_disk.TabIndex = 20;
            this.btn_update_information_disk.Click += new System.EventHandler(this.btn_DatLaiGiaThue_Click);
            // 
            // btn_back
            // 
            this.btn_back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_back.FlatAppearance.BorderSize = 0;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_back.Image = global::Nhom9_RentingDisk_XDPM.Properties.Resources.double_left_26px;
            this.btn_back.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_back.Location = new System.Drawing.Point(12, 664);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(125, 32);
            this.btn_back.TabIndex = 20;
            this.btn_back.Text = " Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click_1);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.cbx_titleType_addTitle);
            this.panel2.Controls.Add(this.txt_idTitle);
            this.panel2.Controls.Add(this.materialLabel1);
            this.panel2.Controls.Add(this.txt_titleName);
            this.panel2.Controls.Add(this.materialLabel4);
            this.panel2.Controls.Add(this.materialLabel3);
            this.panel2.Controls.Add(this.materialLabel2);
            this.panel2.Controls.Add(this.btn_add_title);
            this.panel2.Location = new System.Drawing.Point(606, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(276, 699);
            this.panel2.TabIndex = 23;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.txt_rent_date);
            this.panel4.Controls.Add(this.materialLabel7);
            this.panel4.Controls.Add(this.txt_fee);
            this.panel4.Controls.Add(this.cbx_titleType_updateFee);
            this.panel4.Controls.Add(this.materialLabel6);
            this.panel4.Controls.Add(this.btn_update_information_disk);
            this.panel4.Controls.Add(this.materialLabel8);
            this.panel4.Controls.Add(this.materialLabel5);
            this.panel4.Location = new System.Drawing.Point(0, 449);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(276, 250);
            this.panel4.TabIndex = 23;
            // 
            // txt_rent_date
            // 
            this.txt_rent_date.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_rent_date.Location = new System.Drawing.Point(26, 154);
            this.txt_rent_date.Name = "txt_rent_date";
            this.txt_rent_date.Size = new System.Drawing.Size(227, 20);
            this.txt_rent_date.TabIndex = 27;
            // 
            // materialLabel7
            // 
            this.materialLabel7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(21, 132);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(104, 19);
            this.materialLabel7.TabIndex = 26;
            this.materialLabel7.Text = "Thời gian thuê";
            this.materialLabel7.Click += new System.EventHandler(this.materialLabel7_Click);
            // 
            // txt_fee
            // 
            this.txt_fee.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_fee.Location = new System.Drawing.Point(26, 109);
            this.txt_fee.Name = "txt_fee";
            this.txt_fee.Size = new System.Drawing.Size(227, 20);
            this.txt_fee.TabIndex = 25;
            // 
            // cbx_titleType_updateFee
            // 
            this.cbx_titleType_updateFee.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbx_titleType_updateFee.FormattingEnabled = true;
            this.cbx_titleType_updateFee.Items.AddRange(new object[] {
            "CD",
            "DVD"});
            this.cbx_titleType_updateFee.Location = new System.Drawing.Point(25, 63);
            this.cbx_titleType_updateFee.Name = "cbx_titleType_updateFee";
            this.cbx_titleType_updateFee.Size = new System.Drawing.Size(227, 21);
            this.cbx_titleType_updateFee.TabIndex = 25;
            this.cbx_titleType_updateFee.Text = "CD";
            // 
            // materialLabel6
            // 
            this.materialLabel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(21, 87);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(64, 19);
            this.materialLabel6.TabIndex = 24;
            this.materialLabel6.Text = "Giá thuê";
            // 
            // materialLabel8
            // 
            this.materialLabel8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(92, 17);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(109, 19);
            this.materialLabel8.TabIndex = 24;
            this.materialLabel8.Text = "Đặt lại giá thuê";
            // 
            // materialLabel5
            // 
            this.materialLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(22, 41);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(38, 19);
            this.materialLabel5.TabIndex = 24;
            this.materialLabel5.Text = "Loại";
            // 
            // cbx_titleType_addTitle
            // 
            this.cbx_titleType_addTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbx_titleType_addTitle.FormattingEnabled = true;
            this.cbx_titleType_addTitle.Items.AddRange(new object[] {
            "CD",
            "DVD"});
            this.cbx_titleType_addTitle.Location = new System.Drawing.Point(17, 158);
            this.cbx_titleType_addTitle.Name = "cbx_titleType_addTitle";
            this.cbx_titleType_addTitle.Size = new System.Drawing.Size(247, 21);
            this.cbx_titleType_addTitle.TabIndex = 22;
            this.cbx_titleType_addTitle.Text = "CD";
            // 
            // txt_idTitle
            // 
            this.txt_idTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_idTitle.Location = new System.Drawing.Point(17, 68);
            this.txt_idTitle.Name = "txt_idTitle";
            this.txt_idTitle.Size = new System.Drawing.Size(247, 20);
            this.txt_idTitle.TabIndex = 21;
            // 
            // txt_titleName
            // 
            this.txt_titleName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_titleName.Location = new System.Drawing.Point(17, 113);
            this.txt_titleName.Name = "txt_titleName";
            this.txt_titleName.Size = new System.Drawing.Size(247, 20);
            this.txt_titleName.TabIndex = 21;
            // 
            // materialLabel4
            // 
            this.materialLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(13, 136);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(38, 19);
            this.materialLabel4.TabIndex = 17;
            this.materialLabel4.Text = "Loại";
            // 
            // materialLabel1
            // 
            this.materialLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(13, 46);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(56, 19);
            this.materialLabel1.TabIndex = 17;
            this.materialLabel1.Text = "Mã tựa";
            // 
            // materialLabel3
            // 
            this.materialLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(13, 91);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(60, 19);
            this.materialLabel3.TabIndex = 17;
            this.materialLabel3.Text = "Tên tựa";
            // 
            // materialLabel2
            // 
            this.materialLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(92, 14);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(73, 19);
            this.materialLabel2.TabIndex = 17;
            this.materialLabel2.Text = "Thêm tựa";
            // 
            // btn_add_title
            // 
            this.btn_add_title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_add_title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(173)))), ((int)(((byte)(196)))));
            this.btn_add_title.color = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(173)))), ((int)(((byte)(196)))));
            this.btn_add_title.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(135)))), ((int)(((byte)(205)))));
            this.btn_add_title.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_title.ForeColor = System.Drawing.Color.White;
            this.btn_add_title.Image = null;
            this.btn_add_title.ImagePosition = 20;
            this.btn_add_title.ImageZoom = 50;
            this.btn_add_title.LabelPosition = 30;
            this.btn_add_title.LabelText = "Thêm tựa";
            this.btn_add_title.Location = new System.Drawing.Point(17, 184);
            this.btn_add_title.Margin = new System.Windows.Forms.Padding(2);
            this.btn_add_title.Name = "btn_add_title";
            this.btn_add_title.Size = new System.Drawing.Size(248, 40);
            this.btn_add_title.TabIndex = 19;
            this.btn_add_title.Click += new System.EventHandler(this.btn_add_title_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.dgv_title);
            this.panel3.Controls.Add(this.dgv_disk);
            this.panel3.Controls.Add(this.txt_searchTitle);
            this.panel3.Controls.Add(this.btn_back);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(609, 699);
            this.panel3.TabIndex = 24;
            // 
            // dgv_title
            // 
            this.dgv_title.AllowUserToAddRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv_title.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_title.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_title.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgv_title.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_title.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(173)))), ((int)(((byte)(196)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_title.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_title.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_title.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_title.DoubleBuffered = true;
            this.dgv_title.EnableHeadersVisualStyles = false;
            this.dgv_title.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(173)))), ((int)(((byte)(196)))));
            this.dgv_title.HeaderForeColor = System.Drawing.Color.White;
            this.dgv_title.Location = new System.Drawing.Point(12, 45);
            this.dgv_title.Name = "dgv_title";
            this.dgv_title.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_title.Size = new System.Drawing.Size(575, 308);
            this.dgv_title.TabIndex = 26;
            this.dgv_title.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dgv_title_RowStateChanged);
            // 
            // dgv_disk
            // 
            this.dgv_disk.AllowUserToAddRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv_disk.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgv_disk.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_disk.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgv_disk.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_disk.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(173)))), ((int)(((byte)(196)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_disk.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgv_disk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_disk.DoubleBuffered = true;
            this.dgv_disk.EnableHeadersVisualStyles = false;
            this.dgv_disk.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(173)))), ((int)(((byte)(196)))));
            this.dgv_disk.HeaderForeColor = System.Drawing.Color.White;
            this.dgv_disk.Location = new System.Drawing.Point(12, 377);
            this.dgv_disk.Name = "dgv_disk";
            this.dgv_disk.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_disk.Size = new System.Drawing.Size(575, 281);
            this.dgv_disk.TabIndex = 25;
            this.dgv_disk.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_disk_CellClick);
            // 
            // txt_searchTitle
            // 
            this.txt_searchTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_searchTitle.Depth = 0;
            this.txt_searchTitle.Hint = "Nhập ID Tựa";
            this.txt_searchTitle.Location = new System.Drawing.Point(39, 9);
            this.txt_searchTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_searchTitle.Name = "txt_searchTitle";
            this.txt_searchTitle.PasswordChar = '\0';
            this.txt_searchTitle.SelectedText = "";
            this.txt_searchTitle.SelectionLength = 0;
            this.txt_searchTitle.SelectionStart = 0;
            this.txt_searchTitle.Size = new System.Drawing.Size(548, 23);
            this.txt_searchTitle.TabIndex = 24;
            this.txt_searchTitle.UseSystemPasswordChar = false;
            this.txt_searchTitle.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_searchTitle_KeyUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pictureBox1.Image = global::Nhom9_RentingDisk_XDPM.Properties.Resources.search;
            this.pictureBox1.Location = new System.Drawing.Point(12, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 19);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(880, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2, 699);
            this.panel1.TabIndex = 25;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txt_addDiskID);
            this.panel5.Controls.Add(this.materialLabel10);
            this.panel5.Controls.Add(this.txt_addDiskName);
            this.panel5.Controls.Add(this.materialLabel11);
            this.panel5.Controls.Add(this.materialLabel9);
            this.panel5.Controls.Add(this.btn_addDisk);
            this.panel5.Location = new System.Drawing.Point(4, 251);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(269, 198);
            this.panel5.TabIndex = 24;
            // 
            // materialLabel9
            // 
            this.materialLabel9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel9.Location = new System.Drawing.Point(88, 16);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(72, 19);
            this.materialLabel9.TabIndex = 17;
            this.materialLabel9.Text = "Thêm đĩa";
            // 
            // btn_addDisk
            // 
            this.btn_addDisk.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_addDisk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(173)))), ((int)(((byte)(196)))));
            this.btn_addDisk.color = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(173)))), ((int)(((byte)(196)))));
            this.btn_addDisk.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(135)))), ((int)(((byte)(205)))));
            this.btn_addDisk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_addDisk.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addDisk.ForeColor = System.Drawing.Color.White;
            this.btn_addDisk.Image = null;
            this.btn_addDisk.ImagePosition = 20;
            this.btn_addDisk.ImageZoom = 50;
            this.btn_addDisk.LabelPosition = 30;
            this.btn_addDisk.LabelText = "Thêm Đĩa";
            this.btn_addDisk.Location = new System.Drawing.Point(13, 139);
            this.btn_addDisk.Margin = new System.Windows.Forms.Padding(2);
            this.btn_addDisk.Name = "btn_addDisk";
            this.btn_addDisk.Size = new System.Drawing.Size(247, 40);
            this.btn_addDisk.TabIndex = 19;
            this.btn_addDisk.Click += new System.EventHandler(this.btn_addDisk_Click);
            // 
            // txt_addDiskID
            // 
            this.txt_addDiskID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_addDiskID.Location = new System.Drawing.Point(13, 58);
            this.txt_addDiskID.Name = "txt_addDiskID";
            this.txt_addDiskID.ReadOnly = true;
            this.txt_addDiskID.Size = new System.Drawing.Size(247, 20);
            this.txt_addDiskID.TabIndex = 24;
            // 
            // materialLabel10
            // 
            this.materialLabel10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel10.Location = new System.Drawing.Point(9, 36);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(56, 19);
            this.materialLabel10.TabIndex = 22;
            this.materialLabel10.Text = "Mã tựa";
            // 
            // txt_addDiskName
            // 
            this.txt_addDiskName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_addDiskName.Location = new System.Drawing.Point(13, 103);
            this.txt_addDiskName.Name = "txt_addDiskName";
            this.txt_addDiskName.ReadOnly = true;
            this.txt_addDiskName.Size = new System.Drawing.Size(247, 20);
            this.txt_addDiskName.TabIndex = 25;
            // 
            // materialLabel11
            // 
            this.materialLabel11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel11.Location = new System.Drawing.Point(9, 81);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(60, 19);
            this.materialLabel11.TabIndex = 23;
            this.materialLabel11.Text = "Tên tựa";
            // 
            // TitleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(882, 699);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TitleForm";
            this.Text = "TitleForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TitleForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_title)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_disk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuTileButton btn_update_information_disk;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txt_rent_date;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private System.Windows.Forms.TextBox txt_fee;
        private System.Windows.Forms.ComboBox cbx_titleType_updateFee;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private System.Windows.Forms.ComboBox cbx_titleType_addTitle;
        private System.Windows.Forms.TextBox txt_titleName;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private Bunifu.Framework.UI.BunifuTileButton btn_add_title;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_searchTitle;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgv_disk;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgv_title;
        private System.Windows.Forms.TextBox txt_idTitle;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txt_addDiskID;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private System.Windows.Forms.TextBox txt_addDiskName;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private Bunifu.Framework.UI.BunifuTileButton btn_addDisk;
    }
}