using NUnit.Framework;

namespace Dinero.Test
{
    [TestFixture]
    public class DadoClp200
    {
        private Dinero _clp200;
        [SetUp]
        public void Inicializar()
        {
            _clp200 = new Dinero(new StubCurrencyService()) {Monto = 200, Moneda = Divisa.Clp};
        }

        
        public void DebeDevolverClp300AlSumarClp100()
        {

        }

        [Test]
        public void DebeDevolverClp1200AlSumarChf10()
        {
            var chf10 = new Dinero(Divisa.Chf, 10);
            var clp1200 = new Dinero(Divisa.Clp, 1200);




            Assert.AreEqual(clp1200, _clp200.Sumar(chf10));
        }
    }
}