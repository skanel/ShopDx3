using Autofac;
using ShopDx3.Interfaces;

namespace ShopDx3.Infrastructure.MongoDb.Factories
{

    public class RepositoryFactory : IRepositoryFactory
    {

        public IComponentContext Container;

        public RepositoryFactory(IComponentContext container)
        {
            Container = container;
        }

        public T GetRepository<T>() where T : IInventoryRepository
        {
            return Container.Resolve<T>();
        }


    }
}
