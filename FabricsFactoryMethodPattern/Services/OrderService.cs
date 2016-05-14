using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricsFactoryMethodPattern.Services
{
    using Entities;

    public abstract class OrderService<T> : EntityService<T> where T : IEntity
    {
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
