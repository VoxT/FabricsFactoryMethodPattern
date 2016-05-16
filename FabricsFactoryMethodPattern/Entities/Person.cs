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
        [BsonElement("first_name")]
        public string FirstName { get; set; }

        [BsonElement("last_name")]
        public string LastName { get; set; }

        [BsonElement("email")]
        public string Email { get; set; }

        [BsonElement("address")]
        public string Address { get; set; }

        [BsonElement("cell_phone")]
        public List<CellPhone> CellPhones { get; set; }

        [BsonElement("desk_phone")]
        public List<DeskPhone> DeskPhones { get; set; }

        public Person()
        {
            this.CellPhones = new List<CellPhone>();
            this.DeskPhones = new List<DeskPhone>();
        }
    }

}
