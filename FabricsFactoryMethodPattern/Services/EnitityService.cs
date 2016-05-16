using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;

namespace FabricsFactoryMethodPattern.Services
{
    using Entities;
 
    public abstract class EntityService<T> : Database, IEntityService<T> where T : IEntity
    {
        protected static IMongoCollection<T> Collection { get; private set; }


        protected EntityService()
        {
            Collection = this.DatabaseHandler.GetCollection<T>(typeof(T).Name.ToLower() + "s"); ;
        }

        public virtual void CreateIndex(string[] fields)
        {
            var options = new CreateIndexOptions { Unique = true };
            foreach (string field in fields)
            {
                Collection.Indexes.CreateOne(field, options);
            }
        }
 
        public virtual void Create(T entity)
        {
            Collection.InsertOne(entity);
            
        }
 
        public virtual bool Delete(string id)
        {
            var filter = Builders<T>.Filter.Eq("_id", ObjectId.Parse(id));
            var result = Collection.DeleteOne(filter);

            return ( result.DeletedCount >= 1);
        }
 
        public virtual T GetById(string id)
        {
            var filter = Builders<T>.Filter.Eq("_id", ObjectId.Parse(id));
            var document = Collection.Find(filter).FirstOrDefault();

            return document;
        }

        public virtual List<T> GetAll()
        {
            var filter = new BsonDocument();
            var document = Collection.Find(filter).ToList();

            return document;
        }

        public virtual void Update(T entity)
        {
             var filter = Builders<T>.Filter.Eq("_id", entity.Id);
            foreach (var result in entity.ToBsonDocument<T>())
            {
                var update = Builders<T>.Update.Set(result.Name, result.Value);
                Collection.UpdateOne(filter, update);
            }
        }
    }
}
