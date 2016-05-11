using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;

namespace FabricsFactoryMethodPattern
{
    public class Delivery
    {
        private DeliveryCollection deliveryCollection;

        public Delivery()
        {
            deliveryCollection = new DeliveryCollection();
        }

        public void createDelivery(BsonDocument document)
        {
            deliveryCollection.createDocument(document);
        }

        public List<BsonDocument> getAllDelivery()
        {
            return deliveryCollection.selectAllDocument();
        }

        public BsonDocument getADelivery(ObjectId idDelivery)
        {
            return deliveryCollection.selectADocument(idDelivery);
        }

        public Boolean deleteADelivery(ObjectId idDelivery)
        {
            return deliveryCollection.deleteADocument(idDelivery);
        }

        public void UpdateADelivery(ObjectId idDelivery, BsonDocument document)
        {
            deliveryCollection.UpdateADocument(idDelivery, document);
        }

    }
}
