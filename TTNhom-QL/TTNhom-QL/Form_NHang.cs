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
    public partial class Form_NHang : Form
    {
        public Form_NHang()
        {
            InitializeComponent();
        }

        private void xuấtHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_PXuat a = new Form_PXuat();
            a.ShowDialog();
        }
    }
}
