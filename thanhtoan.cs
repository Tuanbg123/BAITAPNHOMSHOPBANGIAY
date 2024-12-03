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
    public partial class thanhtoan : Form
    {
        ketnoi2 kn2 = new ketnoi2();
        public thanhtoan()
        {
            InitializeComponent();
            load();
        }
        public void load()
        {
            dataGridView1.DataSource = kn2.GetTable();
        }
        private void thanhtoan_Load(object sender, EventArgs e)
        {
            loadcombobox();
            loadcombobox1();
        }
        public void loadcombobox()
        {
            List<int> maSPList = kn2.laymasp();
            comboBox2.DataSource = maSPList;
        }
        public void loadcombobox1()
        {
            List<int> makh= kn2.laymakh();
            comboBox3.DataSource = makh;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem != null)
            {
                int selectedMaSP = Convert.ToInt32(comboBox2.SelectedItem);
                LoadProductInfo(selectedMaSP);
            }
        }
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.SelectedItem != null)
            {
                int tenkh = Convert.ToInt32(comboBox3.SelectedItem);
                LoadProductkhachhang(tenkh);
            }
        }
        private void LoadProductInfo(int maSP)
        {

            DataTable productInfo = kn2.laythongtin(maSP);

            if (productInfo.Rows.Count > 0)
            {
                DataRow row = productInfo.Rows[0];
                txttensp.Text = row["TenSP"].ToString();
                txtloaisp.Text = row["LoaiSP"].ToString();
                txtgia.Text = row["Gia"].ToString();
            }
            else
            {
                txttensp.Clear();
                txtloaisp.Clear();
                txtgia.Clear();
            }
        }
        private void LoadProductkhachhang(int maKH)
        {

            DataTable productkhachhang = kn2.laythongtinkh(maKH);

            if (productkhachhang.Rows.Count > 0)
            {
                DataRow row = productkhachhang.Rows[0];
                txttenkhachhang.Text = row["TenKH"].ToString();
               
            }
            else
            {
                txttenkhachhang.Clear();
              
            }
        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            int machitiet= int.Parse(txtmachitiet.Text);
            int masp = int.Parse(comboBox2.SelectedItem.ToString());
            string tensp = txttensp.Text;
            string loaisp = txtloaisp.Text;
            decimal gia = decimal.Parse(txtgia.Text);
            int kichco = int.Parse(txtkichco.Text);
            string mau = comboBox1.SelectedItem.ToString();
            int soluong = int.Parse(numericUpDown1.Text);
            decimal thanhtien = Math.Round(soluong * gia, 2);
            if (kn2.them(machitiet,masp, tensp, loaisp, gia, kichco, mau, soluong,thanhtien))
            {
                MessageBox.Show("Thêm thành công ", "Thông báo", MessageBoxButtons.OK);
                load();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtmachitiet.Text = row.Cells["MaChiTiet"].Value.ToString();
                comboBox2.Text = row.Cells["MaSP"].Value.ToString();
                txtkichco.Text = row.Cells["KichCo"].Value.ToString();

                comboBox1.Text = row.Cells["Mau"].Value.ToString();
                numericUpDown1.Text = row.Cells["SoLuong"].Value.ToString();
            }
        }

        private void btnthanhtoan_Click(object sender, EventArgs e)
        {
            List<string> ds = new List<string>();
            decimal tongtien = 0;
            bool soLuongDu = true;
            StringBuilder thongBaoLoi = new StringBuilder();
            string tenKhachHang = txttenkhachhang.Text;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["MaChiTiet"].Value != null)
                {
                    int maSP = Convert.ToInt32(row.Cells["MaSP"].Value);
                    int soLuongMua = Convert.ToInt32(row.Cells["SoLuong"].Value);
                    int soLuongTon = kn2.LaySoLuongTon(maSP); 

                    if (soLuongMua > soLuongTon)
                    {
                        soLuongDu = false;
                        thongBaoLoi.AppendLine($"Sản phẩm {row.Cells["TenSP"].Value}: trong Shop chỉ còn lại  { soLuongTon} sản phẩm.");
                    }
                    else
                    {
                       
                        string tenSP = row.Cells["TenSP"].Value.ToString();
                        string mau = row.Cells["Mau"].Value.ToString();
                        string kichCo = row.Cells["KichCo"].Value.ToString();
                        string thanhTien = row.Cells["ThanhTien"].Value.ToString();

                        tongtien += Convert.ToDecimal(thanhTien);
                        ds.Add($"Tên sản phẩm: {tenSP} \n Màu: {mau}, Kích cỡ: {kichCo}, Số lượng: {soLuongMua}\n Thành tiền: {thanhTien}\n-----------------------------------------------------------------");
                    }
                }
            }

            if (!soLuongDu)
            {
                MessageBox.Show(thongBaoLoi.ToString(), "Số lượng không đủ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (ds.Count > 0)
            {
                StringBuilder billContent = new StringBuilder();
               
                foreach (string detail in ds)
                {
                    billContent.AppendLine(detail);
                }


                
                hoadon hienthi = new hoadon(billContent.ToString(), tongtien,tenKhachHang);
                hienthi.ShowDialog();
            }
            else
            {
                MessageBox.Show("Không có sản phẩm nào để thanh toán!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
                

        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            int machitiet = int.Parse(txtmachitiet.Text);
            int masp = int.Parse(comboBox2.SelectedItem.ToString());
            string tensp = txttensp.Text;
            string loaisp = txtloaisp.Text;
            decimal gia = decimal.Parse(txtgia.Text);
            int kichco = int.Parse(txtkichco.Text);
            string mau = comboBox1.SelectedItem.ToString();
            int soluong = int.Parse(numericUpDown1.Text);
            decimal thanhtien = Math.Round(soluong * gia, 2);
            if (kn2.sua(machitiet, masp, tensp, loaisp, gia, kichco, mau, soluong, thanhtien))
            {
                MessageBox.Show("Sửa thành công ", "Thông báo", MessageBoxButtons.OK);
                load();
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có dòng nào được chọn không
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa các sản phẩm đã chọn không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                 
                    foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                    {
                        if (row.Cells["MaChiTiet"].Value != null)
                        {
                            int maChiTiet = Convert.ToInt32(row.Cells["MaChiTiet"].Value);

               
                            if (kn2.xoakh(maChiTiet))
                            {
                                dataGridView1.Rows.Remove(row); 
                            }
                        }
                    }

                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    load();
                    tailai();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn ít nhất một dòng để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void tailai()
        {
            txtmachitiet.Clear();
            txtloaisp.Clear();
            txtgia.Clear();
            txtkichco.Clear();
            txttensp.Clear();
            comboBox1.Dispose();
            numericUpDown1.Dispose();
        }

        
    }
}
