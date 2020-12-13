namespace Nhom9_RentingDisk_XDPM
{
    partial class ReportCustomerForm
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
            this.lst_DateExpired = new System.Windows.Forms.ListView();
            this.listView3 = new System.Windows.Forms.ListView();
            this.btn_AllCustomer = new System.Windows.Forms.Button();
            this.btn_CustomerDiskExpired = new System.Windows.Forms.Button();
            this.lst_ReportCustomer = new System.Windows.Forms.ListView();
            this.btn_AllCustomerDebtCharge = new System.Windows.Forms.Button();
            this.btn_print = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_print)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_print);
            this.panel1.Controls.Add(this.lst_ReportCustomer);
            this.panel1.Controls.Add(this.btn_AllCustomerDebtCharge);
            this.panel1.Controls.Add(this.btn_CustomerDiskExpired);
            this.panel1.Controls.Add(this.btn_AllCustomer);
            this.panel1.Controls.Add(this.listView3);
            this.panel1.Controls.Add(this.lst_DateExpired);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 448);
            this.panel1.TabIndex = 0;
            // 
            // lst_DateExpired
            // 
            this.lst_DateExpired.HideSelection = false;
            this.lst_DateExpired.Location = new System.Drawing.Point(522, 128);
            this.lst_DateExpired.Name = "lst_DateExpired";
            this.lst_DateExpired.Size = new System.Drawing.Size(256, 97);
            this.lst_DateExpired.TabIndex = 1;
            this.lst_DateExpired.UseCompatibleStateImageBehavior = false;
            // 
            // listView3
            // 
            this.listView3.HideSelection = false;
            this.listView3.Location = new System.Drawing.Point(522, 274);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(256, 97);
            this.listView3.TabIndex = 2;
            this.listView3.UseCompatibleStateImageBehavior = false;
            // 
            // btn_AllCustomer
            // 
            this.btn_AllCustomer.BackColor = System.Drawing.Color.White;
            this.btn_AllCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AllCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AllCustomer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_AllCustomer.Location = new System.Drawing.Point(13, 11);
            this.btn_AllCustomer.Name = "btn_AllCustomer";
            this.btn_AllCustomer.Size = new System.Drawing.Size(129, 57);
            this.btn_AllCustomer.TabIndex = 3;
            this.btn_AllCustomer.Text = "1. Tất cả khách hàng";
            this.btn_AllCustomer.UseVisualStyleBackColor = false;
            // 
            // btn_CustomerDiskExpired
            // 
            this.btn_CustomerDiskExpired.BackColor = System.Drawing.Color.White;
            this.btn_CustomerDiskExpired.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CustomerDiskExpired.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CustomerDiskExpired.Location = new System.Drawing.Point(150, 11);
            this.btn_CustomerDiskExpired.Name = "btn_CustomerDiskExpired";
            this.btn_CustomerDiskExpired.Size = new System.Drawing.Size(165, 57);
            this.btn_CustomerDiskExpired.TabIndex = 4;
            this.btn_CustomerDiskExpired.Text = "2. Khách hàng có đĩa quá hạn";
            this.btn_CustomerDiskExpired.UseVisualStyleBackColor = false;
            // 
            // lst_ReportCustomer
            // 
            this.lst_ReportCustomer.HideSelection = false;
            this.lst_ReportCustomer.Location = new System.Drawing.Point(13, 99);
            this.lst_ReportCustomer.Name = "lst_ReportCustomer";
            this.lst_ReportCustomer.Size = new System.Drawing.Size(490, 272);
            this.lst_ReportCustomer.TabIndex = 6;
            this.lst_ReportCustomer.UseCompatibleStateImageBehavior = false;
            // 
            // btn_AllCustomerDebtCharge
            // 
            this.btn_AllCustomerDebtCharge.BackColor = System.Drawing.Color.White;
            this.btn_AllCustomerDebtCharge.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AllCustomerDebtCharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AllCustomerDebtCharge.Location = new System.Drawing.Point(321, 11);
            this.btn_AllCustomerDebtCharge.Name = "btn_AllCustomerDebtCharge";
            this.btn_AllCustomerDebtCharge.Size = new System.Drawing.Size(165, 57);
            this.btn_AllCustomerDebtCharge.TabIndex = 4;
            this.btn_AllCustomerDebtCharge.Text = "3. Tất cả khách hàng đang có phí nợ ";
            this.btn_AllCustomerDebtCharge.UseVisualStyleBackColor = false;
            // 
            // btn_print
            // 
            this.btn_print.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_print.Image = global::Nhom9_RentingDisk_XDPM.Properties.Resources.print;
            this.btn_print.Location = new System.Drawing.Point(722, 377);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(56, 49);
            this.btn_print.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_print.TabIndex = 7;
            this.btn_print.TabStop = false;
            // 
            // ReportCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReportCustomerForm";
            this.ShowIcon = false;
            this.Text = "ReportCustomerForm";
            this.TransparencyKey = System.Drawing.Color.White;
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_print)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.ListView lst_DateExpired;
        private System.Windows.Forms.Button btn_CustomerDiskExpired;
        private System.Windows.Forms.Button btn_AllCustomer;
        private System.Windows.Forms.ListView lst_ReportCustomer;
        private System.Windows.Forms.Button btn_AllCustomerDebtCharge;
        private System.Windows.Forms.PictureBox btn_print;
    }
}