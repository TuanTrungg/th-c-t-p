using System;
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
    public partial class Form_NCC : Form
    {
        public Form_NCC()
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
            string sql = "select * from NCC"; //lấy hết dữ liệu trong bảng hàng tồn
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
            textBox1.DataBindings.Add("Text", dataGridView1.DataSource, "Idncc");
            textBox2.DataBindings.Clear();
            textBox2.DataBindings.Add("Text", dataGridView1.DataSource, "Tenncc");
            textBox3.DataBindings.Clear();
            textBox3.DataBindings.Add("Text", dataGridView1.DataSource, "Diachi");
            textBox4.DataBindings.Clear();
            textBox4.DataBindings.Add("Text", dataGridView1.DataSource, "Sdt");
        }
        private void Clear()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }
        private bool mancc()
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Mã nhà cung cấp không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private bool tenncc()
        {
            if (textBox2.Text == "")
            {
                MessageBox.Show("Tên nhà cung cấp không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private bool kiemtra()
        {
            if (mancc() && tenncc())
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

        private void quảnLýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Form_Main Trangchu = new Form_Main();
            Trangchu.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void hàngTồnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Form_HTon HANGTON = new Form_HTon();
            HANGTON.Show();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            con.Open();//chúng ta mở kết nối
            KetNoiCSDL();//gọi lại hàm kết nối
            LoadData();//Gọi lại hàm load dữ liệu
            button2.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clear();
            button3.Enabled = false;
            button4.Enabled = false;
            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String Them = "INSERT INTO NCC VALUES (@Idncc,@Tenncc,@Diachi,@Sdt)";
            SqlCommand add = new SqlCommand(Them, con);
            if (kiemtra())
            {
                add.Parameters.AddWithValue("Idncc", textBox1.Text);
                add.Parameters.AddWithValue("Tenncc", textBox2.Text);
                add.Parameters.AddWithValue("Diachi", textBox3.Text);
                add.Parameters.AddWithValue("Sdt", textBox4.Text);
            }
            try
            {
                add.ExecuteNonQuery();
                MessageBox.Show("Thành công", "Thêm nhà cung cấp", MessageBoxButtons.OK, MessageBoxIcon.Information);
                KetNoiCSDL();
                LoadData();
                button3.Enabled = true;
                button4.Enabled = true;
            }
            catch (SqlException exc)
            {
                if (exc.Number == 2627)
                {
                    MessageBox.Show("Mã nhà cung cấp đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Lỗi không xác định:\n" + exc.Message, "Lỗi" + exc.Number, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            button2.Enabled = false; 
        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String Sua = "UPDATE NCC SET Tenncc = @Tenncc,Diachi = @Diachi,Sdt = @Sdt WHERE Idncc = @Idncc";
            SqlCommand upd = new SqlCommand(Sua,con);
            if(kiemtra())
            {
                upd.Parameters.AddWithValue("Idncc", textBox1.Text);
                upd.Parameters.AddWithValue("Tenncc", textBox2.Text);
                upd.Parameters.AddWithValue("Diachi", textBox3.Text);
                upd.Parameters.AddWithValue("Sdt", textBox4.Text);
            }
            try
            {
                upd.ExecuteNonQuery();
                MessageBox.Show("Cập nhật thành công", "Sửa thông tin nhà cung cấp", MessageBoxButtons.OK, MessageBoxIcon.Information);
                KetNoiCSDL();
                LoadData();
            }
            catch (SqlException exc)
            {
                if (exc.Number == 2627)
                {
                    MessageBox.Show("Mã nhà cung cấp đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Lỗi không xác định:\n" + exc.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            String Sua = "DELETE FROM NCC WHERE Idncc = @Idncc";
            SqlCommand del = new SqlCommand(Sua, con);
            if (kiemtra())
            {
                del.Parameters.AddWithValue("Idncc", textBox1.Text);
                del.Parameters.AddWithValue("Tenncc", textBox2.Text);
                del.Parameters.AddWithValue("Diachi", textBox3.Text);
                del.Parameters.AddWithValue("Sdt", textBox4.Text);
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
                MessageBox.Show("Chọn hàng cần xóa", "Xóa hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            String Timkiem = "SELECT * FROM NCC WHERE Tenncc LIKE '%'+@Idncc+'%'";
            SqlCommand find = new SqlCommand(Timkiem, con);
            find.Parameters.AddWithValue("Idncc", textBox5.Text);
            find.Parameters.AddWithValue("Tenncc", textBox2.Text);
            find.Parameters.AddWithValue("Diachi", textBox3.Text);
            find.Parameters.AddWithValue("Sdt", textBox4.Text);
            SqlDataReader dr = find.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            LoadData();
        }

        private void nhậpHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Form_HNhap NHAPHANG = new Form_HNhap();
            NHAPHANG.Show();
        }

        private void chiTiếtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nhóm Quản Lý Bán Hàng Vali. Lớp : CDTHK17", "Chi tiết");
        }

        private void cậpNhậtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Phiên bản hiện tại là phiên bản 1.Hiện chưa có phiên bản mới", "Cập nhật");
        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void xuấtHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Form_PXuat XUATHANG = new Form_PXuat();
            XUATHANG.Show();
        }

        }

    }

