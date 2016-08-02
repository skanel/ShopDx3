namespace ShopDx3.Interfaces
{
    public interface IRepositoryFactory
    {
        T GetRepository<T>() where T : IInventoryRepository;
    }
}