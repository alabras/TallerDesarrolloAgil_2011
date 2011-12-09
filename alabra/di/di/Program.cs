using System;
using Castle.MicroKernel.Registration;
using Castle.Windsor;

namespace di
{
    class Program
    {
        static void Main()
        {
            var container = new WindsorContainer();
            container.Register(Component.For<IServidor>().ImplementedBy<ServidorA>());
            container.Register(Component.For<Cliente>());

            var cliente = container.Resolve<Cliente>();
            Console.Write(cliente.Mensaje());
        }
    }
}
