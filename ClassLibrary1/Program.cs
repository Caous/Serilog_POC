using SerilogBase.Infraestructure.Interface;
using SerilogBase.Infraestructure.Service;
using SimpleInjector;

namespace Schedule_Poc
{
    public class Program
    {
        private static readonly Container container;
        static Program()
        {
            container = new Container();

            container.Register<ILogBase, LogBaseService>();

            // Reverting to the pre-v5 behavior
            container.Options.ResolveUnregisteredConcreteTypes = true;

            container.Verify();
        }

        static void Main(string[] args)
        {
            try
            {
                var service = container.GetInstance<TestedLog>();
                service.InicializeLog();
            }
            catch (System.Exception)
            {

                throw;
            }
           
        }
    }
}
