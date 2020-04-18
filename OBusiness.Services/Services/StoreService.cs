using MongoDB.Driver;
using OBusiness.Core.Data;
using OBusiness.Core.Domain.Models;
using OBusiness.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OBusiness.Services.Services
{

    public class StoreService : IStoreService
    {
        IGenericRepostory<Store> StoreRepository;
        public StoreService(IGenericRepostory<Store> storeRepository)
        {
            this.StoreRepository = storeRepository;
        }
        public async Task Add(Store entity)
        {
            await StoreRepository.Add(entity);
        }

        public async Task AddMany(List<Store> entities)
        {
            await StoreRepository.AddMany(entities);
        }

        public async Task<List<Store>> GetAll()
        {
            var stores = await StoreRepository.GetAll();
            return stores.ToList();
        }

        public async Task<Store> GetByID(string id)
        {
            var store = await StoreRepository.GetByID(id);
            return store.FirstOrDefault();
        }

        public async Task<Store> GetByStoreID(int id)
        {
            var store = await StoreRepository.Collection.FindAsync(c => c.StoreID == id);
            return store.FirstOrDefault();
        }

        public async Task Remove(Store entity)
        {
            await StoreRepository.Remove(entity);
        }

        public async Task Remove(string id)
        {
            await StoreRepository.Remove(id);
        }

        public async Task Update(Store entity)
        {
            await StoreRepository.Update(entity);
        }
    }
}
