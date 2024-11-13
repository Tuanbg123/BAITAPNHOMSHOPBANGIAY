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
    public partial class khachhang : Form
    {
        ketnoi kn=new ketnoi();
        public khachhang()
        {
            InitializeComponent();
            load();
        }
        public void load()
        {
            dataGridView1.DataSource = kn.GetTable();
        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            int makh = int.Parse(txtmakh.Text);
            string hoten = txthoten.Text;
            string dienthoai = txtdienthoai.Text;
            string email = txtemail.Text;
            if (kn.themkh(makh, hoten, dienthoai,email))
            {
                MessageBox.Show("Thêm thành công ", "Thông báo", MessageBoxButtons.OK);
                load();
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            int makh = int.Parse(txtmakh.Text);
            string hoten = txthoten.Text;
            string dienthoai = txtdienthoai.Text;
            string email = txtemail.Text;
            if (kn.suakh(makh, hoten, dienthoai, email))
            {
                MessageBox.Show("Sửa thành công ", "Thông báo");
                load();
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            int makh = int.Parse(txtmakh.Text);
            if (kn.xoakh(makh))
            {
                MessageBox.Show("Xóa thành công ", "Thông báo");
                load();
            }
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            string timkiem = txttimkiem.Text;
            dataGridView1.DataSource = kn.timkiem(timkiem);
        }

        private void khachhang_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtmakh.Text = row.Cells["MaKH"].Value.ToString();
                txthoten.Text = row.Cells["TenKH"].Value.ToString();
              
                txtdienthoai.Text = row.Cells["SoDT"].Value.ToString();
                txtemail.Text = row.Cells["Email"].Value.ToString();
            }
        }
    }
}
