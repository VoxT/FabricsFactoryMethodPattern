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
        public ObjectId Id { Get; set; }
        public string FirstName { Get; set; }
        public string LastName { Get; set; }
        public int Age { Get; set; }

        private ExampleCollection collection;

        public Example()
        {
            collection = new ExampleCollection();
        }

        public void CreateExample(Example example)
        {

            collection.CreateDocument(example);
        }

        public List<Example> GetExample()
        {
            
            return collection.SelectAllDocument();

        }

        public void UpdateExample(ObjectId id, Example example)
        {
            collection.UpdateADocument(id, example);
        }

        public void UpdateExample(ObjectId id, BsonDocument example)
        {
            collection.UpdateADocument(id, example);
        }

        public String GetString()
        {
            return "Success";
        }
    }
}
