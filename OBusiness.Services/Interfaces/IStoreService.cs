using OBusiness.Core.Domain.Models;
using OBusiness.Core.Dto.Input;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OBusiness.Services.Interfaces
{
    public interface IStoreService
    {
        Task<List<Store>> GetAll();
        Task<Store> GetByID(string id);
        Task<Store> GetByStoreID(string id);
        Task Add(Store entity);
        Task AddMany(List<Store> entities);
        Task Update(Store entity);
        Task Remove(Store entity);
        Task Remove(string id);
        Task<List<Store>> GetNearby(GeoPoint location);
    }
}
