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
    public abstract class Invoice : Entity
    {
        /// <summary>
        /// time created invoice.
        /// </summary>
        [BsonElement("time")]
        public DateTime Time { get; set; }

        [BsonElement("payment_method")]
        public string PaymentMethod { get; set; }

        [BsonElement("discount_percent")]
        public short DiscountPercent { get; set; }

        [BsonElement("employee_id")]
        public ObjectId EmployeeId { get; set; }
        
        public Invoice()
        {
            this.Time = DateTime.Now;
        }
    }

    public class PurchaseInvoice : Invoice
    {

        [BsonElement("warehouse_id")]
        public ObjectId WareHouseId { get; set; }

        [BsonElement("supplier_id")]
        public ObjectId SupplierId { get; set; }

        [BsonElement("purchase_order_id")]
        public ObjectId PurchaseOrderId { get; set; }

        [BsonConstructor]
        public PurchaseInvoice()
        {
        }

    }

    public class SalesInvoice : Invoice
    {

        [BsonElement("customer_id")]
        public ObjectId CustomerId { get; set; }

        /// <summary>
        /// order reference id for the invoice
        /// </summary>
        [BsonElement("sales_order_id")]
        public ObjectId SalesOrderId { get; set; }

        /// <summary>
        /// list delivery for this invoice
        /// </summary>
        [BsonElement("delivery")]
        public List<Delivery> Delivery { get; set; }

        [BsonConstructor]
        public SalesInvoice()
        {
        }

    }
}
