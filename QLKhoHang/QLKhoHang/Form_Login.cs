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
    public partial class Form_Login : Form
    {
        public string tendangnhap ;
        public Form_Login()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dangnhap_Click(object sender, EventArgs e)
        {
            if (ten.Text == "")
            {
                errorProvider1.SetError(ten, "Nhập tên đăng nhập!");
            }
            else
            {
                errorProvider1.Clear();
            }

            if (pass.Text == "")
            {
                errorProvider1.SetError(pass, "Nhập mật khẩu!");
            }
            else
            {
                errorProvider1.Clear();
            };
            if (this.ten.Text == "admin" & this.pass.Text == "admin")
            {
                tendangnhap = this.ten.Text;
                MessageBox.Show("Đăng nhập thành công.\nChúc bạn một ngày làm việc vui vẻ .", "Thông báo");
                Hide();
                Form_Main QLKHO = new Form_Main();
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

                lbThongBao.Visible = true;
                lbThongBao.Text = "Tên hoặc mật khẩu sai. Vui lòng nhập lại.";

                //MessageBox.Show("Tên hoặc mật khẩu sai. Vui lòng nhập lại.", "Thông báo");
            }

        }

        private void thoat_Click(object sender, EventArgs e)
        {
            DialogResult thongbao ;
                thongbao =(MessageBox.Show("Bạn có chắc chắn muốn thoát ?", "Xác nhận",MessageBoxButtons.YesNo,MessageBoxIcon.Warning));
                if (thongbao == DialogResult.Yes)
                    Application.Exit();
                else
                {
                    Hide();
                    Form_Main QLKHO = new Form_Main();
                    QLKHO.Show();
                }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Hide();
            Form_Main QLKHO = new Form_Main();
            QLKHO.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbThongBao.Text = "";
        }

     
    }
}
