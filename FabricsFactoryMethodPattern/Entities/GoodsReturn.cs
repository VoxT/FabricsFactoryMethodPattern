using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;

namespace FabricsFactoryMethodPattern.Entities
{
    public abstract class GoodsReturn
    {
        public ObjectId FabricsRollId { get; set; }
        public DateTime Date { get; set; }
    }

    public class CustomerGoodsReturn : GoodsReturn
    {
        public ObjectId CustomerId { get; set; }

        public CustomerGoodsReturn()
        {
        }

    }

    public class SupplierGoodsReturn : GoodsReturn
    {
        public ObjectId SupplierId { get; set; }

        public SupplierGoodsReturn()
        {
        }

    }
}
