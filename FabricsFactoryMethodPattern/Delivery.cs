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

        public ObjectId ShipperId { get; set; }
        public ObjectId SalesInvoiceId { get; set; }
        public string PackMethod { get; set; }
        public string Address { get; set; }
        public int Total { get; set; }
        public string time { get; set; }

        private DeliveryCollection deliveryCollection;

        public Delivery()
        {
            deliveryCollection = new DeliveryCollection();
        }

        public void CreateDelivery(Delivery document)
        {
            deliveryCollection.CreateDocument(document);
        }

        public List<Delivery> GetAllDelivery()
        {
            return deliveryCollection.SelectAllDocument();
        }

        public Delivery GetADelivery(ObjectId idDelivery)
        {
            return deliveryCollection.SelectADocument(idDelivery);
        }

        public Boolean DeleteADelivery(ObjectId idDelivery)
        {
            return deliveryCollection.DeleteADocument(idDelivery);
        }

        public void UpdateADelivery(ObjectId idDelivery, Delivery document)
        {
            deliveryCollection.UpdateADocument(idDelivery, document);
        }

    }
}
