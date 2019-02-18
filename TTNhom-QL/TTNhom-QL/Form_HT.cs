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
    public partial class Form_HT : Form
    {
        public Form_HT()
        {
            InitializeComponent();
        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nhậpHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void xuấtHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void chiTiếtToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cậpNhậtToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void thoátToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show(" Thoát về màn hình đăng nhập?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                //do no stuff

            }
            else
            {
                this.Close();
                //do yes stuff
                Form_Login b = new Form_Login();
                b.ShowDialog();
            }
        }

        private void cậpNhậtToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Phiên bản hiện tại: 1 \nKhông có cập nhật mới", "Cập nhật");

        }

        private void chiTiếtToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Quản lý bán Vali các kiểu các loại", "Chi tiết");

        }

        private void trangChủToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nhàCungCấpToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

            Form_NCC a = new Form_NCC();
            a.ShowDialog();
        }

        private void nhậpHàngToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form_NHang a = new Form_NHang();
            a.ShowDialog();
        }

        private void xuấtHàngToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

            Form_PXuat a = new Form_PXuat();
            a.ShowDialog();
        }
    }
}
