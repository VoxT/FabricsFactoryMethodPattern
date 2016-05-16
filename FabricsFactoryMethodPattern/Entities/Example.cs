using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Bson.Serialization.Attributes;
using System.ComponentModel.DataAnnotations;

namespace FabricsFactoryMethodPattern.Entities
{
    public class Example : IEntity
    {
        public ObjectId Id { get; private set; }

        [Required(ErrorMessage = "First Name is required.")]
        [BsonElement("first_name")]
        public string FirstName { get; set; }

        [StringLength(255, MinimumLength = 5)]
        [BsonElement("last_name")]
        public string LastName { get; set; }
                
        [BsonElement("age")]
        public int Age { get; set; }

        public Example()
        {
        }

    }
}
