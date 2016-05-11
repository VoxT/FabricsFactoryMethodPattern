using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;

namespace FabricsFactoryMethodPattern
{
    public class Customer
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

        public List<BsonDocument> getAllCustomer()
        {
            return customerCollection.selectAllCustomer();
        }

        public BsonDocument getACustomer(ObjectId idCustomer)
        {
            return customerCollection.selectACustomer(idCustomer);
        }

        public Boolean deleteACustomer(ObjectId idCustomer)
        {
            return customerCollection.deleteACustomer(idCustomer);
        }

        public void UpdateAcustomer(ObjectId idCustomer, BsonDocument document)
        {
            customerCollection.UpdateACustomer(idCustomer, document);

        }
    }
}
