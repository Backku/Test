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
    public partial class Form8 : Form
    {
        // Khai báo một list chứa danh sách khách hàng
        List<KhachHang> danhSachKhachHang = new List<KhachHang>();
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            // Thiết lập các cột trong ListView
            listView1.View = View.Details;
            listView1.Columns.Add("Mã KH", 50, HorizontalAlignment.Center);
            listView1.Columns.Add("Họ và tên", 100, HorizontalAlignment.Center);
            listView1.Columns.Add("Số điện thoại", 100, HorizontalAlignment.Center);
            listView1.Columns.Add("Địa chỉ", 150, HorizontalAlignment.Center);
            listView1.Columns.Add("Tên sân", 100, HorizontalAlignment.Center);
            listView1.Columns.Add("Lịch đặt sân", 100, HorizontalAlignment.Center);
            listView1.Columns.Add("Phương thức thanh toán", 150, HorizontalAlignment.Center);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Lấy thông tin từ các TextBox
            string maKH = txtMakh.Text;
            string hoTen = txtHovaten.Text;
            string sdt = txtSdt.Text;
            string diaChi = txtDiachi.Text;
            string tenSan = txtTensan.Text;
            string lichDatSan = txtLichdatsan.Text;
            string phuongThucThanhToan = txtThanhtoan.Text;

            // Tạo một khách hàng mới
            KhachHang khachHang = new KhachHang(maKH, hoTen, sdt, diaChi, tenSan, lichDatSan, phuongThucThanhToan);

            // Thêm khách hàng vào danh sách
            danhSachKhachHang.Add(khachHang);

            // Hiển thị thông tin khách hàng trên ListView
            ListViewItem item = new ListViewItem(new string[]
            {
                khachHang.MaKH, khachHang.HoTen, khachHang.SDT, khachHang.DiaChi,
                khachHang.TenSan, khachHang.LichDatSan, khachHang.PhuongThucThanhToan
            });
            listView1.Items.Add(item);

            // Xóa nội dung trong các TextBox sau khi thêm thành công
            ClearTextBoxes();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có item nào được chọn không
            if (listView1.SelectedItems.Count > 0)
            {
                // Lấy thông tin khách hàng được chọn
                ListViewItem selectedItem = listView1.SelectedItems[0];
                int selectedIndex = listView1.Items.IndexOf(selectedItem);

                // Cập nhật thông tin khách hàng từ các TextBox
                danhSachKhachHang[selectedIndex].MaKH = txtMakh.Text;
                danhSachKhachHang[selectedIndex].HoTen = txtHovaten.Text;
                danhSachKhachHang[selectedIndex].SDT = txtSdt.Text;
                danhSachKhachHang[selectedIndex].DiaChi = txtDiachi.Text;
                danhSachKhachHang[selectedIndex].TenSan = txtTensan.Text;
                danhSachKhachHang[selectedIndex].LichDatSan = txtLichdatsan.Text;
                danhSachKhachHang[selectedIndex].PhuongThucThanhToan = txtThanhtoan.Text;

                // Cập nhật thông tin trên ListView
                selectedItem.SubItems[0].Text = txtMakh.Text;
                selectedItem.SubItems[1].Text = txtHovaten.Text;
                selectedItem.SubItems[2].Text = txtSdt.Text;
                selectedItem.SubItems[3].Text = txtDiachi.Text;
                selectedItem.SubItems[4].Text = txtTensan.Text;
                selectedItem.SubItems[5].Text = txtLichdatsan.Text;
                selectedItem.SubItems[6].Text = txtThanhtoan.Text;

                // Xóa nội dung trong các TextBox sau khi sửa thành công
                ClearTextBoxes();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một khách hàng để sửa.");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có item nào được chọn không
            if (listView1.SelectedItems.Count > 0)
            {
                // Xác nhận việc xóa
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng này không?", "Xác nhận xóa", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    // Lấy index của item được chọn
                    int selectedIndex = listView1.Items.IndexOf(listView1.SelectedItems[0]);

                    // Xóa khách hàng khỏi danh sách
                    danhSachKhachHang.RemoveAt(selectedIndex);

                    // Xóa item khỏi ListView
                    listView1.Items.RemoveAt(selectedIndex);

                    // Xóa nội dung trong các TextBox sau khi xóa thành công
                    ClearTextBoxes();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một khách hàng để xóa.");
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                int selectedIndex = listView1.Items.IndexOf(selectedItem);

                // Hiển thị thông tin của khách hàng lên các TextBox
                txtMakh.Text = danhSachKhachHang[selectedIndex].MaKH;
                txtHovaten.Text = danhSachKhachHang[selectedIndex].HoTen;
                txtSdt.Text = danhSachKhachHang[selectedIndex].SDT;
                txtDiachi.Text = danhSachKhachHang[selectedIndex].DiaChi;
                txtTensan.Text = danhSachKhachHang[selectedIndex].TenSan;
                txtLichdatsan.Text = danhSachKhachHang[selectedIndex].LichDatSan;
                txtThanhtoan.Text = danhSachKhachHang[selectedIndex].PhuongThucThanhToan;
            }
        }
        // Hàm dùng để xóa nội dung trong các TextBox
        private void ClearTextBoxes()
        {
            txtMakh.Clear();
            txtHovaten.Clear();
            txtSdt.Clear();
            txtDiachi.Clear();
            txtTensan.Clear();
            txtLichdatsan.Clear();
            txtThanhtoan.Clear();
        }
    }
    public class KhachHang
    {
        public string MaKH { get; set; }
        public string HoTen { get; set; }
        public string SDT { get; set; }
        public string DiaChi { get; set; }
        public string TenSan { get; set; }
        public string LichDatSan { get; set; }
        public string PhuongThucThanhToan { get; set; }

        public KhachHang(string maKH, string hoTen, string sdt, string diaChi, string tenSan, string lichDatSan, string phuongThucThanhToan)
        {
            MaKH = maKH;
            HoTen = hoTen;
            SDT = sdt;
            DiaChi = diaChi;
            TenSan = tenSan;
            LichDatSan = lichDatSan;
            PhuongThucThanhToan = phuongThucThanhToan;
        }
    }
}
