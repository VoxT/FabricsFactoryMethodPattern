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

    }

    public class SalesOrderService : OrderService<SalesOrder>
    {
        public SalesOrderService()
        {
        }
    }

    public class PurchaseOrderService : OrderService<PurchaseOrder>
    {
        public PurchaseOrderService()
        {
        }
    }

}
