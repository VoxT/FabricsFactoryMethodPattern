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

        public void CreateSupplierDeskPhone(SupplierDeskPhone document)
        {
            supplierDeskPhoneCollection.CreateDocument(document);
        }

        public List<SupplierDeskPhone> GetAllSupplierDeskPhone()
        {
            return supplierDeskPhoneCollection.SelectAllDocument();
        }

        public SupplierDeskPhone GetASupplierDeskPhone(ObjectId idSupplierDeskPhone)
        {
            return supplierDeskPhoneCollection.SelectADocument(idSupplierDeskPhone);
        }

        public Boolean DeleteASupplierDeskPhone(ObjectId idSupplierDeskPhone)
        {
            return supplierDeskPhoneCollection.DeleteADocument(idSupplierDeskPhone);
        }

        public void UpdateASupplierDeskPhone(ObjectId idSupplierDeskPhone, SupplierDeskPhone document)
        {
            supplierDeskPhoneCollection.UpdateADocument(idSupplierDeskPhone, document);

        }

    }
}
