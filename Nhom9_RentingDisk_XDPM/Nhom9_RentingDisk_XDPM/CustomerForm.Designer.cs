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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnl_searchItem = new System.Windows.Forms.Panel();
            this.txt_searchItem = new System.Windows.Forms.TextBox();
            this.btn_Back = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_numberPhone = new System.Windows.Forms.TextBox();
            this.pnl_numberPhone = new System.Windows.Forms.Panel();
            this.txt_userName = new System.Windows.Forms.TextBox();
            this.btn_updateCustomer = new Bunifu.Framework.UI.BunifuTileButton();
            this.btn_deleteCustomer = new Bunifu.Framework.UI.BunifuTileButton();
            this.btn_addCustomer = new Bunifu.Framework.UI.BunifuTileButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pnl_customerInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_customerInfo
            // 
            this.pnl_customerInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_customerInfo.Controls.Add(this.pictureBox1);
            this.pnl_customerInfo.Controls.Add(this.pnl_searchItem);
            this.pnl_customerInfo.Controls.Add(this.txt_searchItem);
            this.pnl_customerInfo.Controls.Add(this.btn_Back);
            this.pnl_customerInfo.Controls.Add(this.listView1);
            this.pnl_customerInfo.Location = new System.Drawing.Point(0, 0);
            this.pnl_customerInfo.Name = "pnl_customerInfo";
            this.pnl_customerInfo.Size = new System.Drawing.Size(615, 660);
            this.pnl_customerInfo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Nhom9_RentingDisk_XDPM.Properties.Resources.search;
            this.pictureBox1.Location = new System.Drawing.Point(9, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(21, 21);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // pnl_searchItem
            // 
            this.pnl_searchItem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_searchItem.BackColor = System.Drawing.Color.DarkGray;
            this.pnl_searchItem.Location = new System.Drawing.Point(30, 38);
            this.pnl_searchItem.Name = "pnl_searchItem";
            this.pnl_searchItem.Size = new System.Drawing.Size(565, 1);
            this.pnl_searchItem.TabIndex = 23;
            // 
            // txt_searchItem
            // 
            this.txt_searchItem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_searchItem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_searchItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_searchItem.Location = new System.Drawing.Point(30, 18);
            this.txt_searchItem.Multiline = true;
            this.txt_searchItem.Name = "txt_searchItem";
            this.txt_searchItem.Size = new System.Drawing.Size(565, 22);
            this.txt_searchItem.TabIndex = 22;
            // 
            // btn_Back
            // 
            this.btn_Back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Back.FlatAppearance.BorderSize = 0;
            this.btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Back.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Back.Image = global::Nhom9_RentingDisk_XDPM.Properties.Resources.double_left_26px;
            this.btn_Back.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Back.Location = new System.Drawing.Point(0, 625);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(150, 32);
            this.btn_Back.TabIndex = 5;
            this.btn_Back.Text = "          Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(13, 90);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(582, 510);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.txt_address);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.txt_numberPhone);
            this.panel2.Controls.Add(this.pnl_numberPhone);
            this.panel2.Controls.Add(this.txt_userName);
            this.panel2.Controls.Add(this.btn_updateCustomer);
            this.panel2.Controls.Add(this.btn_deleteCustomer);
            this.panel2.Controls.Add(this.btn_addCustomer);
            this.panel2.Controls.Add(this.materialLabel2);
            this.panel2.Controls.Add(this.materialLabel3);
            this.panel2.Controls.Add(this.materialLabel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(615, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(260, 660);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.DarkGray;
            this.panel3.Location = new System.Drawing.Point(12, 211);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(236, 1);
            this.panel3.TabIndex = 27;
            // 
            // txt_address
            // 
            this.txt_address.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_address.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_address.Location = new System.Drawing.Point(12, 190);
            this.txt_address.Multiline = true;
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(236, 22);
            this.txt_address.TabIndex = 26;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Location = new System.Drawing.Point(12, 141);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(236, 1);
            this.panel1.TabIndex = 25;
            // 
            // txt_numberPhone
            // 
            this.txt_numberPhone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_numberPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_numberPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_numberPhone.Location = new System.Drawing.Point(12, 120);
            this.txt_numberPhone.Multiline = true;
            this.txt_numberPhone.Name = "txt_numberPhone";
            this.txt_numberPhone.Size = new System.Drawing.Size(236, 22);
            this.txt_numberPhone.TabIndex = 24;
            // 
            // pnl_numberPhone
            // 
            this.pnl_numberPhone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_numberPhone.BackColor = System.Drawing.Color.DarkGray;
            this.pnl_numberPhone.Location = new System.Drawing.Point(12, 71);
            this.pnl_numberPhone.Name = "pnl_numberPhone";
            this.pnl_numberPhone.Size = new System.Drawing.Size(236, 1);
            this.pnl_numberPhone.TabIndex = 23;
            // 
            // txt_userName
            // 
            this.txt_userName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_userName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_userName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_userName.Location = new System.Drawing.Point(12, 50);
            this.txt_userName.Multiline = true;
            this.txt_userName.Name = "txt_userName";
            this.txt_userName.Size = new System.Drawing.Size(236, 22);
            this.txt_userName.TabIndex = 22;
            // 
            // btn_updateCustomer
            // 
            this.btn_updateCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_updateCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(173)))), ((int)(((byte)(196)))));
            this.btn_updateCustomer.color = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(173)))), ((int)(((byte)(196)))));
            this.btn_updateCustomer.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(135)))), ((int)(((byte)(205)))));
            this.btn_updateCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_updateCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_updateCustomer.ForeColor = System.Drawing.Color.White;
            this.btn_updateCustomer.Image = null;
            this.btn_updateCustomer.ImagePosition = 17;
            this.btn_updateCustomer.ImageZoom = 50;
            this.btn_updateCustomer.LabelPosition = 30;
            this.btn_updateCustomer.LabelText = "Sửa";
            this.btn_updateCustomer.Location = new System.Drawing.Point(12, 501);
            this.btn_updateCustomer.Margin = new System.Windows.Forms.Padding(5);
            this.btn_updateCustomer.Name = "btn_updateCustomer";
            this.btn_updateCustomer.Size = new System.Drawing.Size(237, 40);
            this.btn_updateCustomer.TabIndex = 21;
            // 
            // btn_deleteCustomer
            // 
            this.btn_deleteCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_deleteCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(173)))), ((int)(((byte)(196)))));
            this.btn_deleteCustomer.color = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(173)))), ((int)(((byte)(196)))));
            this.btn_deleteCustomer.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(135)))), ((int)(((byte)(205)))));
            this.btn_deleteCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_deleteCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deleteCustomer.ForeColor = System.Drawing.Color.White;
            this.btn_deleteCustomer.Image = null;
            this.btn_deleteCustomer.ImagePosition = 17;
            this.btn_deleteCustomer.ImageZoom = 50;
            this.btn_deleteCustomer.LabelPosition = 30;
            this.btn_deleteCustomer.LabelText = "Xóa";
            this.btn_deleteCustomer.Location = new System.Drawing.Point(12, 551);
            this.btn_deleteCustomer.Margin = new System.Windows.Forms.Padding(5);
            this.btn_deleteCustomer.Name = "btn_deleteCustomer";
            this.btn_deleteCustomer.Size = new System.Drawing.Size(237, 40);
            this.btn_deleteCustomer.TabIndex = 21;
            // 
            // btn_addCustomer
            // 
            this.btn_addCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_addCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(173)))), ((int)(((byte)(196)))));
            this.btn_addCustomer.color = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(173)))), ((int)(((byte)(196)))));
            this.btn_addCustomer.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(135)))), ((int)(((byte)(205)))));
            this.btn_addCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_addCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addCustomer.ForeColor = System.Drawing.Color.White;
            this.btn_addCustomer.Image = null;
            this.btn_addCustomer.ImagePosition = 17;
            this.btn_addCustomer.ImageZoom = 50;
            this.btn_addCustomer.LabelPosition = 30;
            this.btn_addCustomer.LabelText = "Thêm";
            this.btn_addCustomer.Location = new System.Drawing.Point(12, 601);
            this.btn_addCustomer.Margin = new System.Windows.Forms.Padding(5);
            this.btn_addCustomer.Name = "btn_addCustomer";
            this.btn_addCustomer.Size = new System.Drawing.Size(237, 40);
            this.btn_addCustomer.TabIndex = 21;
            // 
            // materialLabel2
            // 
            this.materialLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(8, 90);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(98, 19);
            this.materialLabel2.TabIndex = 16;
            this.materialLabel2.Text = "Số điện thoại";
            // 
            // materialLabel3
            // 
            this.materialLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(8, 160);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(55, 19);
            this.materialLabel3.TabIndex = 15;
            this.materialLabel3.Text = "Địa chỉ";
            // 
            // materialLabel1
            // 
            this.materialLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(8, 20);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(54, 19);
            this.materialLabel1.TabIndex = 17;
            this.materialLabel1.Text = "Họ tên";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkGray;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(613, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(2, 660);
            this.panel4.TabIndex = 24;
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(875, 660);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnl_customerInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerForm";
            this.Text = "CustomerForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnl_customerInfo.ResumeLayout(false);
            this.pnl_customerInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_customerInfo;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private Bunifu.Framework.UI.BunifuTileButton btn_updateCustomer;
        private Bunifu.Framework.UI.BunifuTileButton btn_deleteCustomer;
        private Bunifu.Framework.UI.BunifuTileButton btn_addCustomer;
        private System.Windows.Forms.Panel pnl_searchItem;
        private System.Windows.Forms.TextBox txt_searchItem;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_numberPhone;
        private System.Windows.Forms.Panel pnl_numberPhone;
        private System.Windows.Forms.TextBox txt_userName;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}