using NewTalents;
using System;
using System.Collections.Generic;
using Xunit;

namespace TestNewTalents
{
    public class UnitTest1
    {
        public Calculadora InstanciaCalculadora()
        {
            string data = "02/02/2020";
            Calculadora calc = new Calculadora(data);

            return calc;
        }

        [Theory]
        [InlineData(6, 2, 8)]
        [InlineData(5, 5, 10)]
        public void TestSomar(int val1, int val2, int resultado)
        {
            Calculadora calc = InstanciaCalculadora();

            int resultadoCalculadora = calc.Somar(val1, val2);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(6, 2, 4)]
        [InlineData(5, 5, 0)]
        public void TestSubtrair(int val1, int val2, int resultado)
        {
            Calculadora calc = InstanciaCalculadora();

            int resultadoCalculadora = calc.Subtrair(val1, val2);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(4, 5, 20)]
        public void TestMultiplicar(int val1, int val2, int resultado)
        {
            Calculadora calc = InstanciaCalculadora();

            int resultadoCalculadora = calc.Multiplicar(val1, val2);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(6, 2, 3)]
        [InlineData(5, 5, 1)]
        public void TestDividir(int val1, int val2, int resultado)
        {
            Calculadora calc = InstanciaCalculadora();

            int resultadoCalculadora = calc.Dividir(val1, val2);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Fact]
        public void TestDividirPorZero()
        {
            Calculadora calc = InstanciaCalculadora();

            Assert.Throws<DivideByZeroException>(() => calc.Dividir(3, 0));
        }

        [Fact]
        public void TestHistorico()
        {
            Calculadora calc = InstanciaCalculadora();

            calc.Somar(1, 2);
            calc.Somar(2, 8);
            calc.Somar(3, 7);
            calc.Somar(4, 1);

            List<string> lista = calc.Historico();

            Assert.NotEmpty(lista);
            Assert.Equal(3, lista.Count);
        }
    }
}
