using System.Threading.Tasks;

namespace ShopDx3.Interfaces
{
    public interface ISeedRepository
    {
        Task SeedToppings();
        Task SeedSizes();
        Task SeedSauces();
        Task SeedCheeses();
        Task SeedBreads();
    }
}