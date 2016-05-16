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
    public class FabricsColor : Entity
    {

        [BsonElement("color_name")]
        public string ColorName { get; set; }

        [BsonElement("fabrics_id")]
        public ObjectId FabricsId { get; set; }

        public FabricsColor()
        {
        }

        [BsonConstructor]
        public FabricsColor(string colorName, ObjectId fabricsId)
        {
            this.ColorName = colorName;
            this.FabricsId = fabricsId;
        }

    }
}
