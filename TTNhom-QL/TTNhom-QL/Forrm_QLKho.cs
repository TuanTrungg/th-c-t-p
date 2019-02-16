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
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void LogoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(" Đăng xuất?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                //do no stuff

            }
            else
            {
                this.Hide();
                //do yes stuff
                Form_Login b = new Form_Login();
                b.ShowDialog();
            }
        }

        private void hàngTồnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_HT a = new Form_HT();
            a.ShowDialog();
        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_NCC a = new Form_NCC();
            a.ShowDialog();
        }

        private void hàngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_NHang a = new Form_NHang();
            a.ShowDialog();
        }

        private void hàngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_PXuat a = new Form_PXuat();
            a.ShowDialog();
        }
    }
}
