using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Controle_de_Contas
{
    public partial class TelaLogin : Form
    {
        public TelaLogin()
        {
            InitializeComponent();
            txtLogin.Select();
        }

        private void btnAcessar_Click(object sender, EventArgs e)
        {
            sqoClassDB.VerificaLogin(txtLogin.Text, txtSenha.Text);

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ExibeSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (ExibeSenha.Checked)
            {
                txtSenha.UseSystemPasswordChar = false;
            }
            else
            {
                txtSenha.UseSystemPasswordChar = true;
            }
        }
    }
}
