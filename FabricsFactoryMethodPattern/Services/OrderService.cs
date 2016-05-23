using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;
using FabricsFactoryMethodPattern.Entities;

namespace FabricsFactoryMethodPattern.Services
{
    using Entities;

    public abstract class OrderService<T> : EntityService<T> where T : Order, IEntity
    {
        public void AddGoods(string id, Goods goods)
        {
            var filter = Builders<T>.Filter.Eq(p => p.Id, ObjectId.Parse(id));
            var update = Builders<T>.Update.Push<Goods>(p => p.Goods, goods);
            var updateResult = this.Collection.UpdateOne(filter, update);
        }


        public void AddGoods(string id, List<Goods> phones)
        {
            var filter = Builders<T>.Filter.Eq(p => p.Id, ObjectId.Parse(id));
            foreach (var value in phones)
            {
                var update = Builders<T>.Update.Push<Goods>(p => p.Goods, value);
                this.Collection.UpdateOne(filter, update);
            }

        }

        public List<T> GetOrderByDate(DateTime fromDate, DateTime toDate)
        {
            var filterBuilder = Builders<T>.Filter;
            var filter = filterBuilder.Gt(p => p.Time, fromDate) & filterBuilder.Lt(p => p.Time, toDate);
            return this.Collection.Find(filter).ToList();
        }

    }

    public class SalesOrderService : OrderService<SalesOrder>
    {
        public SalesOrderService()
        {
        }

        public override void Create(SalesOrder entity)
        {
            entity.Status = SalesOrderStatus.Waiting;
            base.Create(entity);
        }

        public void UpdateStatus(string id, SalesOrderStatus status)
        {
            var filter = Builders<SalesOrder>.Filter.Eq(p => p.Id, ObjectId.Parse(id));
            var update = Builders<SalesOrder>.Update.Set(p => p.Status, status);
            this.Collection.UpdateOne(filter, update);
        }

    }

    public class PurchaseOrderService : OrderService<PurchaseOrder>
    {
        public PurchaseOrderService()
        {
        }

        public override void Create(PurchaseOrder entity)
        {
            entity.Status = PurchaseOrderStatus.Unconfimred;
            base.Create(entity);
        }

        public void UpdateStatus(string id, PurchaseOrderStatus status)
        {
            var filter = Builders<PurchaseOrder>.Filter.Eq(p => p.Id, ObjectId.Parse(id));
            var update = Builders<PurchaseOrder>.Update.Set(p => p.Status, status);
            this.Collection.UpdateOne(filter, update);
        }

    }

}
