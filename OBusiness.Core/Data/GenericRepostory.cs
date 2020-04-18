using MongoDB.Driver;
using OBusiness.Core.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OBusiness.Core.Data
{
    public class GenericRepostory<T> : IGenericRepostory<T> where T : BaseEntity
    {

        MongoDatabase db;
        public IMongoCollection<T> Collection { get; set; }
        public GenericRepostory(MongoDatabase db)
        {
            this.db = db;
            this.Collection = db.GetCollection<T>();
        }
        public Task Add(T entity)
        {
            return Collection.InsertOneAsync(entity);
        }

        public Task AddMany(List<T> entities)
        {
            return Collection.InsertManyAsync(entities);
        }

        public Task<IAsyncCursor<T>> GetAll()
        {
            return Collection.FindAsync(c => true);
        }

        public Task<IAsyncCursor<T>> GetByID(string id)
        {
            return Collection.FindAsync(c => c.Id == id);
        }

        public Task Remove(T entity)
        {
            return Collection.DeleteOneAsync(c => c.Id == entity.Id);
        }

        public Task Remove(string id)
        {
            return Collection.DeleteOneAsync(c => c.Id == id);
        }

        public Task Update(T entity)
        {
            return Collection.ReplaceOneAsync(c => c.Id == entity.Id, entity);
        }

    }
}
