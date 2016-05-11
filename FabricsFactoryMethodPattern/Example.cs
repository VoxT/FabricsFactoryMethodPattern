using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;

namespace FabricsFactoryMethodPattern
{
    public class Example
    {
        public ObjectId Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        private ExampleCollection collection;

        public Example()
        {
            collection = new ExampleCollection();
        }

        public void createExample()
        {
            Example example = new Example {
                   Id = ObjectId.GenerateNewId(),
                   FirstName = "Bob",
                   LastName = "Baker",
                   Age = 36
                };

            collection.createDocument(example);
        }
    }
}
