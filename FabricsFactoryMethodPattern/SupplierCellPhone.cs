using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;

namespace FabricsFactoryMethodPattern
{
    public class SupplierCellPhone
    {
        private SupplierCellPhoneCollection supplierCellPhoneCollection;

        public SupplierCellPhone()
        {
            supplierCellPhoneCollection = new SupplierCellPhoneCollection();
        }

        public void createSupplierCellPhone(SupplierCellPhone document)
        {
            supplierCellPhoneCollection.createDocument(document);
        }

        public List<SupplierCellPhone> getAllSupplierCellPhone()
        {
            return supplierCellPhoneCollection.selectAllDocument();
        }

        public SupplierCellPhone getASupplierCellPhone(ObjectId idSupplierCellPhone)
        {
            return supplierCellPhoneCollection.selectADocument(idSupplierCellPhone);
        }

        public Boolean deleteASupplierCellPhone(ObjectId idSupplierCellPhone)
        {
            return supplierCellPhoneCollection.deleteADocument(idSupplierCellPhone);
        }

        public void UpdateASupplierCellPhone(ObjectId idSupplierCellPhone, SupplierCellPhone document)
        {
            supplierCellPhoneCollection.UpdateADocument(idSupplierCellPhone, document);

        }

    }
}
