using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CView
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm1Cli frm1Cli = new frm1Cli();
            frm1Cli.MdiParent = this;
            frm1Cli.Show();
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm2Cli frm2Cli = new frm2Cli();
            frm2Cli.MdiParent = this;
            frm2Cli.Show();
        }

        private void tecnicosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm2Tec frm2Tec = new frm2Tec();
            frm2Tec.MdiParent = this;
            frm2Tec.Show();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 frma = new AboutBox1();
            frma.MdiParent = this;
            frma.Show();
        }

        private void tecnicosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm1Tec frm1Tec = new frm1Tec();
            frm1Tec.MdiParent = this;
            frm1Tec.Show();
        }

        private void serviciosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm2Ser frm2Ser = new frm2Ser();
            frm2Ser.MdiParent = this;
            frm2Ser.Show();
        }

        private void serviciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm1Ser frm1Ser = new frm1Ser();
            frm1Ser.MdiParent = this;
            frm1Ser.Show();
        }

        private void productosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm2Pro frm2Pro = new frm2Pro();
            frm2Pro.MdiParent = this;
            frm2Pro.Show();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm1Pro frm1Pro = new frm1Pro();
            frm1Pro.MdiParent = this;
            frm1Pro.Show();

        }

        private void ordenesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm1Ord frm1Ord = new frm1Ord();
            frm1Ord.MdiParent = this;
            frm1Ord.Show();
        }

        private void facturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm1Fac frm1Fac = new frm1Fac();
            frm1Fac.MdiParent = this;
            frm1Fac.Show();
        }

        private void ordenesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm2Ord frm2Ord = new frm2Ord();
            frm2Ord.MdiParent = this;
            frm2Ord.Show();
        }

        private void ordlogToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm2OrdDet frm2OrdDet = new frm2OrdDet();
            frm2OrdDet.MdiParent = this;
            frm2OrdDet.Show();
        }

        private void generaFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm2Fac frm2Fac = new frm2Fac();
            frm2Fac.MdiParent = this;
            frm2Fac.Show();
        }
    }
}
