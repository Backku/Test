using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form7 : Form
    {
        private Form3 loginForm;
        public Form7(Form3 loginForm)
        {
            InitializeComponent();
            this.loginForm = loginForm;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            // Đóng form hiện tại
            this.Close();

            // Hiển thị form đăng nhập
            loginForm.Show();
        }

        private void btnTimdatsan_Click(object sender, EventArgs e)
        {
            var form1 = new Form1();
            form1.ShowDialog();
        }

        private void btnDichvu_Click(object sender, EventArgs e)
        {
            var form4 = new Form4();
            form4.ShowDialog();
        }

        private void btnQuanlysanbong_Click(object sender, EventArgs e)
        {
            var form6 = new Form6();
            form6.ShowDialog();
        }

        private void btnQuanlyvatu_Click(object sender, EventArgs e)
        {
            var form5 = new Form5();
            form5.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form8 = new Form8();
            form8.ShowDialog();
        }
    }
}
