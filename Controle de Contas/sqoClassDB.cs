using sqoClassLibraryAI0502Biblio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controle_de_Contas
{
    public static class sqoClassDB
    {

        private static string ConnectionString = @"Provider=SQLOLEDB.1;Password=1234567890;Persist Security Info=True;User ID=sa;Initial Catalog=BancoDeGastos;Data Source=DESKTOP-LCF0GL4";
        public static OleDbConnection oDBconnection = new OleDbConnection(ConnectionString);

        public static void InsertValorGasto(string categoria, string cartao, double valortran, DateTime data)
        {
            OleDbCommand oCommand = null;
            String sQuery = "";

            try
            {
                oDBconnection.Open();
                sQuery = "INSERT into GastosMensais" +
                         "(Categoria,Cartao,Gastos_Transacao,Data_Inclusao)" +
                         "Values('" + categoria + "', '" + cartao + "','" + valortran + "'," + data.ToString("dd-MM-yyyy") + ")";


                oCommand = new OleDbCommand(sQuery, oDBconnection);
                oCommand.ExecuteNonQuery();

            }
            catch (OleDbException ex)
            {
                throw new Exception("Erro ao inserir os dados. " + ex + "");
            }
            finally
            {
                oCommand.Dispose();
                oDBconnection.Close();
            }
        }

        public static void InsertEntradas(double valor, string conta, string origem, DateTime data)
        {
            OleDbCommand oCommand = null;
            String sQuery = "";

            try
            {
                oDBconnection.Open();
                sQuery = "INSERT into EntradasMensais" +
                         "(Valor,Conta,Data,Origem)" +
                         "Values('" + valor + "', '" + conta + "','" + data.ToString("dd-MM-yyyy") + "','" + origem + "')";


                oCommand = new OleDbCommand(sQuery, oDBconnection);
                oCommand.ExecuteNonQuery();

            }
            catch (OleDbException ex)
            {
                throw new Exception("Erro ao inserir os dados. " + ex + "");
            }
            finally
            {
                oCommand.Dispose();
                oDBconnection.Close();
            }
        }


        public static void VerificaLogin(string usuario, string senha)
        {
            String sQuery = "";
            try
            {
                oDBconnection.Open();
                sQuery = "SELECT * FROM Usuarios WHERE Usuario = '" + usuario +"' AND Senha = '" +senha+"'";
                OleDbDataAdapter dp = new OleDbDataAdapter(sQuery, oDBconnection);
                DataTable dt = new DataTable();
                dp.Fill(dt);

                if(dt.Rows.Count == 1)
                {
                    TelaInicial navegar = new TelaInicial();
                    navegar.Show();
                }
                else
                {
                    MessageBox.Show("Erro! usuário ou senha incorretos","Erro!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                
            }
            catch (OleDbException ex)
            {

                throw new Exception("Erro ao buscar os dados. " + ex + "");
            }
            finally
            {
                oDBconnection.Close();
            }
        }

        public static OleDbDataReader GeraResultado;
    }
}
