using System.Collections.Generic;
using LightInject;

namespace DI_SL_LI_Test1
{
    public class ServiceLocator
    {
        public static ServiceLocator Instance { get; private set; }
        readonly IServiceContainer _container;

        public static void SetCurrentInjector(IServiceContainer container)
        {
            Instance = new ServiceLocator(container);
        }

        private ServiceLocator(IServiceContainer container)
        {
            _container = container;
        }

        public T GetService<T>()
        {
            return _container.GetInstance<T>();
        }

        public T GetService<T>(string serviceName)
        {
            return _container.GetInstance<T>(serviceName);
        }

        public IEnumerable<T> GetServices<T>()
        {
            return _container.GetAllInstances<T>();
        }
    }
}
