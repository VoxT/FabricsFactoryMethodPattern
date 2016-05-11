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
            customerCollection.createDocument(document);
        }

        public List<BsonDocument> getAllCustomer()
        {
            return customerCollection.selectAllDocument();
        }

        public BsonDocument getACustomer(ObjectId idCustomer)
        {
            return customerCollection.selectADocument(idCustomer);
        }

        public Boolean deleteACustomer(ObjectId idCustomer)
        {
            return customerCollection.deleteADocument(idCustomer);
        }

        public void UpdateAcustomer(ObjectId idCustomer, BsonDocument document)
        {
            customerCollection.UpdateADocument(idCustomer, document);

        }
    }
}
