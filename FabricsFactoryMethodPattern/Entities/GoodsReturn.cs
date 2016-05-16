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
    public class GoodsReturn
    {

        [BsonElement("fabrics_roll_id")]
        public ObjectId FabricsRollId { get; set; }

        [BsonElement("date")]
        public DateTime Date { get; set; }

        [BsonConstructor]
        public GoodsReturn()
        {
            this.Date = DateTime.Now;
        }

        public GoodsReturn(ObjectId fabricsRollId)
        {
            this.FabricsRollId = fabricsRollId;
        }

        public GoodsReturn(ObjectId fabricsRollId, DateTime date)
        {
            this.FabricsRollId = fabricsRollId;
            this.Date = date;
        }
    }

}
