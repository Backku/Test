using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
namespace WindowsFormsApp1
{
    public partial class Form10 : Form
    {
        public string PhoneNumber { get; private set; }
        public Form10()
        {
            InitializeComponent();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            // Lấy thông tin từ ô nhập số điện thoại
            string phoneNumber = textBox1.Text;

            // Kiểm tra tính hợp lệ của số điện thoại
            if (!IsValidPhoneNumber(phoneNumber))
            {
                MessageBox.Show("Số điện thoại không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Gán số điện thoại và đóng form
            PhoneNumber = phoneNumber;
            this.Close();
        }

        private bool IsValidPhoneNumber(string phoneNumber)
        {
            // Kiểm tra tính hợp lệ của số điện thoại, định dạng số điện thoại có thể được tùy chỉnh dựa trên nhu cầu cụ thể
            return Regex.IsMatch(phoneNumber, @"^\d{10}$"); // Đây là một ví dụ đơn giản, số điện thoại có 10 chữ số
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            // Đóng form khi người dùng nhấn nút "Thoát"
            this.Close();
        }
    }
}
