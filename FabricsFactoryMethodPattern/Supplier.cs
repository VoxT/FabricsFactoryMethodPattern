using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;

namespace FabricsFactoryMethodPattern
{
    public class Supplier
    { 
        private SupplierCollection supplierCollection;

        public Supplier()
        {
            supplierCollection = new SupplierCollection();
        }

        public void createSupplier(BsonDocument document)
        {
            supplierCollection.createDocument(document);
        }

        public List<BsonDocument> getAllSupplier()
        {
            return supplierCollection.selectAllDocument();
        }

        public BsonDocument getASupplier(ObjectId idsupplier)
        {
            return supplierCollection.selectADocument(idsupplier);
        }

        public Boolean deleteASupplier(ObjectId idSupplier)
        {
            return supplierCollection.deleteADocument(idSupplier);
        }

        public void UpdateAsupplier(ObjectId idSupplier, BsonDocument document)
        {
            supplierCollection.UpdateADocument(idSupplier, document);

        }
    }
}
