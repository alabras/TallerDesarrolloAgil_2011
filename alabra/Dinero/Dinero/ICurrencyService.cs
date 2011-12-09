namespace Dinero
{
    public interface ICurrencyService
    {
        Dinero Convert(Dinero divisa, Divisa moneda);
    }
}