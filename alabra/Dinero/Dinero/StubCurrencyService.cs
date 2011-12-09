namespace Dinero
{
    public class StubCurrencyService : ICurrencyService
    {
        public Dinero Convert(Dinero divisa, Divisa moneda)
        {
            return new Dinero(moneda, divisa.Monto*100);
        }
    }
}