﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Driver.Core;

namespace FabricsFactoryMethodPattern
{
    public abstract class Database
    {
        protected MongoClient connect;
        protected IMongoDatabase database;

        public Database()
        {
            connect = new MongoClient("mongodb://localhost:27017");
            database = connect.GetDatabase("fabrics");
        }

    }

    public class CustomerCollection : Database
    {
        private IMongoCollection<BsonDocument> collection;

        public CustomerCollection()
        {
            collection = database.GetCollection<BsonDocument>("customer");
        }

        public void createCustomer(BsonDocument document)
        {
            collection.InsertOne(document);
        }

        public List<BsonDocument> selectAllCustomer()
        {
            var filter = new BsonDocument();
            var document = collection.Find(filter).ToList();

            return document;
        }

        public BsonDocument selectACustomer(ObjectId idCustomer)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("_id", idCustomer);
            var document = collection.Find(filter).FirstOrDefault();

            return document;
        }


        public Boolean deleteACustomer(ObjectId idCustomer)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("_id", idCustomer);
            var document = collection.DeleteOne(filter);

            return true;
        }
        public void UpdateACustomer(ObjectId idCustomer, BsonDocument document)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("_id", idCustomer);
            foreach (var result in document)
            {
                var update = Builders<BsonDocument>.Update.Set(result.Name, result.Value);
                collection.UpdateOne(filter, update);
            }
        }
    }

}
