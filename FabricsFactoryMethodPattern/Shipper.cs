using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;

namespace FabricsFactoryMethodPattern
{
    class Shipper
    {
        private ShipperCollection shipperCollection;

        public Shipper()
        {
            shipperCollection = new ShipperCollection();
        }

        public void createShipper(BsonDocument document)
        {
            shipperCollection.createDocument(document);
        }

        public List<BsonDocument> getAllShipper()
        {
            return shipperCollection.selectAllDocument();
        }

        public BsonDocument getAShipper(ObjectId idShipper)
        {
            return shipperCollection.selectADocument(idShipper);
        }

        public Boolean deleteAShipper(ObjectId idShipper)
        {
            return shipperCollection.deleteADocument(idShipper);
        }

        public void UpdateAShipper(ObjectId idShipper, BsonDocument document)
        {
            shipperCollection.UpdateADocument(idShipper, document);

        }

    }
}
