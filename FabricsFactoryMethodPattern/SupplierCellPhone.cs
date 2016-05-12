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

        public void CreateSupplierCellPhone(SupplierCellPhone document)
        {
            supplierCellPhoneCollection.CreateDocument(document);
        }

        public List<SupplierCellPhone> GetAllSupplierCellPhone()
        {
            return supplierCellPhoneCollection.SelectAllDocument();
        }

        public SupplierCellPhone GetASupplierCellPhone(ObjectId idSupplierCellPhone)
        {
            return supplierCellPhoneCollection.SelectADocument(idSupplierCellPhone);
        }

        public Boolean DeleteASupplierCellPhone(ObjectId idSupplierCellPhone)
        {
            return supplierCellPhoneCollection.DeleteADocument(idSupplierCellPhone);
        }

        public void UpdateASupplierCellPhone(ObjectId idSupplierCellPhone, SupplierCellPhone document)
        {
            supplierCellPhoneCollection.UpdateADocument(idSupplierCellPhone, document);

        }

    }
}
