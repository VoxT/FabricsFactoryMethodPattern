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
    public class FabricsRoll : Entity
    {

        [BsonElement("lenght")]
        public int Length { get; set; }

        [BsonElement("fabrics_id")]
        public ObjectId FabricsId { get; set; }

        [BsonElement("plots_id")]
        public ObjectId PlotsId { get; set; }

        [BsonElement("purchase_invoice_id")]
        public ObjectId PurchaseInvoiceId { get; set; }

        [BsonElement("sales_invoice_id")]
        public ObjectId SalesInvoiceId { get; set; }

        public FabricsRoll()
        {
        }

        [BsonConstructor]
        public FabricsRoll(ObjectId fabricsId, ObjectId plotsId, int lenght, ObjectId purchaseInvoice)
        {
            this.FabricsId = fabricsId;
            this.PlotsId = plotsId;
            this.Length = lenght;
            this.PurchaseInvoiceId = purchaseInvoice;
        }

    }
}
