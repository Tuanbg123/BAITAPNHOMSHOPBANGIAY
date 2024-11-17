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
    internal class ketnoi1
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
                string query = $"SELECT * FROM SANPHAM";
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
        public bool themkh(int masp, string tensp, string loaisp, decimal gia,int kichco,string mau,int soluong)
        {
            try
            {
                openConnection();
                string query = "INSERT INTO SANPHAM(MaSP,TenSP,LoaiSP,Gia,KichCo,Mau,SoLuongTon) VALUES(@g,@a,@b,@c,@d,@e,@f)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@g", masp);
                    cmd.Parameters.AddWithValue("@a", tensp);
                    cmd.Parameters.AddWithValue("@b", loaisp);
                    cmd.Parameters.AddWithValue("@c", gia);
                    cmd.Parameters.AddWithValue("@d", kichco);
                    cmd.Parameters.AddWithValue("@e", mau);
                    cmd.Parameters.AddWithValue("@f", soluong);


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
        public bool suakh(int masp, string tensp, string loaisp, decimal gia, int kichco, string mau, int soluong)
        {
            try
            {
                openConnection();
                string query = "UPDATE SANPHAM SET TenSP=@a,LoaiSP=@b,Gia=@c,KichCo=@d,Mau=@e,SoLuong=@f WHERE MaSP=@g";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@g", masp);
                    cmd.Parameters.AddWithValue("@a", tensp);
                    cmd.Parameters.AddWithValue("@b", loaisp);
                    cmd.Parameters.AddWithValue("@c", gia);
                    cmd.Parameters.AddWithValue("@d", kichco);
                    cmd.Parameters.AddWithValue("@e", mau);
                    cmd.Parameters.AddWithValue("@f", soluong);
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
                string query = "DELETE FROM SANPHAM WHERE MaSP=@a";
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
                string query = "SELECT * FROM SANPHAM WHERE TenSP like @tk";
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
