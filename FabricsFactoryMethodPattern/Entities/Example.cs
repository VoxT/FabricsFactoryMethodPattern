using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;

namespace FabricsFactoryMethodPattern.Entities
{
    public class Example : IEntity
    {
        public ObjectId Id { get; private set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public Example()
        {
        }

    }
}
