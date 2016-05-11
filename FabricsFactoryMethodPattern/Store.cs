using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;

namespace FabricsFactoryMethodPattern
{
    class Store
    {
        private StoreCollection storeCollection;

        public Store()
        {
            storeCollection = new StoreCollection();
        }

        public void createStore(BsonDocument document)
        {
            storeCollection.createDocument(document);
        }

        public List<BsonDocument> getAllStore()
        {
            return storeCollection.selectAllDocument();
        }

        public BsonDocument getAStore(ObjectId idStore)
        {
            return storeCollection.selectADocument(idStore);
        }

        public Boolean deleteAStore(ObjectId idStore)
        {
            return storeCollection.deleteADocument(idStore);
        }

        public void UpdateAStore(ObjectId idStore, BsonDocument document)
        {
            storeCollection.UpdateADocument(idStore, document);
        }

    }
}
