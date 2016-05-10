using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;

namespace FabricsFactoryMethodPattern
{
    class Customer
    {
        private CustomerCollection customerCollection;

        public Customer()
        {
            customerCollection = new CustomerCollection();        
        }

        public void createCustomer(BsonDocument document)
        {
            customerCollection.createCustomer(document);
        }
    }
}
