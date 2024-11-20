using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BAITAPNHOMSHOPBANGIAY
{
    internal class ketnoicthd
    {
        private SqlConnection conn;

        // Mở kết nối
        public void openConnection()
        {
            conn = new SqlConnection("Server=(localdb)\\MSSQLLocalDB;Database=QLBG;Integrated Security=True");
            conn.Open();
        }

        // Đóng kết nối
        public void closeConnection()
        {
            if (conn != null && conn.State == ConnectionState.Open)
                conn.Close();
        }

        // Lấy dữ liệu từ bảng CHITIETDONHANG
        public DataTable GetTable()
        {
            DataTable dt = new DataTable();
            try
            {
                openConnection();
                string query = "SELECT * FROM CHITIETDONHANG";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        dt.Load(reader);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lấy dữ liệu: {ex.Message}");
            }
            finally
            {
                closeConnection();
            }
            return dt;
        }

        // Thêm mới một chi tiết hóa đơn
        public bool ThemChiTiet(int maChiTiet, int maHD, int maSP, int soLuong, decimal gia, decimal thanhTien)
        {
            try
            {
                openConnection();
                string query = "INSERT INTO CHITIETDONHANG (MaChiTiet, MaHD, MaSP, SoLuong, Gia, ThanhTien) " +
                               "VALUES (@MaChiTiet, @MaHD, @MaSP, @SoLuong, @Gia, @ThanhTien)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MaChiTiet", maChiTiet);
                    cmd.Parameters.AddWithValue("@MaHD", maHD);
                    cmd.Parameters.AddWithValue("@MaSP", maSP);
                    cmd.Parameters.AddWithValue("@SoLuong", soLuong);
                    cmd.Parameters.AddWithValue("@Gia", gia);
                    cmd.Parameters.AddWithValue("@ThanhTien", thanhTien);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm chi tiết: {ex.Message}");
                return false;
            }
            finally
            {
                closeConnection();
            }
        }

        // Sửa một chi tiết hóa đơn
        public bool SuaChiTiet(int maChiTiet, int maHD, int maSP, int soLuong, decimal gia, decimal thanhTien)
        {
            try
            {
                openConnection();
                string query = "UPDATE CHITIETDONHANG SET MaHD = @MaHD, MaSP = @MaSP, SoLuong = @SoLuong, " +
                               "Gia = @Gia, ThanhTien = @ThanhTien WHERE MaChiTiet = @MaChiTiet";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MaChiTiet", maChiTiet);
                    cmd.Parameters.AddWithValue("@MaHD", maHD);
                    cmd.Parameters.AddWithValue("@MaSP", maSP);
                    cmd.Parameters.AddWithValue("@SoLuong", soLuong);
                    cmd.Parameters.AddWithValue("@Gia", gia);
                    cmd.Parameters.AddWithValue("@ThanhTien", thanhTien);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi sửa chi tiết: {ex.Message}");
                return false;
            }
            finally
            {
                closeConnection();
            }
        }

        // Xóa một chi tiết hóa đơn
        public bool XoaChiTiet(int maChiTiet)
        {
            try
            {
                openConnection();
                string query = "DELETE FROM CHITIETDONHANG WHERE MaChiTiet = @MaChiTiet";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MaChiTiet", maChiTiet);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xóa chi tiết: {ex.Message}");
                return false;
            }
            finally
            {
                closeConnection();
            }
        }

        // Tìm kiếm chi tiết hóa đơn theo MaChiTiet
        public DataTable TimKiem(int maChiTiet)
        {
            DataTable dt = new DataTable();
            try
            {
                openConnection();
                string query = "SELECT * FROM CHITIETDONHANG WHERE MaChiTiet = @MaChiTiet";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MaChiTiet", maChiTiet);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        dt.Load(reader);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tìm kiếm: {ex.Message}");
            }
            finally
            {
                closeConnection();
            }
            return dt;
        }
    }
}
