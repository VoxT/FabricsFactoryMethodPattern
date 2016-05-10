using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;

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
    }

}
