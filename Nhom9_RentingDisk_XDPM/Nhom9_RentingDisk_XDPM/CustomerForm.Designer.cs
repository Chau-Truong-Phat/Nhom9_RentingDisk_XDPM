namespace Nhom9_RentingDisk_XDPM
{
    partial class CustomerForm
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
            this.pnl_customerInfo = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dateTimePicker_BirthDate = new System.Windows.Forms.DateTimePicker();
            this.btn_add_customer = new Bunifu.Framework.UI.BunifuTileButton();
            this.btn_detele_customer = new Bunifu.Framework.UI.BunifuTileButton();
            this.btn_update_customer = new Bunifu.Framework.UI.BunifuTileButton();
            this.txt_address = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.txt_email = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.txt_numberPhone = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_customerName = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView_customer = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_search_customer = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.panel1 = new System.Windows.Forms.Panel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.btn_back = new System.Windows.Forms.Button();
            this.pnl_customerInfo.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_customer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_customerInfo
            // 
            this.pnl_customerInfo.Controls.Add(this.panel3);
            this.pnl_customerInfo.Controls.Add(this.panel2);
            this.pnl_customerInfo.Controls.Add(this.panel1);
            this.pnl_customerInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_customerInfo.Location = new System.Drawing.Point(0, 0);
            this.pnl_customerInfo.Name = "pnl_customerInfo";
            this.pnl_customerInfo.Size = new System.Drawing.Size(875, 660);
            this.pnl_customerInfo.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.dateTimePicker_BirthDate);
            this.panel3.Controls.Add(this.btn_add_customer);
            this.panel3.Controls.Add(this.btn_detele_customer);
            this.panel3.Controls.Add(this.btn_update_customer);
            this.panel3.Controls.Add(this.txt_address);
            this.panel3.Controls.Add(this.txt_email);
            this.panel3.Controls.Add(this.txt_numberPhone);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.txt_customerName);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(590, 42);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(285, 618);
            this.panel3.TabIndex = 8;
            // 
            // dateTimePicker_BirthDate
            // 
            this.dateTimePicker_BirthDate.Location = new System.Drawing.Point(10, 217);
            this.dateTimePicker_BirthDate.Name = "dateTimePicker_BirthDate";
            this.dateTimePicker_BirthDate.Size = new System.Drawing.Size(270, 20);
            this.dateTimePicker_BirthDate.TabIndex = 25;
            // 
            // btn_add_customer
            // 
            this.btn_add_customer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_add_customer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_add_customer.color = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_add_customer.colorActive = System.Drawing.Color.Blue;
            this.btn_add_customer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add_customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_customer.ForeColor = System.Drawing.Color.White;
            this.btn_add_customer.Image = null;
            this.btn_add_customer.ImagePosition = 20;
            this.btn_add_customer.ImageZoom = 50;
            this.btn_add_customer.LabelPosition = 27;
            this.btn_add_customer.LabelText = "Thêm";
            this.btn_add_customer.Location = new System.Drawing.Point(6, 489);
            this.btn_add_customer.Margin = new System.Windows.Forms.Padding(6);
            this.btn_add_customer.Name = "btn_add_customer";
            this.btn_add_customer.Size = new System.Drawing.Size(271, 31);
            this.btn_add_customer.TabIndex = 24;
            this.btn_add_customer.Click += new System.EventHandler(this.btn_add_customer_Click);
            // 
            // btn_detele_customer
            // 
            this.btn_detele_customer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_detele_customer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_detele_customer.color = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_detele_customer.colorActive = System.Drawing.Color.Blue;
            this.btn_detele_customer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_detele_customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_detele_customer.ForeColor = System.Drawing.Color.White;
            this.btn_detele_customer.Image = null;
            this.btn_detele_customer.ImagePosition = 20;
            this.btn_detele_customer.ImageZoom = 50;
            this.btn_detele_customer.LabelPosition = 27;
            this.btn_detele_customer.LabelText = "Xóa";
            this.btn_detele_customer.Location = new System.Drawing.Point(6, 532);
            this.btn_detele_customer.Margin = new System.Windows.Forms.Padding(6);
            this.btn_detele_customer.Name = "btn_detele_customer";
            this.btn_detele_customer.Size = new System.Drawing.Size(271, 31);
            this.btn_detele_customer.TabIndex = 24;
            this.btn_detele_customer.Click += new System.EventHandler(this.btn_detele_customer_Click);
            // 
            // btn_update_customer
            // 
            this.btn_update_customer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_update_customer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_update_customer.color = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_update_customer.colorActive = System.Drawing.Color.Blue;
            this.btn_update_customer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_update_customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update_customer.ForeColor = System.Drawing.Color.White;
            this.btn_update_customer.Image = null;
            this.btn_update_customer.ImagePosition = 20;
            this.btn_update_customer.ImageZoom = 50;
            this.btn_update_customer.LabelPosition = 27;
            this.btn_update_customer.LabelText = "Sửa";
            this.btn_update_customer.Location = new System.Drawing.Point(6, 575);
            this.btn_update_customer.Margin = new System.Windows.Forms.Padding(6);
            this.btn_update_customer.Name = "btn_update_customer";
            this.btn_update_customer.Size = new System.Drawing.Size(271, 31);
            this.btn_update_customer.TabIndex = 24;
            this.btn_update_customer.Click += new System.EventHandler(this.btn_update_customer_Click);
            // 
            // txt_address
            // 
            this.txt_address.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_address.BorderColor = System.Drawing.Color.SeaGreen;
            this.txt_address.Location = new System.Drawing.Point(9, 170);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(271, 20);
            this.txt_address.TabIndex = 22;
            // 
            // txt_email
            // 
            this.txt_email.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_email.BorderColor = System.Drawing.Color.SeaGreen;
            this.txt_email.Location = new System.Drawing.Point(9, 124);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(271, 20);
            this.txt_email.TabIndex = 22;
            // 
            // txt_numberPhone
            // 
            this.txt_numberPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_numberPhone.BorderColor = System.Drawing.Color.SeaGreen;
            this.txt_numberPhone.Location = new System.Drawing.Point(9, 78);
            this.txt_numberPhone.Name = "txt_numberPhone";
            this.txt_numberPhone.Size = new System.Drawing.Size(271, 20);
            this.txt_numberPhone.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Ngày sinh";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Địa chỉ";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Tên khách hàng";
            // 
            // txt_customerName
            // 
            this.txt_customerName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_customerName.BorderColor = System.Drawing.Color.SeaGreen;
            this.txt_customerName.Location = new System.Drawing.Point(9, 32);
            this.txt_customerName.Name = "txt_customerName";
            this.txt_customerName.Size = new System.Drawing.Size(271, 20);
            this.txt_customerName.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Số điện thoại";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.dataGridView_customer);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.txt_search_customer);
            this.panel2.Location = new System.Drawing.Point(0, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(590, 618);
            this.panel2.TabIndex = 7;
            // 
            // dataGridView_customer
            // 
            this.dataGridView_customer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_customer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_customer.Location = new System.Drawing.Point(4, 34);
            this.dataGridView_customer.Name = "dataGridView_customer";
            this.dataGridView_customer.Size = new System.Drawing.Size(580, 572);
            this.dataGridView_customer.TabIndex = 20;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pictureBox1.Image = global::Nhom9_RentingDisk_XDPM.Properties.Resources.search;
            this.pictureBox1.Location = new System.Drawing.Point(4, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(21, 21);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // txt_search_customer
            // 
            this.txt_search_customer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_search_customer.Depth = 0;
            this.txt_search_customer.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search_customer.Hint = "Nhập ID hoặc số điện thoại khách hàng";
            this.txt_search_customer.Location = new System.Drawing.Point(31, 6);
            this.txt_search_customer.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_search_customer.Name = "txt_search_customer";
            this.txt_search_customer.PasswordChar = '\0';
            this.txt_search_customer.SelectedText = "";
            this.txt_search_customer.SelectionLength = 0;
            this.txt_search_customer.SelectionStart = 0;
            this.txt_search_customer.Size = new System.Drawing.Size(554, 23);
            this.txt_search_customer.TabIndex = 18;
            this.txt_search_customer.UseSystemPasswordChar = false;
            this.txt_search_customer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_search_customer_KeyPress);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.materialLabel4);
            this.panel1.Controls.Add(this.btn_back);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(875, 38);
            this.panel1.TabIndex = 6;
            // 
            // materialLabel4
            // 
            this.materialLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(378, 9);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(86, 19);
            this.materialLabel4.TabIndex = 18;
            this.materialLabel4.Text = "Khách hàng";
            this.materialLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btn_back.Location = new System.Drawing.Point(3, 1);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(150, 32);
            this.btn_back.TabIndex = 5;
            this.btn_back.Text = "          Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(875, 660);
            this.Controls.Add(this.pnl_customerInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerForm";
            this.Text = "CustomerForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            this.pnl_customerInfo.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_customer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_customerInfo;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuTileButton btn_add_customer;
        private Bunifu.Framework.UI.BunifuTileButton btn_detele_customer;
        private Bunifu.Framework.UI.BunifuTileButton btn_update_customer;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txt_numberPhone;
        private System.Windows.Forms.Label label2;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txt_customerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView_customer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_search_customer;
        private System.Windows.Forms.DateTimePicker dateTimePicker_BirthDate;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txt_address;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txt_email;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}