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

        public void CreateCustomer(Customer document)
        {
            customerCollection.CreateDocument(document);
        }

        public List<Customer> GetAllCustomer()
        {
            return customerCollection.SelectAllDocument();
        }

        public Customer GetACustomer(ObjectId idCustomer)
        {
            return customerCollection.SelectADocument(idCustomer);
        }

        public Boolean DeleteACustomer(ObjectId idCustomer)
        {
            return customerCollection.DeleteADocument(idCustomer);
        }

        public void UpdateAcustomer(ObjectId idCustomer, Customer document)
        {
            customerCollection.UpdateADocument(idCustomer, document);

        }
    }
}
