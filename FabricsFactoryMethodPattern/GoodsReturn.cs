using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;

namespace FabricsFactoryMethodPattern
{
    public abstract class GoodsReturn
    {
    }

    public class CustomerGoodsReturn : GoodsReturn
    {
        private CustomerGoodsReturnCollection customerGoodsReturnCollection;

        public CustomerGoodsReturn()
        {
            customerGoodsReturnCollection = new CustomerGoodsReturnCollection();
        }

        public void CreateCustomerGoodsReturn(CustomerGoodsReturn document)
        {
            customerGoodsReturnCollection.CreateDocument(document);
        }

        public List<CustomerGoodsReturn> GetAllCustomerGoodsReturn()
        {
            return customerGoodsReturnCollection.SelectAllDocument();
        }

        public CustomerGoodsReturn GetACustomerGoodsReturn(ObjectId idCustomerGoodsReturn)
        {
            return customerGoodsReturnCollection.SelectADocument(idCustomerGoodsReturn);
        }

        public Boolean DeleteACustomerGoodsReturn(ObjectId idCustomerGoodsReturn)
        {
            return customerGoodsReturnCollection.DeleteADocument(idCustomerGoodsReturn);
        }

        public void UpdateACustomerGoodsReturn(ObjectId idCustomerGoodsReturn, CustomerGoodsReturn document)
        {
            customerGoodsReturnCollection.UpdateADocument(idCustomerGoodsReturn, document);
        }

    }

    public class SupplierGoodsReturn : GoodsReturn
    {
        private SupplierGoodsReturnCollection supplierGoodsReturnCollection;

        public SupplierGoodsReturn()
        {
            supplierGoodsReturnCollection = new SupplierGoodsReturnCollection();
        }

        public void CreateSupplierGoodsReturn(SupplierGoodsReturn document)
        {
            supplierGoodsReturnCollection.CreateDocument(document);
        }

        public List<SupplierGoodsReturn> GetAllSupplierGoodsReturn()
        {
            return supplierGoodsReturnCollection.SelectAllDocument();
        }

        public SupplierGoodsReturn GetASupplierGoodsReturn(ObjectId idSupplierGoodsReturn)
        {
            return supplierGoodsReturnCollection.SelectADocument(idSupplierGoodsReturn);
        }

        public Boolean DeleteASupplierGoodsReturn(ObjectId idSupplierGoodsReturn)
        {
            return supplierGoodsReturnCollection.DeleteADocument(idSupplierGoodsReturn);
        }

        public void UpdateASupplierGoodsReturn(ObjectId idSupplierGoodsReturn, SupplierGoodsReturn document)
        {
            supplierGoodsReturnCollection.UpdateADocument(idSupplierGoodsReturn, document);

        }

    }
}
