namespace Dinero
{
    public class Dinero
    {
        private readonly ICurrencyService _convertCurrencyService;

        public decimal Monto { get; set; }
        public Divisa Moneda { get; set; }

        public Dinero(Divisa moneda, decimal monto)
        {
            Monto = monto;
            Moneda = moneda;
        }

        public Dinero(ICurrencyService convertCurrencyService)
        {
            _convertCurrencyService = convertCurrencyService;
        }
        public Dinero Sumar(Dinero aSumar)
        {
            var monedaLocal = !Moneda.Equals(aSumar.Moneda) ? _convertCurrencyService.Convert(aSumar, Moneda) : aSumar;

            return new Dinero(Moneda, Monto + monedaLocal.Monto);
        }

        public override string ToString()
        {
            return "Dinero [monto=" + Monto + ", moneda=" + Moneda + "]";
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == typeof (Dinero) && Equals((Dinero) obj);
        }

        public bool Equals(Dinero other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return Equals(other._convertCurrencyService, _convertCurrencyService) && other.Monto == Monto && Equals(other.Moneda, Moneda);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var result = (_convertCurrencyService != null ? _convertCurrencyService.GetHashCode() : 0);
                result = (result*397) ^ Monto.GetHashCode();
                result = (result*397) ^ Moneda.GetHashCode();
                return result;
            }
        }
    }
}