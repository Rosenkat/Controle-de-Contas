using sqoClassLibraryAI0502Biblio;
using System;
using System.Collections.Generic;
using System.Data;

namespace Controle_de_Contas
{
    internal static class sqoClassDBHelpers
    {

        public static List<RelatorioPersistencia> GetGastos()
        {

            DataTable dt = new DataTable();
            List<RelatorioPersistencia> result = new List<RelatorioPersistencia>();

            try
            {
                string sQuery = "";

                sQuery += System.Environment.NewLine + "Select [Categoria] as Categoria";
                sQuery += System.Environment.NewLine + ",[Cartao] as Cartao";
                sQuery += System.Environment.NewLine + ",[Gastos_Transacao] as Valor";
                sQuery += System.Environment.NewLine + ",DATEPART(MONTH,Data_Inclusao) as Mes";
                sQuery += System.Environment.NewLine + "From dbo.GastosMensais";
                result = sqoClassPersistencia.GetListaResultado<RelatorioPersistencia>(sqoClassDB.oDBconnection, sQuery);

            }
            catch (Exception ex)
            {
                throw (new Exception("Erro ao buscar os dados. " + ex + ""));
            }

            return result;
        }

        public static List<GanhosPersistencia> GetGanhos()
        {

            DataTable dt = new DataTable();
            List<GanhosPersistencia> result = new List<GanhosPersistencia>();

            try
            {
                string sQuery = "";

                sQuery += System.Environment.NewLine + "SELECT Valor as Valor";
                sQuery += System.Environment.NewLine + ",Conta as Conta";
                sQuery += System.Environment.NewLine + ",DATEPART(MONTH, Data) AS Mes";
                sQuery += System.Environment.NewLine + "From dbo.EntradasMensais";
                result = sqoClassPersistencia.GetListaResultado<GanhosPersistencia>(sqoClassDB.oDBconnection, sQuery);

            }
            catch (Exception ex)
            {
                throw (new Exception("Erro ao buscar os dados. " + ex + ""));
            }

            return result;
        }
    }
}