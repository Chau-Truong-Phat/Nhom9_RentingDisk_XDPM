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
            this.btn_update_information_disk = new Bunifu.Framework.UI.BunifuTileButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_back = new System.Windows.Forms.Button();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
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
            this.txt_titleName_addTitle = new System.Windows.Forms.TextBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.btn_add_title = new Bunifu.Framework.UI.BunifuTileButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bunifuCustomTextbox1 = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_search_title = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_update_information_disk
            // 
            this.btn_update_information_disk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_update_information_disk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_update_information_disk.color = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_update_information_disk.colorActive = System.Drawing.Color.Blue;
            this.btn_update_information_disk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_update_information_disk.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update_information_disk.ForeColor = System.Drawing.Color.White;
            this.btn_update_information_disk.Image = null;
            this.btn_update_information_disk.ImagePosition = 20;
            this.btn_update_information_disk.ImageZoom = 50;
            this.btn_update_information_disk.LabelPosition = 29;
            this.btn_update_information_disk.LabelText = "Thay Đổi";
            this.btn_update_information_disk.Location = new System.Drawing.Point(13, 310);
            this.btn_update_information_disk.Margin = new System.Windows.Forms.Padding(6);
            this.btn_update_information_disk.Name = "btn_update_information_disk";
            this.btn_update_information_disk.Size = new System.Drawing.Size(260, 36);
            this.btn_update_information_disk.TabIndex = 20;
            this.btn_update_information_disk.Click += new System.EventHandler(this.btn_DatLaiGiaThue_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.btn_back);
            this.panel1.Controls.Add(this.materialLabel1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(882, 38);
            this.panel1.TabIndex = 22;
            // 
            // btn_back
            // 
            this.btn_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_back.FlatAppearance.BorderSize = 0;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_back.Image = global::Nhom9_RentingDisk_XDPM.Properties.Resources.Back;
            this.btn_back.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_back.Location = new System.Drawing.Point(3, 3);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(150, 32);
            this.btn_back.TabIndex = 20;
            this.btn_back.Text = "          Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click_1);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(362, 9);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(95, 19);
            this.materialLabel1.TabIndex = 17;
            this.materialLabel1.Text = "Tựa CD\\DVD";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.cbx_titleType_addTitle);
            this.panel2.Controls.Add(this.txt_titleName_addTitle);
            this.panel2.Controls.Add(this.materialLabel4);
            this.panel2.Controls.Add(this.materialLabel3);
            this.panel2.Controls.Add(this.materialLabel2);
            this.panel2.Controls.Add(this.btn_add_title);
            this.panel2.Location = new System.Drawing.Point(597, 38);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(285, 661);
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
            this.panel4.Location = new System.Drawing.Point(0, 309);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(285, 352);
            this.panel4.TabIndex = 23;
            // 
            // txt_rent_date
            // 
            this.txt_rent_date.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_rent_date.Location = new System.Drawing.Point(14, 143);
            this.txt_rent_date.Name = "txt_rent_date";
            this.txt_rent_date.Size = new System.Drawing.Size(260, 20);
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
            this.materialLabel7.Location = new System.Drawing.Point(9, 121);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(104, 19);
            this.materialLabel7.TabIndex = 26;
            this.materialLabel7.Text = "Thời gian thuê";
            // 
            // txt_fee
            // 
            this.txt_fee.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_fee.Location = new System.Drawing.Point(14, 98);
            this.txt_fee.Name = "txt_fee";
            this.txt_fee.Size = new System.Drawing.Size(260, 20);
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
            this.cbx_titleType_updateFee.Location = new System.Drawing.Point(13, 52);
            this.cbx_titleType_updateFee.Name = "cbx_titleType_updateFee";
            this.cbx_titleType_updateFee.Size = new System.Drawing.Size(260, 21);
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
            this.materialLabel6.Location = new System.Drawing.Point(9, 76);
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
            this.materialLabel8.Location = new System.Drawing.Point(77, 10);
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
            this.materialLabel5.Location = new System.Drawing.Point(9, 30);
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
            this.cbx_titleType_addTitle.Location = new System.Drawing.Point(13, 112);
            this.cbx_titleType_addTitle.Name = "cbx_titleType_addTitle";
            this.cbx_titleType_addTitle.Size = new System.Drawing.Size(260, 21);
            this.cbx_titleType_addTitle.TabIndex = 22;
            this.cbx_titleType_addTitle.Text = "CD";
            // 
            // txt_titleName_addTitle
            // 
            this.txt_titleName_addTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_titleName_addTitle.Location = new System.Drawing.Point(13, 67);
            this.txt_titleName_addTitle.Name = "txt_titleName_addTitle";
            this.txt_titleName_addTitle.Size = new System.Drawing.Size(260, 20);
            this.txt_titleName_addTitle.TabIndex = 21;
            // 
            // materialLabel4
            // 
            this.materialLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(9, 90);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(38, 19);
            this.materialLabel4.TabIndex = 17;
            this.materialLabel4.Text = "Loại";
            // 
            // materialLabel3
            // 
            this.materialLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(9, 45);
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
            this.btn_add_title.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_add_title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_add_title.color = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_add_title.colorActive = System.Drawing.Color.Blue;
            this.btn_add_title.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_title.ForeColor = System.Drawing.Color.White;
            this.btn_add_title.Image = null;
            this.btn_add_title.ImagePosition = 20;
            this.btn_add_title.ImageZoom = 50;
            this.btn_add_title.LabelPosition = 29;
            this.btn_add_title.LabelText = "Thêm tựa";
            this.btn_add_title.Location = new System.Drawing.Point(13, 268);
            this.btn_add_title.Margin = new System.Windows.Forms.Padding(2);
            this.btn_add_title.Name = "btn_add_title";
            this.btn_add_title.Size = new System.Drawing.Size(260, 36);
            this.btn_add_title.TabIndex = 19;
            this.btn_add_title.Click += new System.EventHandler(this.btn_DatHang_Click_1);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.bunifuCustomTextbox1);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.txt_search_title);
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Location = new System.Drawing.Point(0, 38);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(600, 661);
            this.panel3.TabIndex = 24;
            // 
            // bunifuCustomTextbox1
            // 
            this.bunifuCustomTextbox1.BorderColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomTextbox1.Location = new System.Drawing.Point(7, 39);
            this.bunifuCustomTextbox1.Name = "bunifuCustomTextbox1";
            this.bunifuCustomTextbox1.Size = new System.Drawing.Size(584, 20);
            this.bunifuCustomTextbox1.TabIndex = 23;
            this.bunifuCustomTextbox1.Text = "thông tin về tựa";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pictureBox1.Image = global::Nhom9_RentingDisk_XDPM.Properties.Resources.search;
            this.pictureBox1.Location = new System.Drawing.Point(7, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // txt_search_title
            // 
            this.txt_search_title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_search_title.Depth = 0;
            this.txt_search_title.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search_title.Hint = "Hãy nhập tên tựa";
            this.txt_search_title.Location = new System.Drawing.Point(33, 10);
            this.txt_search_title.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_search_title.Name = "txt_search_title";
            this.txt_search_title.PasswordChar = '\0';
            this.txt_search_title.SelectedText = "";
            this.txt_search_title.SelectionLength = 0;
            this.txt_search_title.SelectionStart = 0;
            this.txt_search_title.Size = new System.Drawing.Size(558, 23);
            this.txt_search_title.TabIndex = 21;
            this.txt_search_title.UseSystemPasswordChar = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(584, 588);
            this.dataGridView1.TabIndex = 0;
            // 
            // TitleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(882, 699);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TitleForm";
            this.Text = "TitleForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuTileButton btn_update_information_disk;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_back;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txt_rent_date;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private System.Windows.Forms.TextBox txt_fee;
        private System.Windows.Forms.ComboBox cbx_titleType_updateFee;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private System.Windows.Forms.ComboBox cbx_titleType_addTitle;
        private System.Windows.Forms.TextBox txt_titleName_addTitle;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private Bunifu.Framework.UI.BunifuTileButton btn_add_title;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_search_title;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox bunifuCustomTextbox1;
    }
}