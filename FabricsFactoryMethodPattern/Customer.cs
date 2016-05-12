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

        public void createCustomer(Customer document)
        {
            customerCollection.createDocument(document);
        }

        public List<Customer> getAllCustomer()
        {
            return customerCollection.selectAllDocument();
        }

        public Customer getACustomer(ObjectId idCustomer)
        {
            return customerCollection.selectADocument(idCustomer);
        }

        public Boolean deleteACustomer(ObjectId idCustomer)
        {
            return customerCollection.deleteADocument(idCustomer);
        }

        public void UpdateAcustomer(ObjectId idCustomer, Customer document)
        {
            customerCollection.UpdateADocument(idCustomer, document);

        }
    }
}
