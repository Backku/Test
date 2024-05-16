namespace WindowsFormsApp1
{
    partial class Form8
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMakh = new System.Windows.Forms.TextBox();
            this.txtHovaten = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSdt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTensan = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLichdatsan = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtThanhtoan = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(803, 583);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(961, 480);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(106, 45);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa ";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(836, 548);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(106, 45);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(836, 480);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(106, 45);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(833, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mã khách hàng";
            // 
            // txtMakh
            // 
            this.txtMakh.Location = new System.Drawing.Point(836, 31);
            this.txtMakh.Multiline = true;
            this.txtMakh.Name = "txtMakh";
            this.txtMakh.Size = new System.Drawing.Size(231, 31);
            this.txtMakh.TabIndex = 6;
            // 
            // txtHovaten
            // 
            this.txtHovaten.Location = new System.Drawing.Point(836, 94);
            this.txtHovaten.Multiline = true;
            this.txtHovaten.Name = "txtHovaten";
            this.txtHovaten.Size = new System.Drawing.Size(231, 31);
            this.txtHovaten.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(833, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Họ và tên";
            // 
            // txtSdt
            // 
            this.txtSdt.Location = new System.Drawing.Point(836, 162);
            this.txtSdt.Multiline = true;
            this.txtSdt.Name = "txtSdt";
            this.txtSdt.Size = new System.Drawing.Size(231, 31);
            this.txtSdt.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(833, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Số điện thoại";
            // 
            // txtDiachi
            // 
            this.txtDiachi.Location = new System.Drawing.Point(836, 225);
            this.txtDiachi.Multiline = true;
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(231, 31);
            this.txtDiachi.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(833, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Địa chỉ";
            // 
            // txtTensan
            // 
            this.txtTensan.Location = new System.Drawing.Point(836, 289);
            this.txtTensan.Multiline = true;
            this.txtTensan.Name = "txtTensan";
            this.txtTensan.Size = new System.Drawing.Size(231, 31);
            this.txtTensan.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(833, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Tên sân";
            // 
            // txtLichdatsan
            // 
            this.txtLichdatsan.Location = new System.Drawing.Point(836, 352);
            this.txtLichdatsan.Multiline = true;
            this.txtLichdatsan.Name = "txtLichdatsan";
            this.txtLichdatsan.Size = new System.Drawing.Size(231, 31);
            this.txtLichdatsan.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(833, 333);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Lịch đặt sân";
            // 
            // txtThanhtoan
            // 
            this.txtThanhtoan.Location = new System.Drawing.Point(836, 414);
            this.txtThanhtoan.Multiline = true;
            this.txtThanhtoan.Name = "txtThanhtoan";
            this.txtThanhtoan.Size = new System.Drawing.Size(231, 31);
            this.txtThanhtoan.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(833, 395);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "Phương thức thanh toán";
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 609);
            this.Controls.Add(this.txtThanhtoan);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtLichdatsan);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTensan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDiachi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSdt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtHovaten);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMakh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.listView1);
            this.Name = "Form8";
            this.Text = "Quản lý khách hàng";
            this.Load += new System.EventHandler(this.Form8_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMakh;
        private System.Windows.Forms.TextBox txtHovaten;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSdt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTensan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLichdatsan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtThanhtoan;
        private System.Windows.Forms.Label label7;
    }
}