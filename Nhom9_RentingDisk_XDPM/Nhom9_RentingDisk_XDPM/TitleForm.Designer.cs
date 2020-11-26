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
            this.txt_TimKienTitle = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_DatHang = new Bunifu.Framework.UI.BunifuTileButton();
            this.btn_DatLaiGiaThue = new Bunifu.Framework.UI.BunifuTileButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_TimKienTitle
            // 
            this.txt_TimKienTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_TimKienTitle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_TimKienTitle.Depth = 0;
            this.txt_TimKienTitle.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TimKienTitle.Hint = "";
            this.txt_TimKienTitle.Location = new System.Drawing.Point(39, 9);
            this.txt_TimKienTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_TimKienTitle.Name = "txt_TimKienTitle";
            this.txt_TimKienTitle.PasswordChar = '\0';
            this.txt_TimKienTitle.SelectedText = "";
            this.txt_TimKienTitle.SelectionLength = 0;
            this.txt_TimKienTitle.SelectionStart = 0;
            this.txt_TimKienTitle.Size = new System.Drawing.Size(625, 23);
            this.txt_TimKienTitle.TabIndex = 14;
            this.txt_TimKienTitle.Text = "Search Title";
            this.txt_TimKienTitle.UseSystemPasswordChar = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(12, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(858, 611);
            this.panel1.TabIndex = 16;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(27, 30);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(828, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(851, 20);
            this.textBox1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pictureBox2.Image = global::Nhom9_RentingDisk_XDPM.Properties.Resources.search;
            this.pictureBox2.Location = new System.Drawing.Point(12, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(21, 21);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
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
            this.btn_Back.Location = new System.Drawing.Point(12, 658);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(150, 32);
            this.btn_Back.TabIndex = 6;
            this.btn_Back.Text = "          Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // btn_DatHang
            // 
            this.btn_DatHang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_DatHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_DatHang.color = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_DatHang.colorActive = System.Drawing.Color.Blue;
            this.btn_DatHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_DatHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DatHang.ForeColor = System.Drawing.Color.White;
            this.btn_DatHang.Image = null;
            this.btn_DatHang.ImagePosition = 17;
            this.btn_DatHang.ImageZoom = 50;
            this.btn_DatHang.LabelPosition = 22;
            this.btn_DatHang.LabelText = "Đặt hàng";
            this.btn_DatHang.Location = new System.Drawing.Point(669, 7);
            this.btn_DatHang.Margin = new System.Windows.Forms.Padding(2);
            this.btn_DatHang.Name = "btn_DatHang";
            this.btn_DatHang.Size = new System.Drawing.Size(198, 23);
            this.btn_DatHang.TabIndex = 19;
            this.btn_DatHang.Click += new System.EventHandler(this.btn_DatHang_Click_1);
            // 
            // btn_DatLaiGiaThue
            // 
            this.btn_DatLaiGiaThue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_DatLaiGiaThue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_DatLaiGiaThue.color = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_DatLaiGiaThue.colorActive = System.Drawing.Color.Blue;
            this.btn_DatLaiGiaThue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_DatLaiGiaThue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DatLaiGiaThue.ForeColor = System.Drawing.Color.White;
            this.btn_DatLaiGiaThue.Image = null;
            this.btn_DatLaiGiaThue.ImagePosition = 20;
            this.btn_DatLaiGiaThue.ImageZoom = 50;
            this.btn_DatLaiGiaThue.LabelPosition = 28;
            this.btn_DatLaiGiaThue.LabelText = "Trả hàng";
            this.btn_DatLaiGiaThue.Location = new System.Drawing.Point(171, 658);
            this.btn_DatLaiGiaThue.Margin = new System.Windows.Forms.Padding(6);
            this.btn_DatLaiGiaThue.Name = "btn_DatLaiGiaThue";
            this.btn_DatLaiGiaThue.Size = new System.Drawing.Size(699, 32);
            this.btn_DatLaiGiaThue.TabIndex = 20;
            this.btn_DatLaiGiaThue.Click += new System.EventHandler(this.btn_DatLaiGiaThue_Click);
            // 
            // TitleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(882, 699);
            this.Controls.Add(this.btn_DatLaiGiaThue);
            this.Controls.Add(this.btn_DatHang);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txt_TimKienTitle);
            this.Controls.Add(this.btn_Back);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TitleForm";
            this.Text = "TitleForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Back;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_TimKienTitle;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private Bunifu.Framework.UI.BunifuTileButton btn_DatHang;
        private Bunifu.Framework.UI.BunifuTileButton btn_DatLaiGiaThue;
    }
}