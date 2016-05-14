using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;

namespace FabricsFactoryMethodPattern.Entities
{
    public abstract class Invoice : Entity
    {
        public DateTime Time { get; set; }
        public string PaymentMethod { get; set; }
        public short DiscountPercent { get; set; }
        public ObjectId EmployeeId { get; set; }
    }

    public class PurchaseInvoice : Invoice
    {
        public ObjectId WareHouseId { get; set; }
        public ObjectId SupplierId { get; set; }
        public ObjectId PurchaseOrderId { get; set; }

        public PurchaseInvoice()
        {
        }

    }

    public class SalesInvoice : Invoice
    {
        public ObjectId CustomerId { get; set; }
        public ObjectId SalesOrderId { get; set; }
        public List<Delivery> Delivery { get; set; }

        public SalesInvoice()
        {
        }

    }
}
