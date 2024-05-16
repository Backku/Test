using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        SqlConnection con = new SqlConnection($@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={Application.StartupPath}\QLSanBong.mdf;Integrated Security=True;Connect Timeout=30");
        DataTable dt = new DataTable();
        public Form3()
        {
            InitializeComponent();
            txtMatkhau.UseSystemPasswordChar = true; // Ẩn mật khẩu bằng ký tự '*'
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtTaikhoan.Text;
            string password = txtMatkhau.Text;
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Vui lòng nhập tên người dùng và mật khẩu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (CheckLogin(username, password))
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Form7 form7 = new Form7(this); // Truyền Form3 hiện tại vào Form7
                form7.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tên người dùng hoặc mật khẩu không đúng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void checkBoxLuumk_CheckedChanged(object sender, EventArgs e)
        {
            // Thực hiện lưu mật khẩu vào cơ sở dữ liệu hoặc nơi lưu trữ khác
            string username = txtTaikhoan.Text;
            string password = txtMatkhau.Text;

            if (checkBoxLuumk.Checked && !string.IsNullOrWhiteSpace(username) && !string.IsNullOrWhiteSpace(password))
            {
                // Thực hiện lưu mật khẩu ở đây
                MessageBox.Show("Mật khẩu đã được lưu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private bool CheckLogin(string username, string password)
        {
            // Thực hiện kiểm tra đăng nhập ở đây
            // Trong ví dụ này, mật khẩu được giả định là "admin"
            return username == "admin" && password == "admin";
        }
    }
}
