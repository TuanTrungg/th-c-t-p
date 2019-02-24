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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-ALS1UHC\SQLEXPRESS;Initial Catalog=TTNhom_QL;Integrated Security=True");
        private void KetNoiCSDL()
        {
            string sql = "select * from PHIEUNHAP"; //lấy hết dữ liệu trong bảng hàng tồn
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
            textBox1.DataBindings.Add("Text", dataGridView1.DataSource, "Idphieun");
            textBox2.DataBindings.Clear();
            textBox2.DataBindings.Add("Text", dataGridView1.DataSource, "Idhang");
            textBox3.DataBindings.Clear();
            textBox3.DataBindings.Add("Text", dataGridView1.DataSource, "Idncc");
            textBox4.DataBindings.Clear();
            textBox4.DataBindings.Add("Text", dataGridView1.DataSource, "Tenhang");
            textBox5.DataBindings.Clear();
            textBox5.DataBindings.Add("Text", dataGridView1.DataSource, "Dvt");
            textBox6.DataBindings.Clear();
            textBox6.DataBindings.Add("Text", dataGridView1.DataSource, "Luongnhap");
            textBox7.DataBindings.Clear();
            textBox7.DataBindings.Add("Text", dataGridView1.DataSource, "Gianhap");
            textBox8.DataBindings.Clear();
            textBox8.DataBindings.Add("Text", dataGridView1.DataSource, "Thanhtien");
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
                MessageBox.Show("Mã phiếu nhập không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private bool mah()
        {
            if (textBox2.Text == "")
            {
                MessageBox.Show("Mã hàng nhập không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private bool mancc()
        {
            if (textBox3.Text == "")
            {
                MessageBox.Show("Mã nhà cung cấp không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private bool kiemtra()
        {
            if (mapn() && mah() && mancc() )
            {
                return true;
            }
            return false;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            con.Open();//chúng ta mở kết nối
            KetNoiCSDL();//gọi lại hàm kết nối
            LoadData();//Gọi lại hàm load dữ liệu
            button2.Enabled = false;
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void hàngTồnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Form3 HANGTON = new Form3();
            HANGTON.Show();
        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Form4 NHACUNGCAP = new Form4();
            NHACUNGCAP.Show();
        }

        private void trangChủToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Form2 TRANGCHU = new Form2();
            TRANGCHU.qLHANGToolStripMenuItem.Enabled = true;
            TRANGCHU.nCCToolStripMenuItem.Enabled = true;
            TRANGCHU.pHIEUNHAPToolStripMenuItem.Enabled = true;
            TRANGCHU.pHIEUXUATToolStripMenuItem.Enabled = true;
            TRANGCHU.đăngNhậpToolStripMenuItem.Enabled = false;
            TRANGCHU.thoátToolStripMenuItem.Enabled = true;
            TRANGCHU.label1.Visible = true;
        }

        private void Form5_FormClosing(object sender, FormClosingEventArgs e)
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
           
        }

        private void chiTiếtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nhóm Quản Lý Bán Hàng Vali. Lớp : CDTHK18", "Chi tiết");
        }

        private void cậpNhậtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Phiên bản hiện tại là phiên bản 1.Hiện chưa có phiên bản mới", "Cập nhật");
        }

        private void Form5_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void xuấtHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Form6 XUATHANG = new Form6();
            XUATHANG.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            String Timkiem = "SELECT * FROM PHIEUNHAP WHERE Tenhang LIKE '%'+@Tenhang+'%'";
            SqlCommand find = new SqlCommand(Timkiem, con);
            find.Parameters.AddWithValue("Tenhang", textBox9.Text);
            find.Parameters.AddWithValue("Idphieun", textBox1.Text);
            find.Parameters.AddWithValue("Idhang", textBox2.Text);
            find.Parameters.AddWithValue("Idncc", textBox3.Text);
            find.Parameters.AddWithValue("Dvt", textBox5.Text);
            find.Parameters.AddWithValue("Luongnhap", textBox6.Text);
            find.Parameters.AddWithValue("Gianhap", textBox7.Text);
            find.Parameters.AddWithValue("Thanhtien", textBox8.Text);
            SqlDataReader dr = find.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            LoadData();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            String Sua = "DELETE FROM HANGTON WHERE tenhang = @tenhang";
            SqlCommand del = new SqlCommand(Sua, con);
            if (kiemtra())
            {
                del.Parameters.AddWithValue("Idhang", textBox1.Text);
                del.Parameters.AddWithValue("Tenhang", textBox2.Text);
                del.Parameters.AddWithValue("Dvt", textBox3.Text);
                del.Parameters.AddWithValue("Soluong", textBox4.Text);
                del.Parameters.AddWithValue("Gianhap", textBox5.Text);
                del.Parameters.AddWithValue("Giaxuat", textBox6.Text);

                try
                {
                    del.ExecuteNonQuery();
                    MessageBox.Show("Xóa thành công", "Xóa hàng trong kho", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    KetNoiCSDL();
                    LoadData();
                }
                catch (SqlException exc)
                {
                    MessageBox.Show("Lỗi không xác định:\n" + exc.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("Chọn hàng cần xóa", "Xóa hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);
        
    }
    }
}
