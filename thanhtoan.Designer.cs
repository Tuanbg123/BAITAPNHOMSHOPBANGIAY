namespace BAITAPNHOMSHOPBANGIAY
{
    partial class thanhtoan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnthanhtoan = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtkichco = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtloaisp = new System.Windows.Forms.TextBox();
            this.txtgia = new System.Windows.Forms.TextBox();
            this.txttensp = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.btnthem = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.txtmachitiet = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txttenkhachhang = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 473);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1490, 339);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(475, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chọn sản phẩm";
            // 
            // btnthanhtoan
            // 
            this.btnthanhtoan.Location = new System.Drawing.Point(685, 387);
            this.btnthanhtoan.Name = "btnthanhtoan";
            this.btnthanhtoan.Size = new System.Drawing.Size(110, 49);
            this.btnthanhtoan.TabIndex = 6;
            this.btnthanhtoan.Text = "Thanh toán";
            this.btnthanhtoan.UseVisualStyleBackColor = true;
            this.btnthanhtoan.Click += new System.EventHandler(this.btnthanhtoan_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Đỏ",
            "Xanh dương",
            "Xanh lá",
            "Vàng"});
            this.comboBox1.Location = new System.Drawing.Point(758, 176);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(231, 28);
            this.comboBox1.TabIndex = 87;
            // 
            // txtkichco
            // 
            this.txtkichco.Location = new System.Drawing.Point(758, 124);
            this.txtkichco.Name = "txtkichco";
            this.txtkichco.Size = new System.Drawing.Size(231, 26);
            this.txtkichco.TabIndex = 86;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(559, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 29);
            this.label8.TabIndex = 85;
            this.label8.Text = "Kích cỡ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(559, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 29);
            this.label7.TabIndex = 84;
            this.label7.Text = "Màu";
            // 
            // txtloaisp
            // 
            this.txtloaisp.Location = new System.Drawing.Point(278, 296);
            this.txtloaisp.Name = "txtloaisp";
            this.txtloaisp.ReadOnly = true;
            this.txtloaisp.Size = new System.Drawing.Size(231, 26);
            this.txtloaisp.TabIndex = 83;
            // 
            // txtgia
            // 
            this.txtgia.Location = new System.Drawing.Point(758, 230);
            this.txtgia.Name = "txtgia";
            this.txtgia.ReadOnly = true;
            this.txtgia.Size = new System.Drawing.Size(231, 26);
            this.txtgia.TabIndex = 82;
            // 
            // txttensp
            // 
            this.txttensp.Location = new System.Drawing.Point(278, 236);
            this.txttensp.Name = "txttensp";
            this.txttensp.ReadOnly = true;
            this.txttensp.Size = new System.Drawing.Size(231, 26);
            this.txttensp.TabIndex = 81;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(77, 295);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 29);
            this.label6.TabIndex = 79;
            this.label6.Text = "Loại sản phẩm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(559, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 29);
            this.label5.TabIndex = 78;
            this.label5.Text = "Giá";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(77, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 29);
            this.label3.TabIndex = 77;
            this.label3.Text = "Tên sản phẩm ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(77, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 29);
            this.label2.TabIndex = 76;
            this.label2.Text = "Mã SP";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(557, 295);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 29);
            this.label9.TabIndex = 88;
            this.label9.Text = "Số lượng ";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(758, 300);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(231, 26);
            this.numericUpDown1.TabIndex = 90;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(278, 177);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(231, 28);
            this.comboBox2.TabIndex = 91;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(207, 393);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(89, 36);
            this.btnthem.TabIndex = 92;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(476, 441);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(443, 29);
            this.label4.TabIndex = 93;
            this.label4.Text = "Danh sách sản phẩm chọn để thanh toán";
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(343, 393);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(89, 36);
            this.btnsua.TabIndex = 94;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(506, 393);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(89, 36);
            this.btnxoa.TabIndex = 95;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // txtmachitiet
            // 
            this.txtmachitiet.Location = new System.Drawing.Point(278, 124);
            this.txtmachitiet.Name = "txtmachitiet";
            this.txtmachitiet.Size = new System.Drawing.Size(231, 26);
            this.txtmachitiet.TabIndex = 97;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(79, 127);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 29);
            this.label10.TabIndex = 96;
            this.label10.Text = "Mã chi tiết";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(79, 70);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(174, 29);
            this.label11.TabIndex = 100;
            this.label11.Text = "Mã khách hàng";
            // 
            // txttenkhachhang
            // 
            this.txttenkhachhang.Location = new System.Drawing.Point(758, 67);
            this.txttenkhachhang.Name = "txttenkhachhang";
            this.txttenkhachhang.ReadOnly = true;
            this.txttenkhachhang.Size = new System.Drawing.Size(231, 26);
            this.txttenkhachhang.TabIndex = 99;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(559, 70);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(184, 29);
            this.label12.TabIndex = 98;
            this.label12.Text = "Tên khách hàng";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(278, 71);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(231, 28);
            this.comboBox3.TabIndex = 101;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // thanhtoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(1907, 1045);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txttenkhachhang);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtmachitiet);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtkichco);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtloaisp);
            this.Controls.Add(this.txtgia);
            this.Controls.Add(this.txttensp);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnthanhtoan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "thanhtoan";
            this.Text = "thanhtoan";
            this.Load += new System.EventHandler(this.thanhtoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnthanhtoan;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtkichco;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtloaisp;
        private System.Windows.Forms.TextBox txtgia;
        private System.Windows.Forms.TextBox txttensp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.TextBox txtmachitiet;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txttenkhachhang;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBox3;
    }
}