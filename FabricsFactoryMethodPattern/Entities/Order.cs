﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

public enum Status { canceled, delivering, done }

namespace FabricsFactoryMethodPattern.Entities
{
    public abstract class Order : Entity
    {
        [BsonElement("date")]
        public Status Status { get; set; }

        [BsonElement("date")]
        public DateTime Time { get; set; }

        public Order()
        {
            this.Time = DateTime.Now;
        }
    }

    public class PurchaseOrder : Order
    {

        [BsonElement("date")]
        public ObjectId EmployeeId { get; set; }

        [BsonElement("date")]
        public List<Goods> PurchaseGoods { get; set; }

        public PurchaseOrder()
        {
            PurchaseGoods = new List<Goods>();
        }

        [BsonConstructor]
        public PurchaseOrder(ObjectId employeeId, List<Goods> purchaseGoods, Status status)
        {
            this.EmployeeId = employeeId;
            this.PurchaseGoods = purchaseGoods;
            this.Status = status;
        }

        [BsonConstructor]
        public PurchaseOrder(ObjectId employeeId, List<Goods> purchaseGoods, Status status, DateTime time)
        {
            this.EmployeeId = employeeId;
            this.PurchaseGoods = purchaseGoods;
            this.Status = status;
            this.Time = time;
        }

    }

    public class SalesOrder : Order
    {

        [BsonElement("date")]
        public ObjectId CustomerId { get; set; }

        [BsonElement("date")]
        public List<Goods> GoodsSold { get; set; }

        public SalesOrder()
        {
            GoodsSold = new List<Goods>();
        }

        [BsonConstructor]
        public SalesOrder(ObjectId customerId, List<Goods> goodsSold, Status status)
        {
            this.CustomerId = customerId;
            this.GoodsSold = goodsSold;
            this.Status = status;
        }

        [BsonConstructor]
        public SalesOrder(ObjectId customerId, List<Goods> goodsSold, Status status, DateTime time)
        {
            this.CustomerId = customerId;
            this.GoodsSold = goodsSold;
            this.Status = status;
            this.Time = time;
        }

    }
}
