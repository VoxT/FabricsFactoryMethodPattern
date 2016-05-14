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
    public abstract class Prices
    {
        public ObjectId FabricsColorId { get; set; }
        public DateTime Time { get; set; }
        public int Price { get; set; }
    }

    public class CustomerPrice : Prices
    {
        public CustomerPrice()
        {
        }

    }

    public class SupplierPrice : Prices
    {
        public SupplierPrice()
        {
        }

    }
}
