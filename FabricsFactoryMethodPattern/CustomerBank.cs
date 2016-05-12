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

        public void createCustomerBank(CustomerBank document)
        {
            customerBankCollection.createDocument(document);
        }

        public List<CustomerBank> getAllCustomerBank()
        {
            return customerBankCollection.selectAllDocument();
        }

        public CustomerBank getACustomerBank(ObjectId idCustomerBank)
        {
            return customerBankCollection.selectADocument(idCustomerBank);
        }

        public Boolean deleteACustomerBank(ObjectId idCustomerBank)
        {
            return customerBankCollection.deleteADocument(idCustomerBank);
        }

        public void UpdateACustomerBank(ObjectId idCustomerBank, CustomerBank document)
        {
            customerBankCollection.UpdateADocument(idCustomerBank, document);

        }

    }
}
