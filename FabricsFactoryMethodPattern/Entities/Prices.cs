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

        [BsonElement("fabrics_color_id")]
        public ObjectId FabricsColorId { get; set; }

        [BsonElement("time")]
        public DateTime Time { get; set; }

        [BsonElement("price")]
        public int Price { get; set; }

        public Prices()
        {
            this.Time = DateTime.Now;
        }

        [BsonConstructor]
        public Prices(ObjectId fabricsColorId, int price)
        {
            this.FabricsColorId = fabricsColorId;
            this.Price = price;
            this.Time = DateTime.Now;
        }

        [BsonConstructor]
        public Prices(ObjectId fabricsColorId, int price, DateTime time)
        {
            this.FabricsColorId = fabricsColorId;
            this.Price = price;
            this.Time = DateTime.Now;
        }
    }

}
