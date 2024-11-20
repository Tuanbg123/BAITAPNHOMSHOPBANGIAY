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
    public partial class chitiethoadon : Form
    {
        // Khai báo biến lớp kết nối
        private ketnoicthd ketNoi = new ketnoicthd();

        // Hàm tải dữ liệu vào DataGridView
        private void LoadData()
        {
            try
            {
                DataTable dt = ketNoi.GetTable();
                dataGridView1.DataSource = dt; // dataGridView1 là bảng hiển thị danh sách chi tiết hóa đơn
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải dữ liệu: {ex.Message}");
            }
        }

        // Hàm làm sạch các textbox
        private void ClearInput()
        {
            txtMaChiTiet.Text = "";
            txtMaHD.Text = "";
            txtMaSP.Text = "";
            txtSoLuong.Text = "";
            txtGia.Text = "";
            txtThanhTien.Text = "";
        }

        public chitiethoadon()
        {
            InitializeComponent();
        }

        private void chitiethoadon_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                int maChiTiet = int.Parse(txtMaChiTiet.Text);
                int maHD = int.Parse(txtMaHD.Text);
                int maSP = int.Parse(txtMaSP.Text);
                int soLuong = int.Parse(txtSoLuong.Text);
                decimal gia = decimal.Parse(txtGia.Text);
                decimal thanhTien = soLuong * gia; // Tính thành tiền

                if (ketNoi.ThemChiTiet(maChiTiet, maHD, maSP, soLuong, gia, thanhTien))
                {
                    MessageBox.Show("Thêm chi tiết hóa đơn thành công!");
                    LoadData();
                    ClearInput();
                }
                else
                {
                    MessageBox.Show("Thêm chi tiết hóa đơn thất bại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                int maChiTiet = int.Parse(txtMaChiTiet.Text);
                int maHD = int.Parse(txtMaHD.Text);
                int maSP = int.Parse(txtMaSP.Text);
                int soLuong = int.Parse(txtSoLuong.Text);
                decimal gia = decimal.Parse(txtGia.Text);
                decimal thanhTien = soLuong * gia; // Tính lại thành tiền

                if (ketNoi.SuaChiTiet(maChiTiet, maHD, maSP, soLuong, gia, thanhTien))
                {
                    MessageBox.Show("Sửa chi tiết hóa đơn thành công!");
                    LoadData();
                    ClearInput();
                }
                else
                {
                    MessageBox.Show("Sửa chi tiết hóa đơn thất bại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtMaChiTiet.Text))
                {
                    MessageBox.Show("Vui lòng nhập mã chi tiết hóa đơn để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa chi tiết hóa đơn này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                
                if(result == DialogResult.Yes)
                {
                    int maChiTiet = int.Parse(txtMaChiTiet.Text);

                    if (ketNoi.XoaChiTiet(maChiTiet))
                    {
                        MessageBox.Show("Xóa chi tiết hóa đơn thành công!");
                        LoadData();
                        ClearInput();
                    }
                    else
                    {
                        MessageBox.Show("Xóa chi tiết hóa đơn thất bại!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                int maChiTiet = int.Parse(txtTimKiem.Text);

                DataTable dt = ketNoi.TimKiem(maChiTiet);
                if (dt.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dt; // Hiển thị kết quả tìm kiếm
                }
                else
                {
                    MessageBox.Show("Không tìm thấy chi tiết hóa đơn!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            try
            {
                decimal tongTien = 0;

                // Duyệt qua từng hàng trong DataGridView để tính tổng tiền
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells["ThanhTien"].Value != null)
                    {
                        tongTien += Convert.ToDecimal(row.Cells["ThanhTien"].Value);
                    }
                }

                MessageBox.Show($"Tổng tiền cần thanh toán: {tongTien:C}", "Thanh toán");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tính tổng tiền: {ex.Message}");
            }
        }
    }
}
