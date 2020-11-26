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
            this.btn_Back = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.mateneTextField1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_SDT = new System.Windows.Forms.TextBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txt_DiaChi = new System.Windows.Forms.TextBox();
            this.txt_HoTen = new System.Windows.Forms.TextBox();
            this.btn_TraHang = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuTileButton1 = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuTileButton2 = new Bunifu.Framework.UI.BunifuTileButton();
            this.pnl_customerInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_customerInfo
            // 
            this.pnl_customerInfo.Controls.Add(this.btn_Back);
            this.pnl_customerInfo.Controls.Add(this.listView1);
            this.pnl_customerInfo.Controls.Add(this.pictureBox2);
            this.pnl_customerInfo.Controls.Add(this.mateneTextField1);
            this.pnl_customerInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_customerInfo.Location = new System.Drawing.Point(0, 0);
            this.pnl_customerInfo.Name = "pnl_customerInfo";
            this.pnl_customerInfo.Size = new System.Drawing.Size(875, 660);
            this.pnl_customerInfo.TabIndex = 0;
            // 
            // btn_Back
            // 
            this.btn_Back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Back.FlatAppearance.BorderSize = 0;
            this.btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Back.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Back.Image = global::Nhom9_RentingDisk_XDPM.Properties.Resources.Back;
            this.btn_Back.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Back.Location = new System.Drawing.Point(13, 621);
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
            this.listView1.Location = new System.Drawing.Point(13, 41);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(541, 559);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pictureBox2.Image = global::Nhom9_RentingDisk_XDPM.Properties.Resources.search;
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(21, 21);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // mateneTextField1
            // 
            this.mateneTextField1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mateneTextField1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.mateneTextField1.Depth = 0;
            this.mateneTextField1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mateneTextField1.Hint = "";
            this.mateneTextField1.Location = new System.Drawing.Point(38, 12);
            this.mateneTextField1.MouseState = MaterialSkin.MouseState.HOVER;
            this.mateneTextField1.Name = "mateneTextField1";
            this.mateneTextField1.PasswordChar = '\0';
            this.mateneTextField1.SelectedText = "";
            this.mateneTextField1.SelectionLength = 0;
            this.mateneTextField1.SelectionStart = 0;
            this.mateneTextField1.Size = new System.Drawing.Size(516, 23);
            this.mateneTextField1.TabIndex = 0;
            this.mateneTextField1.Text = "Nhập ID hoặc số điện thoại khách hàng";
            this.mateneTextField1.UseSystemPasswordChar = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.bunifuTileButton2);
            this.panel2.Controls.Add(this.bunifuTileButton1);
            this.panel2.Controls.Add(this.btn_TraHang);
            this.panel2.Controls.Add(this.txt_SDT);
            this.panel2.Controls.Add(this.materialLabel2);
            this.panel2.Controls.Add(this.materialLabel3);
            this.panel2.Controls.Add(this.materialLabel1);
            this.panel2.Controls.Add(this.txt_DiaChi);
            this.panel2.Controls.Add(this.txt_HoTen);
            this.panel2.Location = new System.Drawing.Point(560, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(315, 660);
            this.panel2.TabIndex = 1;
            // 
            // txt_SDT
            // 
            this.txt_SDT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_SDT.BackColor = System.Drawing.Color.Silver;
            this.txt_SDT.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SDT.Location = new System.Drawing.Point(19, 90);
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.Size = new System.Drawing.Size(284, 27);
            this.txt_SDT.TabIndex = 19;
            // 
            // materialLabel2
            // 
            this.materialLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(15, 68);
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
            this.materialLabel3.Location = new System.Drawing.Point(15, 120);
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
            this.materialLabel1.Location = new System.Drawing.Point(15, 16);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(54, 19);
            this.materialLabel1.TabIndex = 17;
            this.materialLabel1.Text = "Họ tên";
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_DiaChi.BackColor = System.Drawing.Color.Silver;
            this.txt_DiaChi.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DiaChi.Location = new System.Drawing.Point(19, 142);
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Size = new System.Drawing.Size(284, 27);
            this.txt_DiaChi.TabIndex = 18;
            // 
            // txt_HoTen
            // 
            this.txt_HoTen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_HoTen.BackColor = System.Drawing.Color.Silver;
            this.txt_HoTen.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_HoTen.Location = new System.Drawing.Point(19, 38);
            this.txt_HoTen.Name = "txt_HoTen";
            this.txt_HoTen.Size = new System.Drawing.Size(284, 27);
            this.txt_HoTen.TabIndex = 20;
            // 
            // btn_TraHang
            // 
            this.btn_TraHang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_TraHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_TraHang.color = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_TraHang.colorActive = System.Drawing.Color.Blue;
            this.btn_TraHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_TraHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TraHang.ForeColor = System.Drawing.Color.White;
            this.btn_TraHang.Image = null;
            this.btn_TraHang.ImagePosition = 17;
            this.btn_TraHang.ImageZoom = 50;
            this.btn_TraHang.LabelPosition = 25;
            this.btn_TraHang.LabelText = "Thêm";
            this.btn_TraHang.Location = new System.Drawing.Point(18, 612);
            this.btn_TraHang.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btn_TraHang.Name = "btn_TraHang";
            this.btn_TraHang.Size = new System.Drawing.Size(285, 30);
            this.btn_TraHang.TabIndex = 21;
            // 
            // bunifuTileButton1
            // 
            this.bunifuTileButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuTileButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bunifuTileButton1.color = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bunifuTileButton1.colorActive = System.Drawing.Color.Blue;
            this.bunifuTileButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuTileButton1.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton1.Image = null;
            this.bunifuTileButton1.ImagePosition = 17;
            this.bunifuTileButton1.ImageZoom = 50;
            this.bunifuTileButton1.LabelPosition = 25;
            this.bunifuTileButton1.LabelText = "Xóa";
            this.bunifuTileButton1.Location = new System.Drawing.Point(19, 572);
            this.bunifuTileButton1.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuTileButton1.Name = "bunifuTileButton1";
            this.bunifuTileButton1.Size = new System.Drawing.Size(285, 30);
            this.bunifuTileButton1.TabIndex = 21;
            // 
            // bunifuTileButton2
            // 
            this.bunifuTileButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuTileButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bunifuTileButton2.color = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bunifuTileButton2.colorActive = System.Drawing.Color.Blue;
            this.bunifuTileButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuTileButton2.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton2.Image = null;
            this.bunifuTileButton2.ImagePosition = 17;
            this.bunifuTileButton2.ImageZoom = 50;
            this.bunifuTileButton2.LabelPosition = 25;
            this.bunifuTileButton2.LabelText = "Sửa";
            this.bunifuTileButton2.Location = new System.Drawing.Point(19, 532);
            this.bunifuTileButton2.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuTileButton2.Name = "bunifuTileButton2";
            this.bunifuTileButton2.Size = new System.Drawing.Size(285, 30);
            this.bunifuTileButton2.TabIndex = 21;
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(875, 660);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnl_customerInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerForm";
            this.Text = "CustomerForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnl_customerInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_customerInfo;
        private MaterialSkin.Controls.MaterialSingleLineTextField mateneTextField1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_SDT;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.TextBox txt_DiaChi;
        private System.Windows.Forms.TextBox txt_HoTen;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton2;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton1;
        private Bunifu.Framework.UI.BunifuTileButton btn_TraHang;
    }
}