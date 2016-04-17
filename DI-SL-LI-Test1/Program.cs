using LightInject;
using DI_SL_LI_Test1.Containers.DL;
using DI_SL_LI_Test1.DL;

namespace DI_SL_LI_Test1
{
    //Light Inject && Service Locator
    class Program
    {
        static void Main(string[] args)
        {
            var container = new ServiceContainer();
            ServiceLocator.SetCurrentInjector(container);

            container.Register<IContainer, Container1>();
            
            var process = container.GetInstance<IContainer>();
            process.Write("Yeah!");


        }
    }
}
