using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;

namespace FabricsFactoryMethodPattern
{
    class SupplierDeskPhone
    {
        private SupplierDeskPhoneCollection supplierDeskPhoneCollection;

        public SupplierDeskPhone()
        {
            supplierDeskPhoneCollection = new SupplierDeskPhoneCollection();
        }

        public void createSupplierDeskPhone(BsonDocument document)
        {
            supplierDeskPhoneCollection.createDocument(document);
        }

        public List<BsonDocument> getAllSupplierDeskPhone()
        {
            return supplierDeskPhoneCollection.selectAllDocument();
        }

        public BsonDocument getASupplierDeskPhone(ObjectId idSupplierDeskPhone)
        {
            return supplierDeskPhoneCollection.selectADocument(idSupplierDeskPhone);
        }

        public Boolean deleteASupplierDeskPhone(ObjectId idSupplierDeskPhone)
        {
            return supplierDeskPhoneCollection.deleteADocument(idSupplierDeskPhone);
        }

        public void UpdateASupplierDeskPhone(ObjectId idSupplierDeskPhone, BsonDocument document)
        {
            supplierDeskPhoneCollection.UpdateADocument(idSupplierDeskPhone, document);

        }

    }
}
