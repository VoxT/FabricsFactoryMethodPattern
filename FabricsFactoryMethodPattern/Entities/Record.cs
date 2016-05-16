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

        [BsonElement("money")]
        public double Monney { get; set; }

        [BsonElement("time")]
        public DateTime Time { get; set; }

        [BsonElement("note")]
        public string Note { get; set; }

        [BsonElement("purchase_invoice_id")]
        public ObjectId PurchaseInvoiceId { get; set; }

        [BsonElement("sales_invoice_id")]
        public ObjectId SalesInvoiceId { get; set; }

        [BsonElement("payment_id")]
        public ObjectId PaymentId { get; set; }

        public Record()
        {
            Time = DateTime.Now;
        }

        [BsonConstructor]
        public Record(double money, string note)
        {
            this.Monney = money;
            this.Note = note;
        }

        [BsonConstructor]
        public Record(double money, string note, DateTime time)
        {
            this.Monney = money;
            this.Note = note;
            this.Time = time;
        }

    }
}
