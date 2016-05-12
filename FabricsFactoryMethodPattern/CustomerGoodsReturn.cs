using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;

namespace FabricsFactoryMethodPattern
{
    public class CustomerGoodsReturn
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
}
