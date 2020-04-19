using MongoDB.Driver;
using MongoDB.Driver.GeoJsonObjectModel;
using OBusiness.Core.Data;
using OBusiness.Core.Domain.Models;
using OBusiness.Core.Dto.Input;
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

        public async Task<Store> GetByStoreID(string id)
        {
            var store = await StoreRepository.Collection.FindAsync(c => c.Id == id);
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
        public async Task<List<Store>> GetNearby(GeoPoint location)
        {
            var point = GeoJson.Point(GeoJson.Geographic(location.Latitude, location.Longitude)); //long, lat
            var builder = Builders<Store>.Filter;
            var filter = builder.Near(bs => bs.Location, point, minDistance: 10000);
            return (await StoreRepository.Collection.FindAsync(filter)).ToList();

        }
    }
}
