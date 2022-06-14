using System;
using sqoClassLibraryAI0502Biblio;

namespace Controle_de_Contas
{
	class RelatorioPersistencia
	{

		private String sCategoria = ""; 
		[ColunaAttribute("Categoria", "Categoria", TIPO_COLUNA.tcString, -1)] 
		public String Categoria 
		{  
			get { return sCategoria; } 
			set { sCategoria = value; } 
		} 

		private String sCartao = ""; 
		[ColunaAttribute("Cartao", "Cartao", TIPO_COLUNA.tcString, -1)] 
		public String Cartao 
		{  
			get { return sCartao; } 
			set { sCartao = value; } 
		} 

		private double nValor = 0.0; 
		[ColunaAttribute("Valor", "Valor", TIPO_COLUNA.tcDouble, -1)] 
		public double Valor 
		{  
			get { return nValor; } 
			set { nValor = value; } 
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
