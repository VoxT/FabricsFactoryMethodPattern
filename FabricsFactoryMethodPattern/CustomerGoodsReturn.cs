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
        private SupplierCollection customerGoodsReturnCollection;

        public CustomerGoodsReturn()
        {
            customerGoodsReturnCollection = new SupplierCollection();
        }

        public void createCustomerGoodsReturn(BsonDocument document)
        {
            customerGoodsReturnCollection.createDocument(document);
        }

        public List<BsonDocument> getAllCustomerGoodsReturn()
        {
            return customerGoodsReturnCollection.selectAllDocument();
        }

        public BsonDocument getACustomerGoodsReturn(ObjectId idCustomerGoodsReturn)
        {
            return customerGoodsReturnCollection.selectADocument(idCustomerGoodsReturn);
        }

        public Boolean deleteACustomerGoodsReturn(ObjectId idCustomerGoodsReturn)
        {
            return customerGoodsReturnCollection.deleteADocument(idCustomerGoodsReturn);
        }

        public void UpdateACustomerGoodsReturn(ObjectId idCustomerGoodsReturn, BsonDocument document)
        {
            customerGoodsReturnCollection.UpdateADocument(idCustomerGoodsReturn, document);
        }

    }
}
