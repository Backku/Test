using System;
using System.Collections;
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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            // Thiết lập dữ liệu mẫu cho combobox Mặt hàng
            comboBoxMathang.Items.AddRange(new string[] { "Đồ uống", "Đồ ăn" });
            // Thiết lập cột cho listViewDichVu
            listViewDichvu.View = View.Details;
            listViewDichvu.Columns.Add("Mã sân", 100, HorizontalAlignment.Center);
            listViewDichvu.Columns.Add("Tên sân", 100, HorizontalAlignment.Center);
            listViewDichvu.Columns.Add("Giá sân", 100, HorizontalAlignment.Center);
            listViewDichvu.Columns.Add("Mặt hàng", 100, HorizontalAlignment.Center);
            listViewDichvu.Columns.Add("Tên sản phẩm", 150, HorizontalAlignment.Center);
            listViewDichvu.Columns.Add("Số lượng", 100, HorizontalAlignment.Center);
            listViewDichvu.Columns.Add("Giá sản phẩm", 100, HorizontalAlignment.Center); // Thêm cột giá vào ListView
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu combobox Mặt hàng và combobox Tên sản phẩm đã được chọn
            if (comboBoxMathang.SelectedItem != null && comboBoxTensanpham.SelectedItem != null)
            {
                Product selectedProduct = (Product)comboBoxTensanpham.SelectedItem;
                ListViewItem item = new ListViewItem(txtMasan.Text);
                item.SubItems.Add(txtTensan.Text).Name = "TenSan";
                item.SubItems.Add(txtGiasan.Text);
                item.SubItems.Add(comboBoxMathang.SelectedItem.ToString());
                item.SubItems.Add(comboBoxTensanpham.SelectedItem.ToString());
                item.SubItems.Add(txtSoluong.Text);

                int quantity = int.Parse(txtSoluong.Text);
                int totalPrice = selectedProduct.Price * quantity;
                item.SubItems.Add(totalPrice.ToString()); // Thêm giá của sản phẩm vào ListViewItem

                // Thiết lập căn giữa cho các tên trong listViewDichVu
                item.UseItemStyleForSubItems = false;
                foreach (ListViewItem.ListViewSubItem subItem in item.SubItems)
                {
                    subItem.Font = new Font("Arial", 10, FontStyle.Regular);
                    subItem.ForeColor = Color.Black;
                    subItem.BackColor = Color.White;
                }

                listViewDichvu.Items.Add(item);

                // Reset dữ liệu nhập sau khi thêm
                ResetInputData();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn Mặt hàng và Tên sản phẩm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có item nào được chọn không
            if (listViewDichvu.SelectedItems.Count > 0)
            {
                // Xoá item được chọn trong ListView
                listViewDichvu.Items.Remove(listViewDichvu.SelectedItems[0]);
                ResetInputData();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để xoá.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            if (listViewDichvu.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listViewDichvu.SelectedItems[0];

                // Lấy thông tin từ hàng đã chọn và điền vào các TextBox
                txtTiendichvu.Text = selectedItem.SubItems[6].Text;
                txtTiensan.Text = selectedItem.SubItems[2].Text;
                txtTongthanhtoan.Text = (int.Parse(txtTiendichvu.Text) + int.Parse(txtTiensan.Text)).ToString();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để xuất.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtTiendichvu.Text = "";
            txtTiensan.Text = "";
            txtTongthanhtoan.Text = "";
            txtTiencoc.Text = "";
            txtTienthanhtoan.Text = "";
        }

        private void btnThanhtoan_Click(object sender, EventArgs e)
        {
            var form2 = new Form2();
            form2.ShowDialog();
        }
        private void ResetInputData()
        {
            txtMasan.Text = "";
            txtTensan.Text = "";
            txtGiasan.Text = "";
            txtSoluong.Text = "";
            comboBoxMathang.SelectedIndex = -1;

            // Kiểm tra trước khi gán giá trị
            if (comboBoxTensanpham != null)
            {
                comboBoxTensanpham.SelectedIndex = -1;
                comboBoxTensanpham.Items.Clear();
            }
        }
        public class Product
        {
            public string Name { get; set; }
            public int Price { get; set; }

            public Product(string name, int price)
            {
                Name = name;
                Price = price;
            }

            public override string ToString()
            {
                return Name + " - " + Price.ToString();
            }
        }

        private void comboBoxMathang_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Xoá toàn bộ dữ liệu cũ trong combobox Tên sản phẩm
            comboBoxTensanpham.Items.Clear();

            // Kiểm tra xem đã chọn một mục trong comboBoxMathang chưa
            if (comboBoxMathang.SelectedItem != null)
            {
                // Nếu mặt hàng là "Đồ uống"
                if (comboBoxMathang.SelectedItem.ToString() == "Đồ uống")
                {
                    // Thêm các sản phẩm đồ uống vào combobox Tên sản phẩm
                    comboBoxTensanpham.Items.Add(new Product("Nước ngọt", 5000));
                    comboBoxTensanpham.Items.Add(new Product("Cà phê", 10000));
                    comboBoxTensanpham.Items.Add(new Product("Trà sữa", 15000));
                }
                // Nếu mặt hàng là "Đồ ăn"
                else if (comboBoxMathang.SelectedItem.ToString() == "Đồ ăn")
                {
                    // Thêm các sản phẩm đồ ăn vào combobox Tên sản phẩm
                    comboBoxTensanpham.Items.Add(new Product("Bánh mì", 7000));
                    comboBoxTensanpham.Items.Add(new Product("Bánh bao", 5000));
                    comboBoxTensanpham.Items.Add(new Product("Hamburger", 20000));
                }

                // Hiển thị combobox Tên sản phẩm sau khi đã thêm dữ liệu
                comboBoxTensanpham.Visible = true;
            }
        }

        private void listViewDichvu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewDichvu.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listViewDichvu.SelectedItems[0];

                // Lấy thông tin từ hàng đã chọn và điền vào các TextBox
                txtMasan.Text = selectedItem.SubItems[0].Text;
                txtTensan.Text = selectedItem.SubItems[1].Text;
                txtGiasan.Text = selectedItem.SubItems[2].Text;
                comboBoxMathang.SelectedItem = selectedItem.SubItems[3].Text;
                comboBoxTensanpham.SelectedItem = selectedItem.SubItems[4].Text;
                txtSoluong.Text = selectedItem.SubItems[5].Text;
            }
        }
        private void btnNhaplai_Click(object sender, EventArgs e)
        {
            ResetInputData();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có hàng nào được chọn không
            if (listViewDichvu.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listViewDichvu.SelectedItems[0];

                // Lấy thông tin từ các TextBox và ComboBox và cập nhật lại vào ListViewItem
                selectedItem.SubItems[0].Text = txtMasan.Text;
                selectedItem.SubItems[1].Text = txtTensan.Text;
                selectedItem.SubItems[2].Text = txtGiasan.Text;
                selectedItem.SubItems[3].Text = comboBoxMathang.SelectedItem.ToString();
                selectedItem.SubItems[5].Text = txtSoluong.Text;

                // Kiểm tra xem mục đã được chọn trong comboBoxTensanpham chưa
                if (comboBoxTensanpham.SelectedItem != null)
                {
                    selectedItem.SubItems[4].Text = comboBoxTensanpham.SelectedItem.ToString();

                    // Cập nhật giá của sản phẩm
                    Product selectedProduct = (Product)comboBoxTensanpham.SelectedItem;
                    int quantity = int.Parse(txtSoluong.Text);
                    int totalPrice = selectedProduct.Price * quantity;
                    selectedItem.SubItems[6].Text = totalPrice.ToString(); // Cập nhật giá của sản phẩm
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnTinhtoan_Click_1(object sender, EventArgs e)
        {
            int tongTienDichVu = int.Parse(txtTiendichvu.Text);
            int tongTienSan = int.Parse(txtTiensan.Text);
            int tongTongThanhToan = tongTienDichVu + tongTienSan;

            txtTongthanhtoan.Text = tongTongThanhToan.ToString();

            int tienCoc;
            if (!int.TryParse(txtTiencoc.Text, out tienCoc))
            {
                MessageBox.Show("Vui lòng nhập tiền cọc.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int tienThanhToan = tongTongThanhToan - tienCoc;
            txtTienthanhtoan.Text = tienThanhToan.ToString();
        }
    }
}
