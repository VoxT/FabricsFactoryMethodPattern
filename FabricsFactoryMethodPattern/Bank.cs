using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;

namespace FabricsFactoryMethodPattern
{
    public abstract class Bank
    {

    }

    public class CustomerBank : Bank
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

    public class SupplierBank : Bank
    {
        private SupplierBankCollection supplierBankCollection;

        public SupplierBank()
        {
            supplierBankCollection = new SupplierBankCollection();
        }

        public void CreateSupplierBank(SupplierBank document)
        {
            supplierBankCollection.CreateDocument(document);
        }

        public List<SupplierBank> GetAllSupplierBank()
        {
            return supplierBankCollection.SelectAllDocument();
        }

        public SupplierBank GetASupplierBank(ObjectId idSupplierBank)
        {
            return supplierBankCollection.SelectADocument(idSupplierBank);
        }

        public Boolean DeleteASupplierBank(ObjectId idSupplierBank)
        {
            return supplierBankCollection.DeleteADocument(idSupplierBank);
        }

        public void UpdateASupplierBank(ObjectId idSupplierBank, SupplierBank document)
        {
            supplierBankCollection.UpdateADocument(idSupplierBank, document);

        }

    }
}
