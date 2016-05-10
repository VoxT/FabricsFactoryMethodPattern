using System;
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

        public List<BsonDocument> selectAllDocument()
        {
            var filter = new BsonDocument();
            var document = collection.Find(filter).ToList();

            return document;
        }

        public BsonDocument selectADocument(ObjectId idCustomer)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("_id", idCustomer);
            var document = collection.Find(filter).FirstOrDefault();

            return document;
        }


        public Boolean deleteADocument(ObjectId idCustomer)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("_id", idCustomer);
            var document = collection.DeleteOne(filter);

            return true;
        }
    }

}
