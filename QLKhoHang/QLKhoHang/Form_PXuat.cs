﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLKhoHang
{
    public partial class Form_PXuat : Form
    {
        public Form_PXuat()
        {
            InitializeComponent();
        }
        //Trung:"Data Source=TUANTRUNG\SQLEXPRESS;Initial Catalog=QLVali;Integrated Security=True"
        //Cường:
        //Đạt:
        //Sao:

        SqlConnection con = new SqlConnection(@"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=QLVali;Integrated Security=True");
        private void KetNoiCSDL()
        {
            string sql = "select * from PHIEUXUAT"; //lấy hết dữ liệu trong bảng hàng tồn
            SqlCommand com = new SqlCommand(sql, con);// chúng ta bắt đầu truy vấn
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);//chuyển dữ liệu về
            SqlDataReader dr = com.ExecuteReader();
            DataTable dt = new DataTable();
            //tạo kho  ảo để lưu dữ liệu
            dt.Load(dr);//đổ dữ liệu vào kho
            dataGridView1.DataSource = dt;
        }
        private void LoadData()
        {
            textBox1.DataBindings.Clear();
            textBox1.DataBindings.Add("Text", dataGridView1.DataSource, "Idphieux");
            textBox2.DataBindings.Clear();
            textBox2.DataBindings.Add("Text", dataGridView1.DataSource, "Idhang");
            textBox3.DataBindings.Clear();
            textBox3.DataBindings.Add("Text", dataGridView1.DataSource, "Tenhang");
            textBox4.DataBindings.Clear();
            textBox4.DataBindings.Add("Text", dataGridView1.DataSource, "Dvt");
            textBox5.DataBindings.Clear();
            textBox5.DataBindings.Add("Text", dataGridView1.DataSource, "Luongxuat");
            textBox6.DataBindings.Clear();
            textBox6.DataBindings.Add("Text", dataGridView1.DataSource, "Giaxuat");
            textBox7.DataBindings.Clear();
            textBox7.DataBindings.Add("Text", dataGridView1.DataSource, "Thanhtien");
        }
        private void Clear()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";

        }
        private bool mapn()
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Mã phiếu xuất không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private bool mah()
        {
            if (textBox2.Text == "")
            {
                MessageBox.Show("Mã hàng xuất không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private bool kiemtra()
        {
            if (mapn() && mah())
            {
                return true;
            }
            return false;
        }
        private void trangChủToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Form_Main TRANGCHU = new Form_Main();
            TRANGCHU.qLHANGToolStripMenuItem.Enabled = true;
            TRANGCHU.nCCToolStripMenuItem.Enabled = true;
            TRANGCHU.pHIEUNHAPToolStripMenuItem.Enabled = true;
            TRANGCHU.pHIEUXUATToolStripMenuItem.Enabled = true;
            TRANGCHU.đăngNhậpToolStripMenuItem.Enabled = false;
            TRANGCHU.thoátToolStripMenuItem.Enabled = true;
            TRANGCHU.label1.Visible = true;
        }

        private void hàngTồnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Form_HTon HANGTON = new Form_HTon();
            HANGTON.Show();
        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Form_NCC NHACUNGCAP = new Form_NCC();
            NHACUNGCAP.Show();
        }

        private void nhậpHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Form_HNhap NHAPHANG = new Form_HNhap();
            NHAPHANG.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cậpNhậtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Phiên bản hiện tại là phiên bản 1.Hiện chưa có phiên bản mới", "Cập nhật");
        }

        private void chiTiếtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nhóm Quản Lý Bán Hàng Vali. Lớp : CDTHK17", "Chi tiết");
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            con.Open();//chúng ta mở kết nối
            KetNoiCSDL();//gọi lại hàm kết nối
            LoadData();//Gọi lại hàm load dữ lieu
            button2.Enabled = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form6_FormClosing(object sender, FormClosingEventArgs e)
        {
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clear();
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String Them = "INSERT INTO PHIEUXUAT VALUES (@Idphieux,@Idhang,@Tenhang,@Dvt,@Luongxuat,@Giaxuat,@Thanhtien)";
            SqlCommand add = new SqlCommand(Them, con);
            if (kiemtra())
            {
                add.Parameters.AddWithValue("Idphieux", textBox1.Text);
                add.Parameters.AddWithValue("Idhang", textBox2.Text);
                add.Parameters.AddWithValue("Tenhang", textBox3.Text);
                add.Parameters.AddWithValue("Dvt", textBox4.Text);
                add.Parameters.AddWithValue("Luongxuat", textBox5.Text);
                add.Parameters.AddWithValue("Giaxuat", textBox6.Text);
                add.Parameters.AddWithValue("Thanhtien", textBox7.Text);
            }
            try
            {
                add.ExecuteNonQuery();
                MessageBox.Show("Thành công", "Xuất hàng trong kho", MessageBoxButtons.OK, MessageBoxIcon.Information);
                KetNoiCSDL();
                LoadData();
                button3.Enabled = true;
                button4.Enabled = true;
            }
            catch (SqlException exc)
            {
                if (exc.Number == 2627)
                {
                    MessageBox.Show("Mã hàng đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Lỗi không xác định:\n" + exc.Message, "Lỗi" + exc.Number, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            button2.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            String Timkiem = "SELECT * FROM PHIEUXUAT WHERE Tenhang LIKE '%'+@Tenhang+'%'";
            SqlCommand find = new SqlCommand(Timkiem, con);
            find.Parameters.AddWithValue("Tenhang", textBox8.Text);
            find.Parameters.AddWithValue("Idphieux", textBox1.Text);
            find.Parameters.AddWithValue("Idhang", textBox2.Text);
            find.Parameters.AddWithValue("Dvt", textBox4.Text);
            find.Parameters.AddWithValue("Luongxuat", textBox5.Text);
            find.Parameters.AddWithValue("Giaxuat", textBox6.Text);
            find.Parameters.AddWithValue("Thanhtien", textBox7.Text);
            SqlDataReader dr = find.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            LoadData();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            String Sua = "DELETE FROM PHIEUXUAT WHERE Idphieux = @Idphieux AND Idhang = @Idhang";
            SqlCommand del = new SqlCommand(Sua, con);
            if (kiemtra())
            {
                del.Parameters.AddWithValue("Idphieux", textBox1.Text);
                del.Parameters.AddWithValue("Idhang", textBox2.Text);
                del.Parameters.AddWithValue("Tenhang", textBox3.Text);
                del.Parameters.AddWithValue("Dvt", textBox4.Text);
                del.Parameters.AddWithValue("Luongxuat", textBox5.Text);
                del.Parameters.AddWithValue("Giaxuat", textBox6.Text);
                del.Parameters.AddWithValue("Thanhtien", textBox7.Text);
                try
                {
                    del.ExecuteNonQuery();
                    MessageBox.Show("Xóa thành công", "Xóa nhà cung cấp", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    KetNoiCSDL();
                    LoadData();
                }
                catch (SqlException exc)
                {
                    MessageBox.Show("Lỗi không xác định:\n" + exc.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("Chọn phiếu xuất cần xóa", "Xóa hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("lêu lêu k in=))))");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String Sua = "UPDATE PHIEUXUAT SET Idhang = @Idhang,Tenhang = @Tenhang,Dvt = @Dvt,Luongxuat = @Luongxuat,Giaxuat = @Giaxuat,Thanhtien = @Thanhtien WHERE Idphieux = @Idphieux";
            SqlCommand upd = new SqlCommand(Sua, con);
            if (kiemtra())
            {
                upd.Parameters.AddWithValue("Idphieux", textBox1.Text);
                upd.Parameters.AddWithValue("Idhang", textBox2.Text);
                upd.Parameters.AddWithValue("Tenhang", textBox3.Text);
                upd.Parameters.AddWithValue("Dvt", textBox4.Text);
                upd.Parameters.AddWithValue("Luongxuat", textBox5.Text);
                upd.Parameters.AddWithValue("Giaxuat", textBox6.Text);
                upd.Parameters.AddWithValue("Thanhtien", textBox7.Text);
            }
            try
            {
                upd.ExecuteNonQuery();
                MessageBox.Show("Cập nhật thành công", "Sửa thông tin xuất trong kho", MessageBoxButtons.OK, MessageBoxIcon.Information);
                KetNoiCSDL();
                LoadData();
            }
            catch (SqlException exc)
            {
                if (exc.Number == 2627)
                {
                    MessageBox.Show("Mã phiếu xuất đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Lỗi không xác định:\n" + exc.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
