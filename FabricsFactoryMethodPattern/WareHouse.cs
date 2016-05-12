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

        public void CreateStore(WareHouse document)
        {
            wareHouseCollection.CreateDocument(document);
        }

        public List<WareHouse> GetAllStore()
        {
            return wareHouseCollection.SelectAllDocument();
        }

        public WareHouse GetAStore(ObjectId idWareHouse)
        {
            return wareHouseCollection.SelectADocument(idWareHouse);
        }

        public Boolean DeleteAStore(ObjectId idWareHouse)
        {
            return wareHouseCollection.DeleteADocument(idWareHouse);
        }

        public void UpdateAStore(ObjectId idWareHouse, WareHouse document)
        {
            wareHouseCollection.UpdateADocument(idWareHouse, document);
        }

    }
}
