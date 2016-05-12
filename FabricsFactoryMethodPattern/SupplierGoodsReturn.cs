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
