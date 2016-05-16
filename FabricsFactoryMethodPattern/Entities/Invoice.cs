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

        public PurchaseInvoice(ObjectId employeeId, ObjectId supplierId, ObjectId purchaseOrderId, ObjectId wareHouse, string paymentMethod, short discountPercent)
        {
            this.EmployeeId = employeeId;
            this.SupplierId = supplierId;
            this.PurchaseOrderId = purchaseOrderId;
            this.WareHouseId = wareHouse;
            this.PaymentMethod = paymentMethod;
            this.DiscountPercent = discountPercent;
        }

        public PurchaseInvoice(ObjectId employeeId, ObjectId supplierId, ObjectId purchaseOrderId, ObjectId wareHouse, string paymentMethod, short discountPercent, DateTime time)
        {
            this.EmployeeId = employeeId;
            this.SupplierId = supplierId;
            this.PurchaseOrderId = purchaseOrderId;
            this.WareHouseId = wareHouse;
            this.PaymentMethod = paymentMethod;
            this.DiscountPercent = discountPercent;
            this.Time = time;
        }

    }

    public class SalesInvoice : Invoice
    {

        [BsonElement("customer_id")]
        public ObjectId CustomerId { get; set; }

        [BsonElement("sales_order_id")]
        public ObjectId SalesOrderId { get; set; }

        [BsonElement("delivery")]
        public List<Delivery> Delivery { get; set; }

        [BsonConstructor]
        public SalesInvoice()
        {
        }

        public SalesInvoice(ObjectId employeeId, ObjectId customerId, ObjectId salesOrderId, string paymentMethod, short discountPercent, Delivery delivery)
        {
            this.EmployeeId = employeeId;
            this.CustomerId = customerId;
            this.SalesOrderId = salesOrderId;
            this.Delivery = new List<Delivery>{ delivery };
            this.PaymentMethod = paymentMethod;
            this.DiscountPercent = discountPercent;
        }

        public SalesInvoice(ObjectId employeeId, ObjectId customerId, ObjectId salesOrderId, string paymentMethod, short discountPercent, Delivery delivery, DateTime time)
        {
            this.EmployeeId = employeeId;
            this.CustomerId = customerId;
            this.SalesOrderId = salesOrderId;
            this.Delivery = new List<Delivery>{ delivery };
            this.PaymentMethod = paymentMethod;
            this.DiscountPercent = discountPercent;
            this.Time = time;
        }

    }
}
