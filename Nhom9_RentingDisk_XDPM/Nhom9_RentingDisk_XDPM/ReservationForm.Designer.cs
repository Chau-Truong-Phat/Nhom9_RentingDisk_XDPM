namespace Nhom9_RentingDisk_XDPM
{
    partial class ReservationForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_Search_KhachHang = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_DatHang = new Bunifu.Framework.UI.BunifuTileButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Location = new System.Drawing.Point(12, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 395);
            this.panel1.TabIndex = 15;
            // 
            // txt_Search_KhachHang
            // 
            this.txt_Search_KhachHang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Search_KhachHang.Depth = 0;
            this.txt_Search_KhachHang.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Search_KhachHang.Hint = "";
            this.txt_Search_KhachHang.Location = new System.Drawing.Point(38, 12);
            this.txt_Search_KhachHang.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_Search_KhachHang.Name = "txt_Search_KhachHang";
            this.txt_Search_KhachHang.PasswordChar = '\0';
            this.txt_Search_KhachHang.SelectedText = "";
            this.txt_Search_KhachHang.SelectionLength = 0;
            this.txt_Search_KhachHang.SelectionStart = 0;
            this.txt_Search_KhachHang.Size = new System.Drawing.Size(596, 23);
            this.txt_Search_KhachHang.TabIndex = 16;
            this.txt_Search_KhachHang.Text = "Nhập ID hoặc số điện thoại khách hàng";
            this.txt_Search_KhachHang.UseSystemPasswordChar = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pictureBox1.Image = global::Nhom9_RentingDisk_XDPM.Properties.Resources.search;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(21, 21);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // btn_DatHang
            // 
            this.btn_DatHang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
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
            this.btn_DatHang.Location = new System.Drawing.Point(639, 11);
            this.btn_DatHang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_DatHang.Name = "btn_DatHang";
            this.btn_DatHang.Size = new System.Drawing.Size(150, 23);
            this.btn_DatHang.TabIndex = 18;
            // 
            // ReservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_DatHang);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_Search_KhachHang);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReservationForm";
            this.Text = "ReservationForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_Search_KhachHang;
        private Bunifu.Framework.UI.BunifuTileButton btn_DatHang;
    }
}