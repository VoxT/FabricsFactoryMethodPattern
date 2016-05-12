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
        private WareHouseCollection wareHouseCollection;

        public WareHouse()
        {
            wareHouseCollection = new WareHouseCollection();
        }

        public void createStore(WareHouse document)
        {
            wareHouseCollection.createDocument(document);
        }

        public List<WareHouse> getAllStore()
        {
            return wareHouseCollection.selectAllDocument();
        }

        public WareHouse getAStore(ObjectId idWareHouse)
        {
            return wareHouseCollection.selectADocument(idWareHouse);
        }

        public Boolean deleteAStore(ObjectId idWareHouse)
        {
            return wareHouseCollection.deleteADocument(idWareHouse);
        }

        public void UpdateAStore(ObjectId idWareHouse, WareHouse document)
        {
            wareHouseCollection.UpdateADocument(idWareHouse, document);
        }

    }
}
