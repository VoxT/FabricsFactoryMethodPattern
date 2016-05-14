using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;

namespace FabricsFactoryMethodPattern.Entities
{
    public abstract class Order : Entity
    {
        public bool Status{ get; set; }
        public DateTime Time { get; set; }
    }

    public class PurchaseOrder : Order
    {
        public ObjectId EmployeeId { get; set; }
        public List<PurchaseGoods> PurchaseGoods { get; set; }

        public PurchaseOrder()
        {
        }

    }

    public class SalesOrder : Order
    {
        public ObjectId CustomerId { get; set; }
        public List<GoodsSold> GoodsSold { get; set; }
        public SalesOrder()
        {
        }

    }
}
