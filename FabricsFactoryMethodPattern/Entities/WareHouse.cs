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
    public class WareHouse : Entity
    {
        [BsonElement("name")]
        public string Name { get; set; }

        [BsonElement("areage")]
        public int Areage { get; set; }

        [BsonElement("address")]
        public string Address { get; set; }

        public WareHouse()
        {
        }

        [BsonConstructor]
        public WareHouse(string name, int areage, string address)
        {
            this.Name = name;
            this.Areage = areage;
            this.Address = address;
        }
        
    }
}
