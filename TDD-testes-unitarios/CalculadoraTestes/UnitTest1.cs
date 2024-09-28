namespace CalculadoraTestes;
using Xunit;
using System;
using Calculadora;
using System.Runtime.InteropServices;

public class UnitTest1
{
	public Calculadora construirClasse()
	{
		string data = DateTime.Now.ToString("dd/MM/yyyy");
		Calculadora calc = new Calculadora(data);
		return calc;
	}
	[Fact]
	public void TestarSomaDe1Mais2()
	{
		Calculadora calc = construirClasse();

		int resultado = calc.somar(1, 2);

		Assert.Equal(3, resultado);
	}

	[Theory]
	[InlineData(2, 1, 1)]
	[InlineData(4, 2, 2)]

	public void TestarSubstracao(int valor1, int valor2, int resultado)
	{
		Calculadora calc = construirClasse();

		int resultadoCaluculadora = calc.subtrair(valor1, valor2);

		Assert.Equal(resultado, resultadoCaluculadora);
	}

	[Theory]
	[InlineData(6, 2, 3)]
	[InlineData(4, 4, 1)]

	public void TestarDivisaoEntreDoisNumerosInteiros(int valor1, int valor2, int resultado)
	{
		Calculadora calc = construirClasse();

		int resultadoCaluculadora = calc.dividir(valor1, valor2);

		Assert.Equal(resultado, resultadoCaluculadora);
	}

	[Theory]
	[InlineData(7, 2, 14)]
	[InlineData(4, 4, 16)]

	public void TestarMultiplicacao(int valor1, int valor2, int resultado)
	{
		Calculadora calc = construirClasse();

		int resultadoCaluculadora = calc.multiplicar(valor1, valor2);

		Assert.Equal(resultado, resultadoCaluculadora);
	}
	[Fact]
	public void TestarDivisaoPorZero()
	{
		Calculadora calc = construirClasse();

		Assert.Throws<DivideByZeroException>(() => calc.dividir(3, 0));
	}

	[Fact]
	public void TestarHistoricoCalculadora()
	{
		Calculadora calc = construirClasse();

		calc.somar(1, 2);
		calc.somar(2, 8);
		calc.somar(3, 7);
		calc.somar(4, 1);

		var lista = calc.historico();

		Assert.NotEmpty(lista);
		Assert.Equal(3, lista.Count);

	}


}