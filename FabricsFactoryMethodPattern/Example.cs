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
                   FirstName = "Bobbi",
                   LastName = "Baker lol",
                   Age = 32
                };

            collection.createDocument(example);
        }

        public void createExampleBson()
        {
            var example = new BsonDocument
            {
                {"FirstName" , "Vo Tien"},
                {"LastName" , "Thieu"},
                {"Age", 12}
            };

            collection.createDocument(example);
        }
    }
}
