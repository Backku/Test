using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private List<SoccerField> soccerFields = new List<SoccerField>();
        public Form1()
        {
            InitializeComponent();
            InitializeSoccerFields();
        }
        private void InitializeSoccerFields()
        {
            // Khởi tạo danh sách các sân bóng mẫu
            soccerFields.Add(new SoccerField("A1", "Sân A", "Trống", "Sân nằm trong nhà, sân đẹp"));
            soccerFields.Add(new SoccerField("B1", "Sân B", "Trống", "Sân ngoài trời, sân rộng"));
            soccerFields.Add(new SoccerField("C1", "Sân C", "Trống", "Sân có đèn chiếu sáng"));
            soccerFields.Add(new SoccerField("D1", "Sân D", "Trống", "Sân gần quán ăn"));
            soccerFields.Add(new SoccerField("E1", "Sân E", "Trống", "Sân mới xây, rất sạch sẽ"));

            // Hiển thị danh sách sân bóng lên ListView
            UpdateSoccerFieldListView();
        }
        private void UpdateSoccerFieldListView()
        {
            listView1.Items.Clear();
            foreach (SoccerField soccerField in soccerFields)
            {
                ListViewItem item = new ListViewItem(soccerField.Code);
                item.SubItems.Add(soccerField.Name);
                item.SubItems.Add(soccerField.Status);
                item.SubItems.Add(soccerField.Description);
                listView1.Items.Add(item);
            }
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string searchField = comboBox1.Text;

            if (string.IsNullOrEmpty(searchField))
            {
                MessageBox.Show("Vui lòng chọn mã sân để tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            bool found = false;

            foreach (ListViewItem item in listView1.Items)
            {
                if (item.SubItems[0].Text == searchField)
                {
                    item.Selected = true;
                    listView1.Focus();
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                MessageBox.Show("Không tìm thấy sân bóng với mã sân đã chọn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDatSan_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices.Count > 0)
            {
                string customerName = txtTenKH.Text;
                string phoneNumber = txtSDT.Text;
                string fieldName = txtSan.Text;
                string bookingTime = DateTime.Now.ToShortTimeString();
                string bookingDate = dateTimePicker3.Value.ToShortDateString();

                soccerFields[listView1.SelectedIndices[0]].Status = "Đã đặt";
                UpdateSoccerFieldListView();
                ClearBookingFields();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một sân bóng để đặt.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            ClearBookingFields();
        }
        private void ClearBookingFields()
        {
            txtTenKH.Clear();
            txtSDT.Clear();
            txtSan.Clear();
            dateTimePicker3.Value = DateTime.Now;
            txtTenKH.Focus();
        }

        private void btnNhaplai_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
            comboBox1.SelectedIndex = -1;
            foreach (ListViewItem item in listView1.SelectedItems)
            {
                item.Selected = false;
            }
        }
    }
    public class SoccerField
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public string Description { get; set; }

        public SoccerField(string code, string name, string status, string description)
        {
            Code = code;
            Name = name;
            Status = status;
            Description = description;
        }
    }
}
