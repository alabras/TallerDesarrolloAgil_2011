using System;
using NUnit.Framework;


namespace Calculadora.Negocio.Test
{
    [TestFixture]
    public class CalculadoraTest
    {
        private Calculadora _calculadora;

        [SetUp]
        public void Inicializar()
        {
            _calculadora = new Calculadora();
        }

        [Test]
        public void TestSumarDosNumerosPositivos()
        {
            _calculadora = new Calculadora();

            var resultado = _calculadora.Sumar(2, 3);

            Assert.AreEqual(5, resultado);
        }

        [Test]
        public void TestSumarDosNumerosNegativos()
        {
            _calculadora = new Calculadora();

            var resultado = _calculadora.Sumar(-2, -3);

            Assert.AreEqual(-5, resultado);
        }

        [Test]
        public void ProbarDividirDosNumerosPositivos()
        {
            _calculadora = new Calculadora();
            
            var resultado = _calculadora.Dividir(6, 3);

            Assert.AreEqual(2, resultado);
        }

        [Test][ExpectedException(typeof(DivideByZeroException))]
        public void ProbarDividirPorZero()
        {
            _calculadora = new Calculadora();
            
            var resultado = _calculadora.Dividir(6, 0);

            Assert.AreEqual(0, resultado);
        }
    }
}