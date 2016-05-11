using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;

namespace FabricsFactoryMethodPattern
{
    class SupplierCellPhone
    {
        private SupplierCellPhoneCollection supplierCellPhoneCollection;

        public SupplierCellPhone()
        {
            supplierCellPhoneCollection = new SupplierCellPhoneCollection();
        }

        public void createSupplierCellPhone(BsonDocument document)
        {
            supplierCellPhoneCollection.createDocument(document);
        }

        public List<BsonDocument> getAllSupplierCellPhone()
        {
            return supplierCellPhoneCollection.selectAllDocument();
        }

        public BsonDocument getASupplierCellPhone(ObjectId idSupplierCellPhone)
        {
            return supplierCellPhoneCollection.selectADocument(idSupplierCellPhone);
        }

        public Boolean deleteASupplierCellPhone(ObjectId idSupplierCellPhone)
        {
            return supplierCellPhoneCollection.deleteADocument(idSupplierCellPhone);
        }

        public void UpdateASupplierCellPhone(ObjectId idSupplierCellPhone, BsonDocument document)
        {
            supplierCellPhoneCollection.UpdateADocument(idSupplierCellPhone, document);

        }

    }
}
