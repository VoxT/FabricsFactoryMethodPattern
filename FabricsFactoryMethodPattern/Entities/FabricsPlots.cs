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
    public class FabricsPlots : Entity
    {

        [BsonElement("time")]
        public DateTime Time { get; set; }

        [BsonConstructor]
        public FabricsPlots()
        {
            this.Time = DateTime.Now;
        }

        [BsonConstructor]
        public FabricsPlots(DateTime time)
        {
            this.Time = time;
        }

    }
}
