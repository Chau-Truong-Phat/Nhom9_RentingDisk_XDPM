namespace Nhom9_RentingDisk_XDPM
{
    partial class ReportTitleForm
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
            this.btn_back = new System.Windows.Forms.Button();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmb_ = new System.Windows.Forms.ComboBox();
            this.txt_Timkiem1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_InThongKe = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.txt_Timkiem2 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txt_Timkiem3 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_InThongKe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.btn_back);
            this.panel1.Controls.Add(this.materialLabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 38);
            this.panel1.TabIndex = 23;
            // 
            // btn_back
            // 
            this.btn_back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_back.FlatAppearance.BorderSize = 0;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_back.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_back.Location = new System.Drawing.Point(3, 3);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(150, 32);
            this.btn_back.TabIndex = 20;
            this.btn_back.Text = "          Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(303, 9);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(144, 18);
            this.materialLabel1.TabIndex = 17;
            this.materialLabel1.Text = "Báo cáo khách hàng";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btn_InThongKe);
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.cmb_);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Location = new System.Drawing.Point(0, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 408);
            this.panel2.TabIndex = 24;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.txt_Timkiem1);
            this.groupBox1.Location = new System.Drawing.Point(3, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(493, 374);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách khách hàng";
            // 
            // cmb_
            // 
            this.cmb_.FormattingEnabled = true;
            this.cmb_.Location = new System.Drawing.Point(13, 4);
            this.cmb_.Name = "cmb_";
            this.cmb_.Size = new System.Drawing.Size(483, 21);
            this.cmb_.TabIndex = 1;
            // 
            // txt_Timkiem1
            // 
            this.txt_Timkiem1.Depth = 0;
            this.txt_Timkiem1.Hint = "";
            this.txt_Timkiem1.Location = new System.Drawing.Point(9, 23);
            this.txt_Timkiem1.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_Timkiem1.Name = "txt_Timkiem1";
            this.txt_Timkiem1.PasswordChar = '\0';
            this.txt_Timkiem1.SelectedText = "";
            this.txt_Timkiem1.SelectionLength = 0;
            this.txt_Timkiem1.SelectionStart = 0;
            this.txt_Timkiem1.Size = new System.Drawing.Size(478, 23);
            this.txt_Timkiem1.TabIndex = 0;
            this.txt_Timkiem1.Text = "Tìm kiếm ";
            this.txt_Timkiem1.UseSystemPasswordChar = false;
            this.txt_Timkiem1.Click += new System.EventHandler(this.materialSingleLineTextField1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(486, 315);
            this.dataGridView1.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_Timkiem2);
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Location = new System.Drawing.Point(497, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(300, 194);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách tiêu đề trễ hạn ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_Timkiem3);
            this.groupBox3.Controls.Add(this.dataGridView3);
            this.groupBox3.Location = new System.Drawing.Point(497, 231);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(300, 174);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Phí trễ hạn";
            // 
            // btn_InThongKe
            // 
            this.btn_InThongKe.Image = global::Nhom9_RentingDisk_XDPM.Properties.Resources.print_filled_100px;
            this.btn_InThongKe.Location = new System.Drawing.Point(503, 0);
            this.btn_InThongKe.Name = "btn_InThongKe";
            this.btn_InThongKe.Size = new System.Drawing.Size(26, 25);
            this.btn_InThongKe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_InThongKe.TabIndex = 4;
            this.btn_InThongKe.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(535, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "In thống kê";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(7, 53);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(287, 135);
            this.dataGridView2.TabIndex = 0;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(7, 49);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(287, 120);
            this.dataGridView3.TabIndex = 0;
            // 
            // txt_Timkiem2
            // 
            this.txt_Timkiem2.Depth = 0;
            this.txt_Timkiem2.Hint = "";
            this.txt_Timkiem2.Location = new System.Drawing.Point(7, 24);
            this.txt_Timkiem2.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_Timkiem2.Name = "txt_Timkiem2";
            this.txt_Timkiem2.PasswordChar = '\0';
            this.txt_Timkiem2.SelectedText = "";
            this.txt_Timkiem2.SelectionLength = 0;
            this.txt_Timkiem2.SelectionStart = 0;
            this.txt_Timkiem2.Size = new System.Drawing.Size(284, 23);
            this.txt_Timkiem2.TabIndex = 1;
            this.txt_Timkiem2.Text = "Tìm kiếm ";
            this.txt_Timkiem2.UseSystemPasswordChar = false;
            // 
            // txt_Timkiem3
            // 
            this.txt_Timkiem3.Depth = 0;
            this.txt_Timkiem3.Hint = "";
            this.txt_Timkiem3.Location = new System.Drawing.Point(6, 20);
            this.txt_Timkiem3.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_Timkiem3.Name = "txt_Timkiem3";
            this.txt_Timkiem3.PasswordChar = '\0';
            this.txt_Timkiem3.SelectedText = "";
            this.txt_Timkiem3.SelectionLength = 0;
            this.txt_Timkiem3.SelectionStart = 0;
            this.txt_Timkiem3.Size = new System.Drawing.Size(288, 23);
            this.txt_Timkiem3.TabIndex = 1;
            this.txt_Timkiem3.Text = "Tìm kiếm ";
            this.txt_Timkiem3.UseSystemPasswordChar = false;
            // 
            // ReportTitleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReportTitleForm";
            this.Text = "ReportTitleForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_InThongKe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_back;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cmb_;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_Timkiem1;
        private System.Windows.Forms.PictureBox btn_InThongKe;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_Timkiem2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_Timkiem3;
    }
}