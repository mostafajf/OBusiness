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
        IMongoCollection<T> collection;
        public IMongoCollection<T> Collection => this.collection;
        public GenericRepostory(MongoDatabase db)
        {
            this.db = db;
            this.collection = db.GetCollection<T>();
        }
        public Task Add(T entity)
        {
            return collection.InsertOneAsync(entity);
        }

        public Task AddMany(List<T> entities)
        {
            return collection.InsertManyAsync(entities);
        }

        public Task<IAsyncCursor<T>> GetAll()
        {
            return collection.FindAsync(c => true);
        }

        public Task<IAsyncCursor<T>> GetByID(string id)
        {
            return collection.FindAsync(c => c.Id == id);
        }

        public Task Remove(T entity)
        {
            return collection.DeleteOneAsync(c => c.Id == entity.Id);
        }

        public Task Remove(string id)
        {
            return collection.DeleteOneAsync(c => c.Id == id);
        }

        public Task Update(T entity)
        {
            return collection.ReplaceOneAsync(c => c.Id == entity.Id, entity);
        }

    }
}
