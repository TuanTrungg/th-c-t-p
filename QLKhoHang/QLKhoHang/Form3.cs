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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-ALS1UHC\SQLEXPRESS;Initial Catalog=TTNhom_QL;Integrated Security=True");
        private void KetNoiCSDL()
        {
            string sql = "select * from HANGTON"; //lấy hết dữ liệu trong bảng hàng tồn
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
            textBox1.DataBindings.Add("Text", dataGridView1.DataSource, "Idhang");
            textBox2.DataBindings.Clear();
            textBox2.DataBindings.Add("Text", dataGridView1.DataSource, "Tenhang");
            textBox3.DataBindings.Clear();
            textBox3.DataBindings.Add("Text", dataGridView1.DataSource, "Dvt");
            textBox4.DataBindings.Clear();
            textBox4.DataBindings.Add("Text", dataGridView1.DataSource, "Soluong");
            textBox5.DataBindings.Clear();
            textBox5.DataBindings.Add("Text", dataGridView1.DataSource, "Gianhap");
            textBox6.DataBindings.Clear();
            textBox6.DataBindings.Add("Text", dataGridView1.DataSource, "Giaxuat");
        }
        private void Clear()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            con.Open();//chúng ta mở kết nối
            KetNoiCSDL();//gọi lại hàm kết nối
            LoadData();//Gọi lại hàm load dữ liệu
            button2.Enabled = false;
        }
         private bool mahang()
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("ma hang khong duoc de trong", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
         private bool tenhang()
         {
             if (textBox2.Text == "")
             {
                 MessageBox.Show("Tên hàng không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 return false;
             }
             return true;
         }
         private bool kiemtra()
         {
             if (mahang() && tenhang())
             {
                 return true;
             }
             return false;
         }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.CurrentRow.Selected = true;
            }
            catch
            { }
        }

        
        private void ghvvToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void button1_Click(object sender, EventArgs e)
        {
            Clear();
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            textBox6.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button2.Enabled = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
             String Sua = "UPDATE HANGTON SET Tenhang = @Tenhang,Dvt = @Dvt,Soluong = @Soluong,Gianhap = @Gianhap,Giaxuat = @Giaxuat WHERE Idhang = @Idhang";
            SqlCommand upd = new SqlCommand(Sua,con);
            if(kiemtra())
            {
                upd.Parameters.AddWithValue("Idhang", textBox1.Text);
                upd.Parameters.AddWithValue("Tenhang", textBox2.Text);
                upd.Parameters.AddWithValue("Dvt", textBox3.Text);
                upd.Parameters.AddWithValue("Soluong", textBox4.Text);
                upd.Parameters.AddWithValue("Gianhap", textBox5.Text);
                upd.Parameters.AddWithValue("Giaxuat", textBox6.Text);
            }
            try
            {
                upd.ExecuteNonQuery();
                MessageBox.Show("Cập nhật thành công", "Sửa thông tin hàng trong kho", MessageBoxButtons.OK, MessageBoxIcon.Information);
                KetNoiCSDL();
                LoadData();
            }
            catch (SqlException exc)
            {
                if (exc.Number == 2627)
                {
                    MessageBox.Show("Mã hàng đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Lỗi không xác định:\n" + exc.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            String Sua = "DELETE FROM HANGTON WHERE Idhang = @Idhang";
            SqlCommand del = new SqlCommand(Sua,con);
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

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_KeyUp(object sender, KeyEventArgs e)
        {
        }

        public SqlDataAdapter adapter { get; set; }

        private void button5_Click_1(object sender, EventArgs e)
        {
            String Timkiem = "SELECT * FROM HANGTON WHERE Tenhang LIKE '%'+@Idhang+'%'";
            SqlCommand find = new SqlCommand(Timkiem, con);
            find.Parameters.AddWithValue("Idhang", textBox7.Text);
            find.Parameters.AddWithValue("Tenhang", textBox2.Text);
            find.Parameters.AddWithValue("Dvt", textBox3.Text);
            find.Parameters.AddWithValue("Soluong", textBox4.Text);
            find.Parameters.AddWithValue("Gianhap", textBox5.Text);
            find.Parameters.AddWithValue("Giaxuat", textBox6.Text);
            SqlDataReader dr = find.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            LoadData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String Them = "INSERT INTO HANGTON VALUES (@Idhang,@Tenhang,@Dvt,@Soluong,@Gianhap,@Giaxuat)";
            SqlCommand add = new SqlCommand(Them, con);
            if (kiemtra())
            {
                add.Parameters.AddWithValue("Idhang", textBox1.Text);
                add.Parameters.AddWithValue("Tenhang", textBox2.Text);
                add.Parameters.AddWithValue("Dvt", textBox3.Text);
                add.Parameters.AddWithValue("Soluong", textBox4.Text);
                add.Parameters.AddWithValue("Gianhap", textBox5.Text);
                add.Parameters.AddWithValue("Giaxuat", textBox6.Text);
            }
            try
            {
                add.ExecuteNonQuery();
                MessageBox.Show("Thành công", "Thêm hàng trong kho", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Form4 NHACUNGCAP = new Form4();
            NHACUNGCAP.Show();
        }

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nhậpHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Form5 NHAPHANG = new Form5();
            NHAPHANG.Show();
        }

        private void chiTiếtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Nhóm Quản Lý Bán Hàng Vali. Lớp : CDTHK17", "Chi tiết");
        }

        private void cậpNhậtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Phiên bản hiện tại là phiên bản 1.Hiện chưa có phiên bản mới", "Cập nhật");
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void xuấtHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Form6 XUATHANG = new Form6();
            XUATHANG.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
