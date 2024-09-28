using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XUnit;
using TDDTestesUnitarios.Calculadora;

namespace TDDtestesunitarios.TesteCalculadora
{
	public class UnitTest1
	{
		[Fact]
		public void Test1()
		{
			Calculadora calc = new Calculadora();
			int resultado = calc.somar(1, 2);

			Assert.Equal(3, resultado);
		}
	}
}