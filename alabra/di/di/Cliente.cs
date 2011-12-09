namespace di
{
    public class Cliente
    {
        private readonly IServidor _servidor;

        public Cliente(IServidor servidor)
        {
            _servidor = servidor;
        }

        public string Mensaje()
        {
            return _servidor.Hola();
        }
    }
}