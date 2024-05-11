namespace WindowsFormsApp1
{
    partial class Form4
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnNhaplai = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXuat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.txtTensan = new System.Windows.Forms.TextBox();
            this.txtMasan = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.comboBoxTensanpham = new System.Windows.Forms.ComboBox();
            this.comboBoxMathang = new System.Windows.Forms.ComboBox();
            this.txtSoluong = new System.Windows.Forms.TextBox();
            this.txtGiasan = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listViewDichvu = new System.Windows.Forms.ListView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnTinhtoan = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnThanhtoan = new System.Windows.Forms.Button();
            this.txtTienthanhtoan = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTiencoc = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTongthanhtoan = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTiensan = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTiendichvu = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(419, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "DỊCH VỤ ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnNhaplai);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.btnXuat);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.txtTensan);
            this.groupBox1.Controls.Add(this.txtMasan);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.comboBoxTensanpham);
            this.groupBox1.Controls.Add(this.comboBoxMathang);
            this.groupBox1.Controls.Add(this.txtSoluong);
            this.groupBox1.Controls.Add(this.txtGiasan);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 60);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(565, 239);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dịch vụ";
            // 
            // btnNhaplai
            // 
            this.btnNhaplai.Location = new System.Drawing.Point(215, 189);
            this.btnNhaplai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNhaplai.Name = "btnNhaplai";
            this.btnNhaplai.Size = new System.Drawing.Size(131, 34);
            this.btnNhaplai.TabIndex = 20;
            this.btnNhaplai.TabStop = false;
            this.btnNhaplai.Text = "Nhập lại";
            this.btnNhaplai.UseVisualStyleBackColor = true;
            this.btnNhaplai.Click += new System.EventHandler(this.btnNhaplai_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(42, 192);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(131, 34);
            this.btnSua.TabIndex = 19;
            this.btnSua.TabStop = false;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXuat
            // 
            this.btnXuat.Location = new System.Drawing.Point(414, 154);
            this.btnXuat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.Size = new System.Drawing.Size(131, 72);
            this.btnXuat.TabIndex = 18;
            this.btnXuat.TabStop = false;
            this.btnXuat.Text = "Xuất";
            this.btnXuat.UseVisualStyleBackColor = true;
            this.btnXuat.Click += new System.EventHandler(this.btnXuat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(215, 151);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(131, 34);
            this.btnXoa.TabIndex = 17;
            this.btnXoa.TabStop = false;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // txtTensan
            // 
            this.txtTensan.Location = new System.Drawing.Point(405, 66);
            this.txtTensan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTensan.Name = "txtTensan";
            this.txtTensan.Size = new System.Drawing.Size(153, 22);
            this.txtTensan.TabIndex = 16;
            this.txtTensan.TabStop = false;
            // 
            // txtMasan
            // 
            this.txtMasan.Location = new System.Drawing.Point(405, 19);
            this.txtMasan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMasan.Name = "txtMasan";
            this.txtMasan.Size = new System.Drawing.Size(153, 22);
            this.txtMasan.TabIndex = 14;
            this.txtMasan.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(314, 23);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 16);
            this.label12.TabIndex = 13;
            this.label12.Text = "Mã sân";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(315, 70);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 16);
            this.label13.TabIndex = 15;
            this.label13.Text = "Tên sân";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(42, 151);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(131, 34);
            this.btnThem.TabIndex = 8;
            this.btnThem.TabStop = false;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // comboBoxTensanpham
            // 
            this.comboBoxTensanpham.FormattingEnabled = true;
            this.comboBoxTensanpham.Location = new System.Drawing.Point(111, 66);
            this.comboBoxTensanpham.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxTensanpham.Name = "comboBoxTensanpham";
            this.comboBoxTensanpham.Size = new System.Drawing.Size(173, 24);
            this.comboBoxTensanpham.TabIndex = 7;
            this.comboBoxTensanpham.TabStop = false;
            // 
            // comboBoxMathang
            // 
            this.comboBoxMathang.FormattingEnabled = true;
            this.comboBoxMathang.Location = new System.Drawing.Point(111, 19);
            this.comboBoxMathang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxMathang.Name = "comboBoxMathang";
            this.comboBoxMathang.Size = new System.Drawing.Size(173, 24);
            this.comboBoxMathang.TabIndex = 6;
            this.comboBoxMathang.TabStop = false;
            this.comboBoxMathang.SelectedIndexChanged += new System.EventHandler(this.comboBoxMathang_SelectedIndexChanged);
            // 
            // txtSoluong
            // 
            this.txtSoluong.Location = new System.Drawing.Point(111, 120);
            this.txtSoluong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSoluong.Name = "txtSoluong";
            this.txtSoluong.Size = new System.Drawing.Size(173, 22);
            this.txtSoluong.TabIndex = 5;
            this.txtSoluong.TabStop = false;
            // 
            // txtGiasan
            // 
            this.txtGiasan.Location = new System.Drawing.Point(405, 117);
            this.txtGiasan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGiasan.Name = "txtGiasan";
            this.txtGiasan.Size = new System.Drawing.Size(153, 22);
            this.txtGiasan.TabIndex = 4;
            this.txtGiasan.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Số lượng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(316, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Giá sân";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên sản phẩm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mặt hàng";
            // 
            // listViewDichvu
            // 
            this.listViewDichvu.GridLines = true;
            this.listViewDichvu.HideSelection = false;
            this.listViewDichvu.Location = new System.Drawing.Point(12, 306);
            this.listViewDichvu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listViewDichvu.Name = "listViewDichvu";
            this.listViewDichvu.Size = new System.Drawing.Size(1018, 258);
            this.listViewDichvu.TabIndex = 12;
            this.listViewDichvu.UseCompatibleStateImageBehavior = false;
            this.listViewDichvu.View = System.Windows.Forms.View.Details;
            this.listViewDichvu.SelectedIndexChanged += new System.EventHandler(this.listViewDichvu_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnTinhtoan);
            this.groupBox3.Controls.Add(this.btnReset);
            this.groupBox3.Controls.Add(this.btnThanhtoan);
            this.groupBox3.Controls.Add(this.txtTienthanhtoan);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.txtTiencoc);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txtTongthanhtoan);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtTiensan);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtTiendichvu);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(595, 60);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(435, 239);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thanh toán";
            // 
            // btnTinhtoan
            // 
            this.btnTinhtoan.Location = new System.Drawing.Point(19, 192);
            this.btnTinhtoan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTinhtoan.Name = "btnTinhtoan";
            this.btnTinhtoan.Size = new System.Drawing.Size(131, 34);
            this.btnTinhtoan.TabIndex = 24;
            this.btnTinhtoan.TabStop = false;
            this.btnTinhtoan.Text = "Tính toán";
            this.btnTinhtoan.UseVisualStyleBackColor = true;
            this.btnTinhtoan.Click += new System.EventHandler(this.btnTinhtoan_Click_1);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(293, 192);
            this.btnReset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(131, 34);
            this.btnReset.TabIndex = 23;
            this.btnReset.TabStop = false;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnThanhtoan
            // 
            this.btnThanhtoan.Location = new System.Drawing.Point(156, 192);
            this.btnThanhtoan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThanhtoan.Name = "btnThanhtoan";
            this.btnThanhtoan.Size = new System.Drawing.Size(131, 34);
            this.btnThanhtoan.TabIndex = 13;
            this.btnThanhtoan.TabStop = false;
            this.btnThanhtoan.Text = "Thanh Toán";
            this.btnThanhtoan.UseVisualStyleBackColor = true;
            this.btnThanhtoan.Click += new System.EventHandler(this.btnThanhtoan_Click);
            // 
            // txtTienthanhtoan
            // 
            this.txtTienthanhtoan.Location = new System.Drawing.Point(137, 148);
            this.txtTienthanhtoan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTienthanhtoan.Name = "txtTienthanhtoan";
            this.txtTienthanhtoan.Size = new System.Drawing.Size(287, 22);
            this.txtTienthanhtoan.TabIndex = 22;
            this.txtTienthanhtoan.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 151);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 16);
            this.label11.TabIndex = 21;
            this.label11.Text = "Tiền thanh toán";
            // 
            // txtTiencoc
            // 
            this.txtTiencoc.Location = new System.Drawing.Point(137, 121);
            this.txtTiencoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTiencoc.Name = "txtTiencoc";
            this.txtTiencoc.Size = new System.Drawing.Size(287, 22);
            this.txtTiencoc.TabIndex = 20;
            this.txtTiencoc.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 123);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 16);
            this.label10.TabIndex = 19;
            this.label10.Text = "Tiền cọc";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtTongthanhtoan
            // 
            this.txtTongthanhtoan.Location = new System.Drawing.Point(137, 92);
            this.txtTongthanhtoan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTongthanhtoan.Name = "txtTongthanhtoan";
            this.txtTongthanhtoan.Size = new System.Drawing.Size(287, 22);
            this.txtTongthanhtoan.TabIndex = 18;
            this.txtTongthanhtoan.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 95);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 16);
            this.label9.TabIndex = 17;
            this.label9.Text = "Tổng thanh toán";
            // 
            // txtTiensan
            // 
            this.txtTiensan.Location = new System.Drawing.Point(137, 64);
            this.txtTiensan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTiensan.Name = "txtTiensan";
            this.txtTiensan.Size = new System.Drawing.Size(287, 22);
            this.txtTiensan.TabIndex = 16;
            this.txtTiensan.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "Tiền sân";
            // 
            // txtTiendichvu
            // 
            this.txtTiendichvu.Location = new System.Drawing.Point(137, 36);
            this.txtTiendichvu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTiendichvu.Name = "txtTiendichvu";
            this.txtTiendichvu.Size = new System.Drawing.Size(287, 22);
            this.txtTiendichvu.TabIndex = 14;
            this.txtTiendichvu.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Tiền dịch vụ";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 575);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listViewDichvu);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form4";
            this.Text = "Dịch vụ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxTensanpham;
        private System.Windows.Forms.ComboBox comboBoxMathang;
        private System.Windows.Forms.TextBox txtSoluong;
        private System.Windows.Forms.TextBox txtGiasan;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ListView listViewDichvu;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtTiendichvu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnThanhtoan;
        private System.Windows.Forms.TextBox txtTienthanhtoan;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTiencoc;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTongthanhtoan;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTiensan;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMasan;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnXuat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.TextBox txtTensan;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnTinhtoan;
        private System.Windows.Forms.Button btnNhaplai;
        private System.Windows.Forms.Button btnSua;
    }
}