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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // Khởi tạo các cột của ListView
            listView1.View = View.Details;
            listView1.Columns.Add("Mã sân", 100, HorizontalAlignment.Center);
            listView1.Columns.Add("Tên sân", 100, HorizontalAlignment.Center);
            listView1.Columns.Add("Giá", 100, HorizontalAlignment.Center);
            listView1.Columns.Add("Trạng thái", 100, HorizontalAlignment.Center);
            listView1.Columns.Add("Mô tả", 150, HorizontalAlignment.Center);
            listView1.Columns.Add("Ý kiến khách hàng", 150, HorizontalAlignment.Center);
            listView1.Columns.Add("Đề xuất", 150, HorizontalAlignment.Center);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Thêm thông tin từ các TextBox vào ListView
            string[] row = {
                txtMasan.Text,
                txtTensan.Text,
                txtGia.Text,
                txtTrangthai.Text,
                txtMota.Text,
                txtYkien.Text,
                txtDexuat.Text
            };
            listView1.Items.Add(new ListViewItem(row));

            // Xóa dữ liệu trong các TextBox sau khi thêm
            ClearTextBoxes();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có hàng được chọn không
            if (listView1.SelectedItems.Count > 0)
            {
                // Lấy hàng được chọn
                ListViewItem item = listView1.SelectedItems[0];

                // Cập nhật thông tin của hàng được chọn với thông tin mới từ các TextBox
                item.SubItems[0].Text = txtMasan.Text;
                item.SubItems[1].Text = txtTensan.Text;
                item.SubItems[2].Text = txtGia.Text;
                item.SubItems[3].Text = txtTrangthai.Text;
                item.SubItems[4].Text = txtMota.Text;
                item.SubItems[5].Text = txtYkien.Text;
                item.SubItems[6].Text = txtDexuat.Text;

                // Xóa dữ liệu trong các TextBox sau khi cập nhật
                ClearTextBoxes();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng để sửa.");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có hàng được chọn không
            if (listView1.SelectedItems.Count > 0)
            {
                // Xóa hàng được chọn
                listView1.SelectedItems[0].Remove();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng để xóa.");
            }
        }
        private void ClearTextBoxes()
        {
            // Xóa dữ liệu trong các TextBox
            txtMasan.Clear();
            txtTensan.Clear();
            txtGia.Clear();
            txtTrangthai.Clear();
            txtMota.Clear();
            txtYkien.Clear();
            txtDexuat.Clear();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Kiểm tra xem có hàng được chọn không
            if (listView1.SelectedItems.Count > 0)
            {
                // Lấy thông tin từ dòng được chọn và hiển thị lên các TextBox
                ListViewItem item = listView1.SelectedItems[0];
                txtMasan.Text = item.SubItems[0].Text;
                txtTensan.Text = item.SubItems[1].Text;
                txtGia.Text = item.SubItems[2].Text;
                txtTrangthai.Text = item.SubItems[3].Text;
                txtMota.Text = item.SubItems[4].Text;
                txtYkien.Text = item.SubItems[5].Text;
                txtDexuat.Text = item.SubItems[6].Text;
            }
            else
            {
                ClearTextBoxes();
            }
        }
    }
}
