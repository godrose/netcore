using Solid.Practices.IoC;
using Solid.Practices.Modularity;
using netcore.Domain;
using netcore.Infra;

namespace netcore
{
    public class Module : ICompositionModule<IIocContainerRegistrator>
    {
        public void RegisterModule(IIocContainerRegistrator iocContainer)
        {
            iocContainer.RegisterSingleton<ITodoRepository, TodoRepository>();
        }
    }
}
