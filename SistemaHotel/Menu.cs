using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaHotel
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void FrmMenu_Resize(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            pnlTopo.BackColor = Color.FromArgb(230, 230, 230);
            pnlRight.BackColor = Color.FromArgb(140, 140, 140);
        }

        private void funcionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastros.FrmFuncionarios form = new Cadastros.FrmFuncionarios();
            form.Show();
        }

        private void cargoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastros.frmCargo form = new Cadastros.frmCargo();
            form.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Produtos.frmProdutos form = new Produtos.frmProdutos();
            form.Show();
        }

        private void novoProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Produtos.frmProdutos form = new Produtos.frmProdutos();
            form.Show();
        }
    }
}