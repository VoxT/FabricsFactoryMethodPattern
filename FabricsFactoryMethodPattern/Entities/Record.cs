using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace FabricsFactoryMethodPattern.Entities
{
    public class Record : Entity
    {
        public double Monney { get; set; }
        public DateTime Time { get; set; }
        public string Note { get; set; }
        public ObjectId PurchaseInvoiceId {get; set; }
        public ObjectId SalesInvoiceId { get; set; }
        public ObjectId PaymentId { get; set; }

        public Record()
        {
        }

    }
}
