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
    public class Fabrics : Entity
    {

        [BsonElement("name")]
        public string Name { get; set; }

        [BsonElement("description")]
        public string Description { get; set; }

        public Fabrics()
        {
        }

        [BsonConstructor]
        public Fabrics(string name, string  description)
        {
            this.Name = name;
            this.Description = description;
        }
    }
}
