namespace di
{
    public class ServidorA : IServidor
    {
        public string Hola()
        {
            return "Servidor A:" + ToString();
        }
    }
}