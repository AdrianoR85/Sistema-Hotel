﻿using System;
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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            pnlLogin.Visible = false;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            pnlLogin.Location = new Point((this.Width / 2) - 166, (this.Height / 2) - 170);
            pnlLogin.Visible = true;
            btnLogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(21, 114, 160);
            btnLogin.FlatAppearance.MouseDownBackColor = Color.FromArgb(8, 72, 103);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            ChamarLogin();
        }

        private void frmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ChamarLogin();
            }
        }

        private void ChamarLogin()
        {
            if (txtUsuario.Text == "")
            {
                MessageBox.Show("Preencha o Usuário");
                txtUsuario.Focus();
                return;
            }

            if (txtSenha.Text == "")
            {
                MessageBox.Show("Preencha a senha");
                txtSenha.Focus();
                return;
            }
            Limpar();
            // AQUI VAI O CÓDIGO DO LOGIN
            FrmMenu menu = new FrmMenu();
            //this.Hide();
            menu.Show();
        }

        private void Limpar()
        {
            txtUsuario.Text = "";
            txtSenha.Text = "";
            txtUsuario.Focus();
        }

        private void frmLogin_Resize(object sender, EventArgs e)
        {
            pnlLogin.Location = new Point((this.Width / 2) - 166, (this.Height / 2) - 170);
        }
    }
}
