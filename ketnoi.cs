using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BAITAPNHOMSHOPBANGIAY
{
    internal class ketnoi
    {
        public SqlConnection conn;

        public void openConnection()
        {
            conn = new SqlConnection("Server=(localdb)\\MSSQLLocalDB;Database=QLBG;Integrated Security=True");
            conn.Open();
        }
        public void closeConnection()
        {
            conn.Close();
        }
        public DataTable GetTable()
        {
            DataTable dt = new DataTable();
            //lấy dữ liệu 
            try
            {
                openConnection();
                string query = $"SELECT * FROM KHACHHANG";
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
        public bool themkh(int makh, string hoten, string dienthoai,string email)
        {
            try
            {
                openConnection();
                string query = "INSERT INTO KhachHang(MaKH,TenKH,SoDT,Email) VALUES(@e,@a,@b,@c)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@e", makh);
                    cmd.Parameters.AddWithValue("@a", hoten);
                    cmd.Parameters.AddWithValue("@b", dienthoai);
                    cmd.Parameters.AddWithValue("@c", email);
                  

                    int ketqua = cmd.ExecuteNonQuery();
                    return ketqua > 0;
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
        public bool suakh(int makh, string hoten, string dienthoai, string email)
        {
            try
            {
                openConnection();
                string query = "UPDATE KHACHHANG SET TenKH=@a,SoDT=@b,Email=@c WHERE MaKH=@e";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@e", makh);
                    cmd.Parameters.AddWithValue("@a", hoten);
                    cmd.Parameters.AddWithValue("@b", dienthoai);
                    cmd.Parameters.AddWithValue("@c", email);
                    int ketqua = cmd.ExecuteNonQuery();
                    return ketqua > 0;
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
        public bool xoakh(int makh)
        {
            try
            {
                openConnection();
                string query = "DELETE FROM KHACHHANG WHERE MaKH=@a";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@a", makh);
                    int ketqua = cmd.ExecuteNonQuery();
                    return ketqua > 0;
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
        public DataTable timkiem(string tk)
        {
            DataTable dt = new DataTable();
            try
            {
                openConnection();
                string query = "SELECT * FROM KHACHHANG WHERE TenKH like @tk";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@tk", "%" + tk + "%");
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
    }
}
