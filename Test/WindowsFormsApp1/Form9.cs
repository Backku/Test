using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
            txtMatkhau.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Lấy thông tin từ các ô nhập liệu
            string username = txtTaikhoan.Text;
            string password = txtMatkhau.Text;
            string phoneNumber = txtSodienthoai.Text;

            // Kiểm tra tính hợp lệ của thông tin
            if (!IsValidUsername(username))
            {
                MessageBox.Show("Tên người dùng không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!IsValidPassword(password))
            {
                MessageBox.Show("Mật khẩu không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!IsValidPhoneNumber(phoneNumber))
            {
                MessageBox.Show("Số điện thoại không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Thực hiện việc tạo tài khoản
            // Trong ví dụ này, chúng ta chỉ hiển thị thông báo tạo tài khoản thành công
            MessageBox.Show("Tạo tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Sau khi tạo tài khoản thành công, bạn có thể thêm mã lưu thông tin tài khoản vào cơ sở dữ liệu ở đây
            // Ví dụ:
            // SaveAccountInfo(username, password, phoneNumber);

            // Đóng form tạo tài khoản
            this.Close();
        }

        private bool IsValidUsername(string username)
        {
            // Kiểm tra tính hợp lệ của tên người dùng, ví dụ: không được chứa ký tự đặc biệt, độ dài tối thiểu là 6 ký tự, v.v.
            return !string.IsNullOrWhiteSpace(username) && username.Length >= 6;
        }

        private bool IsValidPassword(string password)
        {
            // Kiểm tra tính hợp lệ của mật khẩu, ví dụ: độ dài tối thiểu là 6 ký tự, phải chứa ít nhất một ký tự số và một ký tự chữ cái, v.v.
            return !string.IsNullOrWhiteSpace(password) && password.Length >= 6 && Regex.IsMatch(password, @"^(?=.*[a-zA-Z])(?=.*\d).{6,}$");
        }

        private bool IsValidPhoneNumber(string phoneNumber)
        {
            // Kiểm tra tính hợp lệ của số điện thoại, định dạng số điện thoại có thể được tùy chỉnh dựa trên nhu cầu cụ thể
            return !string.IsNullOrWhiteSpace(phoneNumber) && Regex.IsMatch(phoneNumber, @"^\d{10}$"); // Đây là một ví dụ đơn giản, số điện thoại có 10 chữ số
        }
    }
}
