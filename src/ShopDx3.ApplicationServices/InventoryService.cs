using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ShopDx3.DomainModels;
using ShopDx3.Interfaces;
using ShopDx3.ViewModels;

namespace ShopDx3.ApplicationServices
{
    public class InventoryService : IInventoryService
    {

        private readonly IRepositoryFactory _repositoryFactory;

        public InventoryService(IRepositoryFactory repositoryFactory)
        {
            _repositoryFactory = repositoryFactory;
        }

        public async Task<IEnumerable<InventoryVm>> GetBreads()
        {
            var result = await _repositoryFactory.GetRepository<IInventoryRepository<Bread>>().GetAll();
            return AutoMapper.Mapper.Map<List<InventoryVm>>(result);
        }

        public async Task<IEnumerable<InventoryVm>> GetCheeses()
        {
            var result = await _repositoryFactory.GetRepository<IInventoryRepository<Cheese>>().GetAll();
            return AutoMapper.Mapper.Map<List<InventoryVm>>(result);
        }

        public async Task<IEnumerable<InventoryVm>> GetSauces()
        {
            var result = await _repositoryFactory.GetRepository<IInventoryRepository<Sauce>>().GetAll();
            return AutoMapper.Mapper.Map<List<InventoryVm>>(result);
        }

        public async Task<IEnumerable<PriceInventoryVm>> GetSizes()
        {
            var result = await _repositoryFactory.GetRepository<IInventoryRepository<Size>>().GetAll();
            return AutoMapper.Mapper.Map<List<PriceInventoryVm>>(result);
        }

        public async Task<IEnumerable<PriceInventoryVm>> GetToppings()
        {
            var result = await _repositoryFactory.GetRepository<IInventoryRepository<Topping>>().GetAll();
            return AutoMapper.Mapper.Map<List<PriceInventoryVm>>(result);
        }

        public async Task<InventoryVm> GetBreadById(string id)
        {
            var result = await _repositoryFactory.GetRepository<IInventoryRepository<Bread>>().GetById(Guid.Parse(id));
            return AutoMapper.Mapper.Map<InventoryVm>(result);
        }

        public async Task<InventoryVm> GetCheeseById(string id)
        {
            var result = await _repositoryFactory.GetRepository<IInventoryRepository<Cheese>>().GetById(Guid.Parse(id));
            return AutoMapper.Mapper.Map<InventoryVm>(result);
        }

        public async Task<InventoryVm> GetSauceById(string id)
        {
            var result = await _repositoryFactory.GetRepository<IInventoryRepository<Sauce>>().GetById(Guid.Parse(id));
            return AutoMapper.Mapper.Map<InventoryVm>(result);
        }

        public async Task<InventoryVm> GetSizeById(string id)
        {
            var result = await _repositoryFactory.GetRepository<IInventoryRepository<Size>>().GetById(Guid.Parse(id));
            return AutoMapper.Mapper.Map<InventoryVm>(result);
        }

        public async Task<InventoryVm> GetToppingById(string id)
        {
            var result = await _repositoryFactory.GetRepository<IInventoryRepository<Topping>>().GetById(Guid.Parse(id));
            return AutoMapper.Mapper.Map<InventoryVm>(result);
        }
    }
}