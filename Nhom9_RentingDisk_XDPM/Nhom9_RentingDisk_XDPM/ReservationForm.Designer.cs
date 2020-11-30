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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_numberPhone = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.txt_customerName = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_diskTitle = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.btn_reservation = new Bunifu.Framework.UI.BunifuTileButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.cbx_disk_quantity = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_search_disk = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_back = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Số điện thoại";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Tên khách hàng";
            // 
            // txt_numberPhone
            // 
            this.txt_numberPhone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_numberPhone.BorderColor = System.Drawing.Color.SeaGreen;
            this.txt_numberPhone.Location = new System.Drawing.Point(7, 104);
            this.txt_numberPhone.Name = "txt_numberPhone";
            this.txt_numberPhone.Size = new System.Drawing.Size(270, 20);
            this.txt_numberPhone.TabIndex = 15;
            // 
            // txt_customerName
            // 
            this.txt_customerName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_customerName.BorderColor = System.Drawing.Color.SeaGreen;
            this.txt_customerName.Location = new System.Drawing.Point(6, 58);
            this.txt_customerName.Name = "txt_customerName";
            this.txt_customerName.Size = new System.Drawing.Size(271, 20);
            this.txt_customerName.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Tựa CD/DVD";
            // 
            // txt_diskTitle
            // 
            this.txt_diskTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_diskTitle.BorderColor = System.Drawing.Color.SeaGreen;
            this.txt_diskTitle.Location = new System.Drawing.Point(7, 150);
            this.txt_diskTitle.Name = "txt_diskTitle";
            this.txt_diskTitle.Size = new System.Drawing.Size(271, 20);
            this.txt_diskTitle.TabIndex = 14;
            // 
            // btn_reservation
            // 
            this.btn_reservation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_reservation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_reservation.color = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_reservation.colorActive = System.Drawing.Color.Blue;
            this.btn_reservation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_reservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reservation.ForeColor = System.Drawing.Color.White;
            this.btn_reservation.Image = null;
            this.btn_reservation.ImagePosition = 20;
            this.btn_reservation.ImageZoom = 50;
            this.btn_reservation.LabelPosition = 35;
            this.btn_reservation.LabelText = "Đặt hàng";
            this.btn_reservation.Location = new System.Drawing.Point(6, 360);
            this.btn_reservation.Margin = new System.Windows.Forms.Padding(6);
            this.btn_reservation.Name = "btn_reservation";
            this.btn_reservation.Size = new System.Drawing.Size(271, 46);
            this.btn_reservation.TabIndex = 16;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(362, 9);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(67, 18);
            this.materialLabel1.TabIndex = 17;
            this.materialLabel1.Text = "Đặt hàng";
            // 
            // cbx_disk_quantity
            // 
            this.cbx_disk_quantity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbx_disk_quantity.FormattingEnabled = true;
            this.cbx_disk_quantity.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cbx_disk_quantity.Location = new System.Drawing.Point(7, 196);
            this.cbx_disk_quantity.Name = "cbx_disk_quantity";
            this.cbx_disk_quantity.Size = new System.Drawing.Size(271, 21);
            this.cbx_disk_quantity.TabIndex = 18;
            this.cbx_disk_quantity.Text = "1";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Số lượng đĩa";
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
            this.panel1.Size = new System.Drawing.Size(800, 38);
            this.panel1.TabIndex = 21;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txt_customerName);
            this.panel2.Controls.Add(this.btn_reservation);
            this.panel2.Controls.Add(this.cbx_disk_quantity);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txt_diskTitle);
            this.panel2.Controls.Add(this.txt_numberPhone);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(515, 38);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(285, 412);
            this.panel2.TabIndex = 22;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.txt_search_disk);
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Location = new System.Drawing.Point(0, 38);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(512, 412);
            this.panel3.TabIndex = 23;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(506, 374);
            this.dataGridView1.TabIndex = 0;
            // 
            // txt_search_disk
            // 
            this.txt_search_disk.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_search_disk.Depth = 0;
            this.txt_search_disk.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search_disk.Hint = "Hãy nhập mã đĩa ";
            this.txt_search_disk.Location = new System.Drawing.Point(29, 6);
            this.txt_search_disk.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_search_disk.Name = "txt_search_disk";
            this.txt_search_disk.PasswordChar = '\0';
            this.txt_search_disk.SelectedText = "";
            this.txt_search_disk.SelectionLength = 0;
            this.txt_search_disk.SelectionStart = 0;
            this.txt_search_disk.Size = new System.Drawing.Size(480, 23);
            this.txt_search_disk.TabIndex = 19;
            this.txt_search_disk.UseSystemPasswordChar = false;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(66, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "Thông tin đặt hàng";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pictureBox1.Image = global::Nhom9_RentingDisk_XDPM.Properties.Resources.search;
            this.pictureBox1.Location = new System.Drawing.Point(3, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // btn_back
            // 
            this.btn_back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
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
            this.btn_back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // ReservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReservationForm";
            this.Text = "ReservationForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txt_numberPhone;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txt_customerName;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txt_diskTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbx_disk_quantity;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private Bunifu.Framework.UI.BunifuTileButton btn_reservation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_search_disk;
        private System.Windows.Forms.Label label7;
    }
}