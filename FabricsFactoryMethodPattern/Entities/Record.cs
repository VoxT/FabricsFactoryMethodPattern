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
    public class Record : Entity
    {

        [BsonElement("money")]
        public double Monney { get; set; }

        [BsonElement("time")]
        public DateTime Time { get; set; }

        [BsonElement("note")]
        public string Note { get; set; }

        [BsonElement("payment_id")]
        public ObjectId PaymentId { get; set; }

        [BsonConstructor]
        public Record()
        {
            Time = DateTime.Now;
        }
    }
}
