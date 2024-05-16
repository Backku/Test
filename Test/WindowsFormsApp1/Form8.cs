using System;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form8 : Form
    {
        private readonly DatabaseManager dbManager;

        public Form8()
        {
            InitializeComponent();
            dbManager = new DatabaseManager($@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={Application.StartupPath}\QLSanBong.mdf;Integrated Security=True;Connect Timeout=30");
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            string query = "SELECT * FROM KhachHang";
            DataTable table = dbManager.ExecuteQuery(query);
            dataGridView1.DataSource = table;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO KhachHang (MaKhachHang, HoTen, SoDienThoai, DiaChi, TenSan, LichDatSan) " +
                           $"VALUES ('{txtMakh.Text}', '{txtHovaten.Text}', '{txtSdt.Text}', '{txtDiachi.Text}', '{txtTensan.Text}', '{dateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss")}')";
            int rowsAffected = dbManager.ExecuteNonQuery(query);
            if (rowsAffected > 0)
            {
                MessageBox.Show("Thêm khách hàng thành công!");
                LoadData();
            }
            else
            {
                MessageBox.Show("Không có hàng nào được thêm.");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string maKhachHang = txtMakh.Text;
                string hoTen = txtHovaten.Text;
                string soDienThoai = txtSdt.Text;
                string diaChi = txtDiachi.Text;
                string tenSan = txtTensan.Text;
                string lichDatSan = dateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss");

                if (string.IsNullOrEmpty(maKhachHang) || string.IsNullOrEmpty(hoTen) || string.IsNullOrEmpty(soDienThoai) || string.IsNullOrEmpty(diaChi) || string.IsNullOrEmpty(tenSan) || string.IsNullOrEmpty(lichDatSan))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                    return;
                }

                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                int rowIndex = selectedRow.Index;
                selectedRow.Cells["MaKhachHang"].Value = maKhachHang;
                selectedRow.Cells["HoTen"].Value = hoTen;
                selectedRow.Cells["SoDienThoai"].Value = soDienThoai;
                selectedRow.Cells["DiaChi"].Value = diaChi;
                selectedRow.Cells["TenSan"].Value = tenSan;
                selectedRow.Cells["LichDatSan"].Value = lichDatSan;

                string query = $"UPDATE KhachHang SET HoTen = '{hoTen}', SoDienThoai = '{soDienThoai}', DiaChi = '{diaChi}', TenSan = '{tenSan}', LichDatSan = '{lichDatSan}' WHERE MaKhachHang = '{maKhachHang}'";
                dbManager.ExecuteNonQuery(query);

                MessageBox.Show("Thông tin đã được cập nhật thành công!");
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng để sửa.");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                string maKhachHang = selectedRow.Cells["MaKhachHang"].Value.ToString();
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng này không?", "Xác nhận xóa", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    string query = $"DELETE FROM KhachHang WHERE MaKhachHang = '{maKhachHang}'";
                    int rowsAffected = dbManager.ExecuteNonQuery(query);
                    if (rowsAffected > 0)
                    {
                        dataGridView1.Rows.Remove(selectedRow);
                        MessageBox.Show("Xóa khách hàng thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Không có khách hàng nào được xóa.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một khách hàng để xóa.");
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                txtMakh.Text = selectedRow.Cells["MaKhachHang"].Value.ToString();
                txtHovaten.Text = selectedRow.Cells["HoTen"].Value.ToString();
                txtSdt.Text = selectedRow.Cells["SoDienThoai"].Value.ToString();
                txtDiachi.Text = selectedRow.Cells["DiaChi"].Value.ToString();
                txtTensan.Text = selectedRow.Cells["TenSan"].Value.ToString();
                dateTimePicker1.Value = DateTime.Parse(selectedRow.Cells["LichDatSan"].Value.ToString());
            }
        }

        private void btnNhaplai_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
            dataGridView1.ClearSelection();
        }

        private void ClearTextBoxes()
        {
            txtMakh.Clear();
            txtHovaten.Clear();
            txtSdt.Clear();
            txtDiachi.Clear();
            txtTensan.Clear();
            dateTimePicker1.Value = DateTime.Now;
        }
    }
}
