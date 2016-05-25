using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

/// <summary>
/// status for purchase order
/// </summary>
public enum PurchaseOrderStatus {Unconfimred, Delivering, Completed, Canceled }

/// <summary>
/// status for sales order
/// </summary>
public enum SalesOrderStatus { Waiting, InProcess, Completed, Canceled }


namespace FabricsFactoryMethodPattern.Entities
{
    public abstract class Order : Entity
    {

        [BsonElement("goods")]
        public List<Goods> Goods { get; set; }

        [BsonElement("time")]
        public DateTime Time { get; set; }

        public Order()
        {
            this.Time = DateTime.Now;
        }
    }

    public class PurchaseOrder : Order
    {

        [BsonElement("employee_id")]
        public ObjectId EmployeeId { get; set; }

        [BsonElement("status")]
        public PurchaseOrderStatus Status { get; set; }

        [BsonConstructor]
        public PurchaseOrder()
        {
            this.Goods = new List<Goods>();
        }

    }

    public class SalesOrder : Order
    {

        [BsonElement("customer_id")]
        public ObjectId CustomerId { get; set; }

        [BsonElement("status")]
        public SalesOrderStatus Status { get; set; }

        [BsonConstructor]
        public SalesOrder()
        {
            this.Goods = new List<Goods>();
        }

    }
}
