using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;

namespace FabricsFactoryMethodPattern.Entities
{
    public abstract class Goods
    {
        public ObjectId FabricsColorId { get; set; }
        public int TotalMetter { get; set; }
        public int TotalRoll { get; set; }

    }

    public class GoodsSold : Goods
    {
        public ObjectId SalesOrderId { get; set; }


        public GoodsSold()
        {
        }

    }

    public class PurchaseGoods : Goods
    {
        public ObjectId PurchaseOrderId { get; set; }


        public PurchaseGoods()
        {
        }

    }
}
