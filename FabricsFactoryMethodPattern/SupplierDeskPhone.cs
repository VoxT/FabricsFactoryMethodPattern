using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;

namespace FabricsFactoryMethodPattern
{
    public class SupplierDeskPhone
    {
        private SupplierDeskPhoneCollection supplierDeskPhoneCollection;

        public SupplierDeskPhone()
        {
            supplierDeskPhoneCollection = new SupplierDeskPhoneCollection();
        }

        public void createSupplierDeskPhone(SupplierDeskPhone document)
        {
            supplierDeskPhoneCollection.createDocument(document);
        }

        public List<SupplierDeskPhone> getAllSupplierDeskPhone()
        {
            return supplierDeskPhoneCollection.selectAllDocument();
        }

        public SupplierDeskPhone getASupplierDeskPhone(ObjectId idSupplierDeskPhone)
        {
            return supplierDeskPhoneCollection.selectADocument(idSupplierDeskPhone);
        }

        public Boolean deleteASupplierDeskPhone(ObjectId idSupplierDeskPhone)
        {
            return supplierDeskPhoneCollection.deleteADocument(idSupplierDeskPhone);
        }

        public void UpdateASupplierDeskPhone(ObjectId idSupplierDeskPhone, SupplierDeskPhone document)
        {
            supplierDeskPhoneCollection.UpdateADocument(idSupplierDeskPhone, document);

        }

    }
}
