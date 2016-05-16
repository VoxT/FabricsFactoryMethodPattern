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
    public class Leave
    {

        [BsonElement("date")]
        public DateTime Date { get; set; }

        [BsonConstructor]
        public Leave()
        {
            this.Date = DateTime.Now;
        }

        public Leave(DateTime date)
        {
            this.Date = date;
        }
    }
}
