using System;
using sqoClassLibraryAI0502Biblio;

namespace Controle_de_Contas
{
	class GanhosPersistencia
	{

		private double nValor = 0.0;
		[ColunaAttribute("Valor", "Valor", TIPO_COLUNA.tcDouble, -1)]
		public double Valor
		{
			get { return nValor; }
			set { nValor = value; }
		}

		private String sConta = "";
		[ColunaAttribute("Conta", "Conta", TIPO_COLUNA.tcString, -1)]
		public String Conta
		{
			get { return sConta; }
			set { sConta = value; }
		}

		private int nMes = 0;
		[ColunaAttribute("Mes", "Mes", TIPO_COLUNA.tcInt, -1)]
		public int Mes
		{
			get { return nMes; }
			set { nMes = value; }
		}



	}
}
