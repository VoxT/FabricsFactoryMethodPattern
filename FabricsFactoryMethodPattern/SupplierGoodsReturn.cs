using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;

namespace FabricsFactoryMethodPattern
{
    public class SupplierGoodsReturn
    {
        private SupplierGoodsReturnCollection supplierGoodsReturnCollection;

        public SupplierGoodsReturn()
        {
            supplierGoodsReturnCollection = new SupplierGoodsReturnCollection();
        }

        public void createSupplierGoodsReturn(SupplierGoodsReturn document)
        {
            supplierGoodsReturnCollection.createDocument(document);
        }

        public List<SupplierGoodsReturn> getAllSupplierGoodsReturn()
        {
            return supplierGoodsReturnCollection.selectAllDocument();
        }

        public SupplierGoodsReturn getASupplierGoodsReturn(ObjectId idSupplierGoodsReturn)
        {
            return supplierGoodsReturnCollection.selectADocument(idSupplierGoodsReturn);
        }

        public Boolean deleteASupplierGoodsReturn(ObjectId idSupplierGoodsReturn)
        {
            return supplierGoodsReturnCollection.deleteADocument(idSupplierGoodsReturn);
        }

        public void UpdateASupplierGoodsReturn(ObjectId idSupplierGoodsReturn, SupplierGoodsReturn document)
        {
            supplierGoodsReturnCollection.UpdateADocument(idSupplierGoodsReturn, document);

        }

    }
}
