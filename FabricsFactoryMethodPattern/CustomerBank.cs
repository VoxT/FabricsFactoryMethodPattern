using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;

namespace FabricsFactoryMethodPattern
{
    public class CustomerBank
    {
        private CustomerBankCollection customerBankCollection;

        public CustomerBank()
        {
            customerBankCollection = new CustomerBankCollection();
        }

        public void CreateCustomerBank(CustomerBank document)
        {
            customerBankCollection.CreateDocument(document);
        }

        public List<CustomerBank> GetAllCustomerBank()
        {
            return customerBankCollection.SelectAllDocument();
        }

        public CustomerBank GetACustomerBank(ObjectId idCustomerBank)
        {
            return customerBankCollection.SelectADocument(idCustomerBank);
        }

        public Boolean DeleteACustomerBank(ObjectId idCustomerBank)
        {
            return customerBankCollection.DeleteADocument(idCustomerBank);
        }

        public void UpdateACustomerBank(ObjectId idCustomerBank, CustomerBank document)
        {
            customerBankCollection.UpdateADocument(idCustomerBank, document);

        }

    }
}
