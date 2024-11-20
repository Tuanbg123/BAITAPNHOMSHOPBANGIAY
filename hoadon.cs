using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BAITAPNHOMSHOPBANGIAY
{
    public partial class hoadon : Form
    {
        private ketnoihd ketnoi = new ketnoihd();
        public hoadon()
        {
            InitializeComponent();
        }

        private void hoadon_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Đã thanh toán");
            comboBox1.Items.Add("Chưa thanh toán");
            comboBox1.SelectedIndex = 1;

            LoadData();
        }

        private void LoadData()
        {
            ketnoihd ketNoi = new ketnoihd();
            dataGridView1.DataSource = ketNoi.GetTable();
        }

        private void ClearInput()
        {
            txtMaHD.Clear();
            txtMaKH.Clear();
            dtpNgayLap.Value = DateTime.Now; // Reset DateTimePicker về ngày hiện tại
            txtTongTien.Clear();
            txtTimKiem.Clear();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy dữ liệu từ các TextBox và ComboBox
                int maHD = int.Parse(txtMaHD.Text);
                int maKH = int.Parse(txtMaKH.Text);
                DateTime ngayLap = dtpNgayLap.Value;
                decimal tongTien = decimal.Parse(txtTongTien.Text);
                bool tinhTrangHoaDon = comboBox1.SelectedIndex == 0; // "Đã thanh toán" -> true

                bool isSuccess = ketnoi.ThemHoaDon(maHD, maKH, ngayLap, tongTien, tinhTrangHoaDon);
                if (isSuccess)
                {
                    MessageBox.Show("Thêm hóa đơn thành công");
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Thêm hóa đơn thất bại");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

            try
            {
                // Lấy dữ liệu từ các TextBox và ComboBox
                int maHD = int.Parse(txtMaHD.Text);
                int maKH = int.Parse(txtMaKH.Text);
                DateTime ngayLap = dtpNgayLap.Value;
                decimal tongTien = decimal.Parse(txtTongTien.Text);
                bool tinhTrangHoaDon = comboBox1.SelectedIndex == 0; // "Đã thanh toán" -> true

                bool isSuccess = ketnoi.SuaHoaDon(maHD, maKH, ngayLap, tongTien, tinhTrangHoaDon);
                if (isSuccess)
                {
                    MessageBox.Show("Sửa hóa đơn thành công");
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Sửa hóa đơn thất bại");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int maHD = int.Parse(txtMaHD.Text);

                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa hóa đơn này?", "Xác nhận", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    bool isSuccess = ketnoi.XoaHoaDon(maHD);
                    if (isSuccess)
                    {
                        MessageBox.Show("Xóa hóa đơn thành công");
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Xóa hóa đơn thất bại");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string maHD = txtTimKiem.Text.Trim();

            if (string.IsNullOrWhiteSpace(maHD))
            {
                MessageBox.Show("Vui lòng nhập mã hóa đơn cần tìm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTimKiem.Focus();
                return;
            }

            ketnoihd ketNoi = new ketnoihd();
            DataTable dt = ketNoi.TimKiemHoaDon(maHD);

            if (dt.Rows.Count > 0)
            {
                dataGridView1.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Không tìm thấy hóa đơn nào với mã này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            try
            {
                int maHD = int.Parse(txtMaHD.Text);

                // Cập nhật trạng thái thanh toán
                bool isSuccess = ketnoi.ThanhToanHoaDon(maHD);
                if (isSuccess)
                {
                    MessageBox.Show("Hóa đơn đã được thanh toán");
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Thanh toán thất bại");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}
