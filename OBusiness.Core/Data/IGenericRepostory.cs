using MongoDB.Driver;
using OBusiness.Core.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OBusiness.Core.Data
{
    public interface IGenericRepostory<T> where T : BaseEntity
    {
        IMongoCollection<T> Collection { get; set; }
        Task<IAsyncCursor<T>> GetAll();
        Task<IAsyncCursor<T>> GetByID(string id);
        Task Add(T entity);
        Task AddMany(List<T> entities);
        Task Update(T entity);
        Task Remove(T entity);
        Task Remove(string id);

    }
}
