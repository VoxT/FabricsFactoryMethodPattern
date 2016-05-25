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

        [BsonElement("length")]
        public int Length { get; set; }

        [BsonElement("fabrics_color_id")]
        public ObjectId FabricsColorId { get; set; }

        [BsonElement("plots_id")]
        public ObjectId PlotsId { get; set; }

        [BsonElement("purchase_invoice_id")]
        public ObjectId PurchaseInvoiceId { get; set; }

        [BsonElement("sales_invoice_id")]
        public ObjectId SalesInvoiceId { get; set; }

        [BsonConstructor]
        public FabricsRoll()
        {
        }

        public FabricsRoll(ObjectId fabricsColorId, ObjectId plotsId, int length, ObjectId purchaseInvoice)
        {
            this.FabricsColorId = fabricsColorId;
            this.PlotsId = plotsId;
            this.Length = length;
            this.PurchaseInvoiceId = purchaseInvoice;
        }

    }
}
