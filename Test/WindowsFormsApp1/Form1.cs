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
    public partial class Form1 : Form
    {
        private readonly DatabaseManager dbManager;

        public Form1()
        {
            InitializeComponent();
            // Initialize the DatabaseManager with the connection string
            dbManager = new DatabaseManager($@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={Application.StartupPath}\QLSanBong.mdf;Integrated Security=True;Connect Timeout=30");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            // Query to select all records from the LichDatSan table
            string query = "SELECT * FROM LichDatSan";
            // Execute the query and bind the result to the DataGridView
            dataGridView1.DataSource = dbManager.ExecuteQuery(query);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Construct the insert query
            string query = $"INSERT INTO LichDatSan (MaDatSan, MaKhachHang, NgayDat, TinhTrang, TenSan) " +
                           $"VALUES ('{txtMadatsan.Text}', '{txtMakhachhang.Text}', '{dateTimePicker1.Value}', '{txtTinhtrang.Text}', '{txtTensan.Text}')";
            // Execute the query and get the number of affected rows
            int rowsAffected = dbManager.ExecuteNonQuery(query);
            // Check if any rows were affected
            if (rowsAffected > 0)
            {
                MessageBox.Show("Thêm thành công!");
                LoadData(); // Reload the data to update the DataGridView
            }
            else
            {
                MessageBox.Show("Không có dữ liệu nào được thêm.");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // Check if a row is selected in the DataGridView
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                // Get the value of the MaDatSan column from the selected row
                string maDatSan = selectedRow.Cells["MaDatSan"].Value.ToString();
                // Construct the update query
                string query = $"UPDATE LichDatSan SET MaKhachHang = '{txtMakhachhang.Text}', NgayDat = '{dateTimePicker1.Value}', TinhTrang = '{txtTinhtrang.Text}', TenSan = '{txtTensan.Text}' WHERE MaDatSan = '{maDatSan}'";
                // Execute the query and get the number of affected rows
                int rowsAffected = dbManager.ExecuteNonQuery(query);
                // Check if any rows were affected
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Sửa thành công!");
                    LoadData(); // Reload the data to update the DataGridView
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu nào được sửa.");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng để sửa.");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Check if a row is selected in the DataGridView
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                // Get the value of the MaDatSan column from the selected row
                string maDatSan = selectedRow.Cells["MaDatSan"].Value.ToString();
                // Construct the delete query
                string query = $"DELETE FROM LichDatSan WHERE MaDatSan = '{maDatSan}'";
                // Execute the query and get the number of affected rows
                int rowsAffected = dbManager.ExecuteNonQuery(query);
                // Check if any rows were affected
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Xóa thành công!");
                    LoadData(); // Reload the data to update the DataGridView
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu nào được xóa.");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng để xóa.");
            }
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            // Get the search keyword from the TextBox
            string keyword = txtTimkiem.Text;
            if (!string.IsNullOrEmpty(keyword))
            {
                // Construct the search query
                string query = $"SELECT * FROM LichDatSan WHERE MaDatSan LIKE '%{keyword}%'";
                // Execute the query and bind the result to the DataGridView
                dataGridView1.DataSource = dbManager.ExecuteQuery(query);
            }
            else
            {
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm.");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the row index is valid
            if (e.RowIndex >= 0)
            {
                // Get the selected row
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                // Populate the TextBoxes with the values from the selected row
                txtMadatsan.Text = row.Cells["MaDatSan"].Value.ToString();
                txtMakhachhang.Text = row.Cells["MaKhachHang"].Value.ToString();
                dateTimePicker1.Value = Convert.ToDateTime(row.Cells["NgayDat"].Value);
                txtTinhtrang.Text = row.Cells["TinhTrang"].Value.ToString();
                txtTensan.Text = row.Cells["TenSan"].Value.ToString();
            }
        }
    }
}
