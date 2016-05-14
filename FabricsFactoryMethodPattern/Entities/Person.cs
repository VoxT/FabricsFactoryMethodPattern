using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson.Serialization.Attributes;

namespace FabricsFactoryMethodPattern.Entities
{
    public abstract class Person : Entity
    {
        [BsonElement("name")]
        public string Name { get; set; }
        public List<CellPhone> CellPhones { get; set; }
        public List<DeskPhone> DeskPhones { get; set; }

        [BsonElement("email")]
        public string Email { get; set; }

        [BsonElement("address")]
        public string Address { get; set; }

        public Person()
        {
            CellPhones = new List<CellPhone>();
            DeskPhones = new List<DeskPhone>();
        }
    }

}
