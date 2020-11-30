namespace Nhom9_RentingDisk_XDPM
{
    partial class RentingForm
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
            this.txt_search_title = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txt_numberPhone = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.txt_total = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.txt_customerName = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_pay = new Bunifu.Framework.UI.BunifuTileButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView_title = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_img_delete_newFee = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_ig_menu_newFee = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_img_delete_lateFee = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_img_menu_lateFee = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_title)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_img_delete_newFee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_ig_menu_newFee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_img_delete_lateFee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_img_menu_lateFee)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_search_title
            // 
            this.txt_search_title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_search_title.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_search_title.Depth = 0;
            this.txt_search_title.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search_title.Hint = "Search Title";
            this.txt_search_title.Location = new System.Drawing.Point(30, 6);
            this.txt_search_title.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_search_title.Name = "txt_search_title";
            this.txt_search_title.PasswordChar = '\0';
            this.txt_search_title.SelectedText = "";
            this.txt_search_title.SelectionLength = 0;
            this.txt_search_title.SelectionStart = 0;
            this.txt_search_title.Size = new System.Drawing.Size(479, 23);
            this.txt_search_title.TabIndex = 16;
            this.txt_search_title.UseSystemPasswordChar = false;
            // 
            // txt_numberPhone
            // 
            this.txt_numberPhone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_numberPhone.BorderColor = System.Drawing.Color.SeaGreen;
            this.txt_numberPhone.Location = new System.Drawing.Point(7, 104);
            this.txt_numberPhone.Name = "txt_numberPhone";
            this.txt_numberPhone.Size = new System.Drawing.Size(272, 20);
            this.txt_numberPhone.TabIndex = 14;
            // 
            // txt_total
            // 
            this.txt_total.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_total.BackColor = System.Drawing.Color.Silver;
            this.txt_total.BorderColor = System.Drawing.Color.SeaGreen;
            this.txt_total.Location = new System.Drawing.Point(7, 331);
            this.txt_total.Name = "txt_total";
            this.txt_total.ReadOnly = true;
            this.txt_total.Size = new System.Drawing.Size(271, 20);
            this.txt_total.TabIndex = 10;
            // 
            // txt_customerName
            // 
            this.txt_customerName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_customerName.BorderColor = System.Drawing.Color.SeaGreen;
            this.txt_customerName.Location = new System.Drawing.Point(6, 58);
            this.txt_customerName.Name = "txt_customerName";
            this.txt_customerName.Size = new System.Drawing.Size(272, 20);
            this.txt_customerName.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tên khách hàng";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tổng";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Phí thuê mới";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Phí trễ";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Số điện thoại";
            // 
            // btn_pay
            // 
            this.btn_pay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_pay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_pay.color = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_pay.colorActive = System.Drawing.Color.Blue;
            this.btn_pay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_pay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pay.ForeColor = System.Drawing.Color.White;
            this.btn_pay.Image = null;
            this.btn_pay.ImagePosition = 20;
            this.btn_pay.ImageZoom = 50;
            this.btn_pay.LabelPosition = 35;
            this.btn_pay.LabelText = "Thanh toán";
            this.btn_pay.Location = new System.Drawing.Point(6, 360);
            this.btn_pay.Margin = new System.Windows.Forms.Padding(6);
            this.btn_pay.Name = "btn_pay";
            this.btn_pay.Size = new System.Drawing.Size(273, 46);
            this.btn_pay.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.btn_pay);
            this.panel2.Controls.Add(this.btn_img_delete_newFee);
            this.panel2.Controls.Add(this.btn_ig_menu_newFee);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txt_customerName);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txt_numberPhone);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btn_img_delete_lateFee);
            this.panel2.Controls.Add(this.btn_img_menu_lateFee);
            this.panel2.Controls.Add(this.txt_total);
            this.panel2.Location = new System.Drawing.Point(515, 38);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(285, 412);
            this.panel2.TabIndex = 20;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.dataGridView_title);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.txt_search_title);
            this.panel3.Location = new System.Drawing.Point(0, 38);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(515, 412);
            this.panel3.TabIndex = 21;
            // 
            // dataGridView_title
            // 
            this.dataGridView_title.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_title.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_title.Location = new System.Drawing.Point(3, 35);
            this.dataGridView_title.Name = "dataGridView_title";
            this.dataGridView_title.Size = new System.Drawing.Size(506, 371);
            this.dataGridView_title.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(56, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(162, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Thông tin khách hàng";
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.btn_back);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(800, 38);
            this.panel4.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(370, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "Thuê đĩa";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.btn_back.Location = new System.Drawing.Point(1, 2);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(150, 32);
            this.btn_back.TabIndex = 19;
            this.btn_back.Text = "          Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pictureBox2.Image = global::Nhom9_RentingDisk_XDPM.Properties.Resources.search;
            this.pictureBox2.Location = new System.Drawing.Point(3, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(21, 21);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // btn_img_delete_newFee
            // 
            this.btn_img_delete_newFee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_img_delete_newFee.BackColor = System.Drawing.Color.White;
            this.btn_img_delete_newFee.Image = global::Nhom9_RentingDisk_XDPM.Properties.Resources.delete;
            this.btn_img_delete_newFee.ImageActive = null;
            this.btn_img_delete_newFee.Location = new System.Drawing.Point(248, 230);
            this.btn_img_delete_newFee.Name = "btn_img_delete_newFee";
            this.btn_img_delete_newFee.Size = new System.Drawing.Size(30, 30);
            this.btn_img_delete_newFee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_img_delete_newFee.TabIndex = 12;
            this.btn_img_delete_newFee.TabStop = false;
            this.btn_img_delete_newFee.Zoom = 10;
            // 
            // btn_ig_menu_newFee
            // 
            this.btn_ig_menu_newFee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ig_menu_newFee.BackColor = System.Drawing.Color.White;
            this.btn_ig_menu_newFee.Image = global::Nhom9_RentingDisk_XDPM.Properties.Resources.Menu;
            this.btn_ig_menu_newFee.ImageActive = null;
            this.btn_ig_menu_newFee.Location = new System.Drawing.Point(207, 230);
            this.btn_ig_menu_newFee.Name = "btn_ig_menu_newFee";
            this.btn_ig_menu_newFee.Size = new System.Drawing.Size(30, 30);
            this.btn_ig_menu_newFee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_ig_menu_newFee.TabIndex = 13;
            this.btn_ig_menu_newFee.TabStop = false;
            this.btn_ig_menu_newFee.Zoom = 10;
            // 
            // btn_img_delete_lateFee
            // 
            this.btn_img_delete_lateFee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_img_delete_lateFee.BackColor = System.Drawing.Color.White;
            this.btn_img_delete_lateFee.Image = global::Nhom9_RentingDisk_XDPM.Properties.Resources.delete;
            this.btn_img_delete_lateFee.ImageActive = null;
            this.btn_img_delete_lateFee.Location = new System.Drawing.Point(248, 267);
            this.btn_img_delete_lateFee.Name = "btn_img_delete_lateFee";
            this.btn_img_delete_lateFee.Size = new System.Drawing.Size(30, 30);
            this.btn_img_delete_lateFee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_img_delete_lateFee.TabIndex = 12;
            this.btn_img_delete_lateFee.TabStop = false;
            this.btn_img_delete_lateFee.Zoom = 10;
            // 
            // btn_img_menu_lateFee
            // 
            this.btn_img_menu_lateFee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_img_menu_lateFee.BackColor = System.Drawing.Color.White;
            this.btn_img_menu_lateFee.Image = global::Nhom9_RentingDisk_XDPM.Properties.Resources.Menu;
            this.btn_img_menu_lateFee.ImageActive = null;
            this.btn_img_menu_lateFee.Location = new System.Drawing.Point(207, 267);
            this.btn_img_menu_lateFee.Name = "btn_img_menu_lateFee";
            this.btn_img_menu_lateFee.Size = new System.Drawing.Size(30, 30);
            this.btn_img_menu_lateFee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_img_menu_lateFee.TabIndex = 13;
            this.btn_img_menu_lateFee.TabStop = false;
            this.btn_img_menu_lateFee.Zoom = 10;
            // 
            // RentingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RentingForm";
            this.Text = "RentingForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_title)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_img_delete_newFee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_ig_menu_newFee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_img_delete_lateFee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_img_menu_lateFee)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_search_title;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txt_numberPhone;
        private Bunifu.Framework.UI.BunifuImageButton btn_img_delete_lateFee;
        private Bunifu.Framework.UI.BunifuImageButton btn_img_menu_lateFee;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txt_total;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txt_customerName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuTileButton btn_pay;
        private Bunifu.Framework.UI.BunifuImageButton btn_img_delete_newFee;
        private Bunifu.Framework.UI.BunifuImageButton btn_ig_menu_newFee;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView_title;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label label8;
    }
}