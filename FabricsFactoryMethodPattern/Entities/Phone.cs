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
    public class Phone
    {
        [BsonElement("phone")]
        public string PhoneNumber { get; set; }

        [BsonConstructor]
        public Phone() { }

        public Phone(string phoneNumber)
        {
            this.PhoneNumber = phoneNumber;
        }
    }


}
