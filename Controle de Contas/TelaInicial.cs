using DevExpress.XtraCharts;
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
    public partial class TelaInicial : Form
    {
        public DateTime horaAtual = new DateTime();
        public TelaInicial()
        {
            InitializeComponent();
        }

        private void TelaInicial_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bancoDeGastosDataSet1.GastosMensais' table. You can move, or remove it, as needed.
            this.gastosMensaisTableAdapter2.Fill(this.bancoDeGastosDataSet1.GastosMensais);
            this.gastosMensaisTableAdapter1.Fill(this.gastosSet.GastosMensais);
            CarregaTransacoes();
        }

        private void TimerGeral_Tick(object sender, EventArgs e)
        {
            lblHoraAtual.Text = "Data: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }


        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            EntradasESaidas navegar = new EntradasESaidas();
            navegar.Show();
        }

        private void CarregaTransacoes()
        {
            dtgridEntradas.DataSource = sqoClassDBHelpers.GetGanhos();
            dtgridGastos.DataSource = sqoClassDBHelpers.GetGastos();
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            CarregaTransacoes();
        }
    }
}
