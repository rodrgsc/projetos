using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;


// O Maior diferencial do TDD é não codificar antes de ter codificado os testes primeiro

// TDD é aplicado o testes antes da criação do projeto completo



namespace Calculadora
{
	public class Calculadora
	{
		private List<string> listahistorico;
		private string data;
		public Calculadora(string data)
		{
			listahistorico = new List<string>();
			this.data = data;
		}
		public int somar(int valor1, int valor2)
		{
			int resultado = valor1 + valor2;
			listahistorico.Insert(0, "Res: " + resultado + "data: " + data);
			return resultado;
			// return 0;
		}

		public int subtrair(int valor1, int valor2)
		{
			int resultado = valor1 - valor2;
			listahistorico.Insert(0, "Res: " + resultado + "data: " + data);
			return resultado;
			// return 0;
		}

		public int multiplicar(int valor1, int valor2)
		{
			int resultado = valor1 * valor2;
			listahistorico.Insert(0, "Res: " + resultado + "data: " + data);
			return resultado;
			// return 0;
		}

		public int dividir(int valor1, int valor2)
		{
			int resultado = valor1 / valor2;
			listahistorico.Insert(0, "Res: " + resultado + "data: " + data);
			return resultado;
			// return 0;
		}

		public List<string> historico()
		{
			listahistorico.RemoveRange(3, listahistorico.Count - 3);
			return listahistorico;
			// return new List<string>();
		}
	}
}