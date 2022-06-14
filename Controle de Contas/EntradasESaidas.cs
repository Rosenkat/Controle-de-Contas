using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controle_de_Contas
{
    public partial class EntradasESaidas : Form
    {
        public EntradasESaidas()
        {
            InitializeComponent();
        }

        private void btnAdicionarGastos_Click(object sender, EventArgs e)
        {
            double valor;
            string cartao;
            string categoria;
            DateTime dataInclusao = DateTime.Now;

            valor = Convert.ToDouble(txtValorGasto.Text);
            cartao = cbbxCartao.Text;
            categoria = txtCategoria.Text;

            sqoClassDB.InsertValorGasto(categoria, cartao, valor, dataInclusao);
        }

        private void pnlIcon_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void btnAdicionarEntrada_Click(object sender, EventArgs e)
        {
            
            double valor;
            string conta;
            string origem;
            string data;

            valor = Convert.ToDouble(txtValorEntrada.Text);
            conta = cbbxContas.Text;
            origem = txtOrigem.Text;
            data = txtData.Text;
            DateTime datainclusao = Convert.ToDateTime(data);

            if (valor != null && conta != "" && origem != "" && data != "")
            {
                sqoClassDB.InsertEntradas(valor, conta, origem, datainclusao);
            }
            else
            {
                MessageBox.Show("Dados a serem preenchidos, verifique e tente novamente!","Alerta",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void lblTelaInicial_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
