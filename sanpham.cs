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
    public partial class sanpham : Form
    {
        ketnoi1 kn1=new ketnoi1 ();
        public sanpham()
        {
            InitializeComponent();
            load();
        }

        public void load()
        {
            dataGridView1.DataSource = kn1.GetTable();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            int masp = int.Parse(txtmasp.Text);
            string hoten = txthoten.Text;
            string loaisp = txtloaisp.Text;
            decimal gia = decimal.Parse(txtgia.Text);
            int kichco =int .Parse( txtkichco.Text);
            string mau = comboBox1.SelectedItem.ToString();
            int soluong =int.Parse(txtsoluong.Text);
            if (kn1.themkh(masp, hoten, loaisp, gia,kichco,mau,soluong))
            {
                MessageBox.Show("Thêm thành công ", "Thông báo", MessageBoxButtons.OK);
                load();
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            int masp = int.Parse(txtmasp.Text);
            string hoten = txthoten.Text;
            string loaisp = txtloaisp.Text;
            decimal gia = decimal.Parse(txtgia.Text);
            int kichco = int.Parse(txtkichco.Text);
            string mau = comboBox1.SelectedValue.ToString();
            int soluong = int.Parse(txtsoluong.Text);
            if (kn1.suakh(masp, hoten, loaisp, gia, kichco, mau, soluong))
            {
                MessageBox.Show("Sửa thành công ", "Thông báo", MessageBoxButtons.OK);
                load();
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            int masp = int.Parse(txtmasp.Text);
            if (kn1.xoakh(masp))
            {
                MessageBox.Show("Xóa thành công ", "Thông báo");
                load();
            }
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            string timkiem = txttimkiem.Text;
            dataGridView1.DataSource = kn1.timkiem(timkiem);
        }
    }
}
