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
    public class Delivery
    {

        [BsonElement("shipper_id")]
        public ObjectId ShipperId { get; set; }

        [BsonElement("pack_method")]
        public string PackMethod { get; set; }

        [BsonElement("address")]
        public string Address { get; set; }

        [BsonElement("total")]
        public int Total { get; set; }

        [BsonElement("time")]
        public DateTime Time { get; set; }

        [BsonConstructor]
        public Delivery()
        {
            this.Time = DateTime.Now;
        }

        public Delivery(ObjectId shipperId, string packMethod, string address, int total)
        {
            this.ShipperId = shipperId;
            this.PackMethod = packMethod;
            this.Address = address;
            this.Total = total;
        }

        public Delivery(ObjectId shipperId, string packMethod, string address, int total, DateTime time)
        {
            this.ShipperId = shipperId;
            this.PackMethod = packMethod;
            this.Address = address;
            this.Total = total;
            this.Time = time;
        }

    }
}
