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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            InitializeListView();
        }

        private void InitializeListView()
        {
            // Thiết lập các cột trong ListView
            listView1.Columns.Add("Mã số", 60, HorizontalAlignment.Center);
            listView1.Columns.Add("Tên vật tư", 100, HorizontalAlignment.Center);
            listView1.Columns.Add("Số lượng", 60, HorizontalAlignment.Center);
            listView1.Columns.Add("Số lượng bổ sung", 100, HorizontalAlignment.Center);
            listView1.Columns.Add("Mô tả", 150, HorizontalAlignment.Center);
            listView1.Columns.Add("Tình trạng", 100, HorizontalAlignment.Center);
            listView1.Columns.Add("Yêu cầu", 100, HorizontalAlignment.Center);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Kiểm tra các trường thông tin đã được điền đầy đủ chưa
            if (string.IsNullOrWhiteSpace(txtMaso.Text) ||
                string.IsNullOrWhiteSpace(txtTenvattu.Text) ||
                string.IsNullOrWhiteSpace(txtSoluong.Text) ||
                string.IsNullOrWhiteSpace(txtBosung.Text) ||
                string.IsNullOrWhiteSpace(txtMota.Text) ||
                string.IsNullOrWhiteSpace(txtTinhtrang.Text) ||
                string.IsNullOrWhiteSpace(txtYeucau.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
                return;
            }

            // Thêm thông tin vào ListView
            ListViewItem item = new ListViewItem(txtMaso.Text);
            item.SubItems.Add(txtTenvattu.Text);
            item.SubItems.Add(txtSoluong.Text);
            item.SubItems.Add(txtBosung.Text);
            item.SubItems.Add(txtMota.Text);
            item.SubItems.Add(txtTinhtrang.Text);
            item.SubItems.Add(txtYeucau.Text);

            listView1.Items.Add(item);

            // Xóa nội dung trong các ô textbox sau khi thêm vào ListView
            ClearTextBoxes();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem người dùng đã chọn một mục trong ListView chưa
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một mục để sửa.");
                return;
            }

            // Lấy mục đã chọn trong ListView
            ListViewItem selectedItem = listView1.SelectedItems[0];

            // Cập nhật thông tin của mục được chọn
            selectedItem.SubItems[0].Text = txtMaso.Text;
            selectedItem.SubItems[1].Text = txtTenvattu.Text;
            selectedItem.SubItems[2].Text = txtSoluong.Text;
            selectedItem.SubItems[3].Text = txtBosung.Text;
            selectedItem.SubItems[4].Text = txtMota.Text;
            selectedItem.SubItems[5].Text = txtTinhtrang.Text;
            selectedItem.SubItems[6].Text = txtYeucau.Text;

            // Xóa nội dung trong các ô textbox sau khi cập nhật
            ClearTextBoxes();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem người dùng đã chọn một mục trong ListView chưa
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một mục để xóa.");
                return;
            }

            // Xác nhận việc xóa mục được chọn
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa mục này không?", "Xác nhận xóa", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                // Xóa mục được chọn khỏi ListView
                listView1.SelectedItems[0].Remove();
                // Xóa nội dung trong các ô textbox sau khi xóa
                ClearTextBoxes();
            }
        }
        private void ClearTextBoxes()
        {
            txtMaso.Clear();
            txtTenvattu.Clear();
            txtSoluong.Clear();
            txtBosung.Clear();
            txtMota.Clear();
            txtTinhtrang.Clear();
            txtYeucau.Clear();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                txtMaso.Text = selectedItem.SubItems[0].Text;
                txtTenvattu.Text = selectedItem.SubItems[1].Text;
                txtSoluong.Text = selectedItem.SubItems[2].Text;
                txtBosung.Text = selectedItem.SubItems[3].Text;
                txtMota.Text = selectedItem.SubItems[4].Text;
                txtTinhtrang.Text = selectedItem.SubItems[5].Text;
                txtYeucau.Text = selectedItem.SubItems[6].Text;
            }
        }
    }
}
