using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BAITAPNHOMSHOPBANGIAY
{
    internal class ketnoihd
    {
        public SqlConnection conn;

        // Kết nối cơ sở dữ liệu
        public void openConnection()
        {
            conn = new SqlConnection("Server=(localdb)\\MSSQLLocalDB;Database=QLBG;Integrated Security=True");
            conn.Open();
        }

        public void closeConnection()
        {
            conn.Close();
        }

        // Lấy dữ liệu từ bảng Hóa Đơn
        public DataTable GetTable()
        {
            DataTable dt = new DataTable();
            try
            {
                openConnection();
                string query = "SELECT * FROM HOADON";
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
                MessageBox.Show(ex.Message);
            }
            finally
            {
                closeConnection();
            }
            return dt;
        }

        // Thêm mới hóa đơn
        public bool ThemHoaDon(int maHD, int maKH, DateTime ngayLap, decimal tongTien, bool tinhTrangHoaDon)
        {
            try
            {
                openConnection();
                string query = "INSERT INTO HOADON (MaHD, MaKH, NgayLap, TongTien, TinhTrangHoaDon) VALUES (@maHD, @maKH, @ngayLap, @tongTien, @tinhTrangHoaDon)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@maHD", maHD);
                    cmd.Parameters.AddWithValue("@maKH", maKH);
                    cmd.Parameters.AddWithValue("@ngayLap", ngayLap);
                    cmd.Parameters.AddWithValue("@tongTien", tongTien);
                    cmd.Parameters.AddWithValue("@tinhTrangHoaDon", tinhTrangHoaDon);

                    int result = cmd.ExecuteNonQuery();
                    return result > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                closeConnection();
            }
        }


        // Sửa hóa đơn
        public bool SuaHoaDon(int maHD, int maKH, DateTime ngayLap, decimal tongTien, bool tinhTrangHoaDon)
        {
            try
            {
                openConnection();
                string query = "UPDATE HOADON SET MaKH = @maKH, NgayLap = @ngayLap, TongTien = @tongTien, TinhTrangHoaDon = @tinhTrangHoaDon WHERE MaHD = @maHD";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@maHD", maHD);
                    cmd.Parameters.AddWithValue("@maKH", maKH);
                    cmd.Parameters.AddWithValue("@ngayLap", ngayLap);
                    cmd.Parameters.AddWithValue("@tongTien", tongTien);
                    cmd.Parameters.AddWithValue("@tinhTrangHoaDon", tinhTrangHoaDon);

                    int result = cmd.ExecuteNonQuery();
                    return result > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                closeConnection();
            }
        }


        // Xóa hóa đơn
        public bool XoaHoaDon(int maHD)
        {
            try
            {
                openConnection();
                string query = "DELETE FROM HOADON WHERE MaHD = @maHD";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@maHD", maHD);
                    int result = cmd.ExecuteNonQuery();
                    return result > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                closeConnection();
            }
        }

        // Tìm kiếm hóa đơn theo Mã HD
        public DataTable TimKiemHoaDon(string maHD)
        {
            DataTable dt = new DataTable();
            try
            {
                openConnection();
                string query = "SELECT * FROM HOADON WHERE MaHD LIKE @maHD";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@maHD", "%" + maHD + "%");
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        dt.Load(reader);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                closeConnection();
            }
            return dt;
        }

        // Cập nhật trạng thái thanh toán của hóa đơn
        public bool ThanhToanHoaDon(int maHD)
        {
            try
            {
                openConnection();
                string query = "UPDATE HOADON SET TinhTrangHoaDon = 1 WHERE MaHD = @maHD";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@maHD", maHD);
                    int result = cmd.ExecuteNonQuery();
                    return result > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                closeConnection();
            }
        }

        // Cập nhật trạng thái chưa thanh toán
        public bool HuyThanhToanHoaDon(int maHD)
        {
            try
            {
                openConnection();
                string query = "UPDATE HOADON SET TinhTrangHoaDon = 0 WHERE MaHD = @maHD";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@maHD", maHD);
                    int result = cmd.ExecuteNonQuery();
                    return result > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                closeConnection();
            }
        }
    }
}
