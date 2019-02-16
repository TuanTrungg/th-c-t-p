using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTNhom_QL
{
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
        }

        private void Form_Login_Load(object sender, EventArgs e)
        {

        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                errorProvider1.SetError(txtID, "Nhập tên đăng nhập!");
            }
            else
            {
                errorProvider1.Clear();
            }

            if (txtPW.Text == "")
            {
                errorProvider1.SetError(txtPW, "Nhập mật khẩu!");
            }
            else
            {
                errorProvider1.Clear();
            };
            if (txtID.Text == "admin" && txtPW.Text == "admin")
            {
                lbThongBao.Visible = false;
                this.Hide();
                Form_Main a = new Form_Main();
                a.ShowDialog();
            }
            else
            {
                lbThongBao.Visible = true;
                lbThongBao.Text = "Bạn đã nhập sai tài khoản hoặc mật khẩu!";
               
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbThongBao.Text = "";
        }
    }
}
