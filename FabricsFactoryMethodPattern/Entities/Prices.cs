using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.ComponentModel.DataAnnotations;

namespace FabricsFactoryMethodPattern.Entities
{
    public class Prices
    {

        [BsonElement("fabrics_color_id")]
        public ObjectId FabricsColorId { get; set; }

        [BsonElement("time")]
        public DateTime Time { get; set; }

        [Required(ErrorMessage = "Price is required")]
        [Range(0.01, 100.00,
            ErrorMessage = "Price must be between 0.01 and 100.00")]
        [BsonElement("price")]
        public int Price { get; set; }

        [BsonConstructor]
        public Prices()
        {
            this.Time = DateTime.Now;
        }

        public Prices(ObjectId fabricsColorId, int price)
        {
            this.FabricsColorId = fabricsColorId;
            this.Price = price;
            this.Time = DateTime.Now;
        }

        public Prices(ObjectId fabricsColorId, int price, DateTime time)
        {
            this.FabricsColorId = fabricsColorId;
            this.Price = price;
            this.Time = DateTime.Now;
        }
    }

}
