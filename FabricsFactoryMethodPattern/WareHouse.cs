using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;

namespace FabricsFactoryMethodPattern
{
    public class WareHouse
    {
        private StoreCollection storeCollection;

        public WareHouse()
        {
            storeCollection = new StoreCollection();
        }

        public void createStore(WareHouse document)
        {
            storeCollection.createDocument(document);
        }

        public List<WareHouse> getAllStore()
        {
            return storeCollection.selectAllDocument();
        }

        public WareHouse getAStore(ObjectId idStore)
        {
            return storeCollection.selectADocument(idStore);
        }

        public Boolean deleteAStore(ObjectId idStore)
        {
            return storeCollection.deleteADocument(idStore);
        }

        public void UpdateAStore(ObjectId idStore, WareHouse document)
        {
            storeCollection.UpdateADocument(idStore, document);
        }

    }
}
