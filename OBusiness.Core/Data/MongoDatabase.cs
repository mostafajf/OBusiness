using MongoDB.Driver;
using Pluralize.NET.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace OBusiness.Core.Data
{
    public class MongoDatabase
    {
        IMongoDatabase db;
        public MongoDatabase(MongoClientSettings config)
        {
            var client = new MongoClient("mongodb://localhost:27017/OBusiness");
            db = client.GetDatabase("OBusiness");
        }
        public IMongoCollection<T> GetCollection<T>()
        {

            Pluralizer pluralizer = new Pluralizer();
            return db.GetCollection<T>(pluralizer.Pluralize(typeof(T).Name));
        }
        public IMongoCollection<T> GetCollection<T>(string entity)
        {

            Pluralizer pluralizer = new Pluralizer();
            return db.GetCollection<T>(pluralizer.Pluralize(entity));
        }

    }
}
