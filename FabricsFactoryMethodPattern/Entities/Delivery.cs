using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;

namespace FabricsFactoryMethodPattern.Entities
{
    public class Delivery
    {
        public ObjectId ShipperId { get; set; }
        public string PackMethod { get; set; }
        public string Address { get; set; }
        public int Total { get; set; }
        public string time { get; set; }

        public Delivery()
        {
        }

    }
}
