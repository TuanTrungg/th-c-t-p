using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKhoHang
{
    public partial class Form1 : Form
    {
        public string tendangnhap ;
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dangnhap_Click(object sender, EventArgs e)
        {
            if (this.ten.Text == "admin" & this.pass.Text == "admin")
            {
                tendangnhap = this.ten.Text;
                MessageBox.Show("Đăng nhập thành công.Chúc có một ngày làm việc vui vẻ .", "Thành công");

                Hide();
                Form2 QLKHO = new Form2();
                QLKHO.Show();
                QLKHO.qLHANGToolStripMenuItem.Enabled = true;
                QLKHO.nCCToolStripMenuItem.Enabled = true;
                QLKHO.pHIEUNHAPToolStripMenuItem.Enabled = true;
                QLKHO.pHIEUXUATToolStripMenuItem.Enabled = true;
                QLKHO.đăngNhậpToolStripMenuItem.Enabled = false;
                QLKHO.thoátToolStripMenuItem.Enabled = true;
                QLKHO.label1.Text = "Chào mừng " + tendangnhap + " sử dụng chương trình";

            }

            else
            {
                ten.Text = "";
                pass.Text = "";
                MessageBox.Show("Tên hoặc mật khẩu sai. Vui lòng nhập lại.", "Thông báo");
            }
            
        }

        private void thoat_Click(object sender, EventArgs e)
        {
            DialogResult thongbao ;
                thongbao =(MessageBox.Show("Bạn có chắc chắn muốn thoát ?", "Hỏi lại",MessageBoxButtons.YesNo,MessageBoxIcon.Warning));
                if (thongbao == DialogResult.Yes)
                    Application.Exit();
                else
                {
                    Hide();
                    Form2 QLKHO = new Form2();
                    QLKHO.Show();
                }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Hide();
            Form2 QLKHO = new Form2();
            QLKHO.Show();
        }

        private void ten_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
