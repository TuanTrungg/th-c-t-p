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
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }

        private void qLHANGToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ghvvToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Form3 HANGTON = new Form3();
            HANGTON.Show();
        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Form4 NHACUNGCAP = new Form4();
            NHACUNGCAP.Show();
        }

        private void nhậpHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Form5 NHAPHANG = new Form5();
            NHAPHANG.Show();
        }

        private void pHIEUNHAPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Nhóm Quản Lý Bán Hàng Vali. Lớp : CDTHK18", "Chi tiết");
        }

        private void nCCToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Form1 DANGNHAP = new Form1();
            DANGNHAP.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Form1 DANGNHAP = new Form1();
            DANGNHAP.Show();
            
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void thoátToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            label1.Text = "Bạn chưa đăng nhập";
            qLHANGToolStripMenuItem.Enabled = false;
            nCCToolStripMenuItem.Enabled = false;
            pHIEUNHAPToolStripMenuItem.Enabled = false;
            pHIEUXUATToolStripMenuItem.Enabled = false;
            đăngNhậpToolStripMenuItem.Enabled = true;
            thoátToolStripMenuItem.Enabled = false;
        }

        private void đăngNhậpToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Hide();
            Form1 DANGNHAP = new Form1();
            DANGNHAP.Show();
            

        }

        private void pHIEUXUATToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Phiên bản hiện tại là phiên bản 1.Hiện chưa có phiên bản mới", "Cập nhật");
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void xuấtHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
            Form6 XUATHANG = new Form6();
            XUATHANG.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
