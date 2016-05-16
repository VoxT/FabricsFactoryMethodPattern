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
    public class Goods
    {

        [BsonElement("fabrics_color_id")]
        public ObjectId FabricsColorId { get; set; }

        [BsonElement("total_metter")]
        public int TotalMetter { get; set; }

        [BsonElement("total_roll")]
        public int TotalRoll { get; set; }

        public Goods() { }

        [BsonConstructor]
        public Goods(ObjectId fabricsColorId, int totalMetter, int totalRoll)
        {
            this.FabricsColorId = fabricsColorId;
            this.TotalMetter = totalMetter;
            this.TotalRoll = totalRoll;
        }

    }

}
