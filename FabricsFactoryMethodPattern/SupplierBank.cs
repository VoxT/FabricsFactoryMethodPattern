using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;

namespace FabricsFactoryMethodPattern
{
    public class SupplierBank
    {
        private SupplierBankCollection supplierBankCollection;

        public SupplierBank()
        {
            supplierBankCollection = new SupplierBankCollection();
        }

        public void CreateSupplierBank(SupplierBank document)
        {
            supplierBankCollection.CreateDocument(document);
        }

        public List<SupplierBank> GetAllSupplierBank()
        {
            return supplierBankCollection.SelectAllDocument();
        }

        public SupplierBank GetASupplierBank(ObjectId idSupplierBank)
        {
            return supplierBankCollection.SelectADocument(idSupplierBank);
        }

        public Boolean DeleteASupplierBank(ObjectId idSupplierBank)
        {
            return supplierBankCollection.DeleteADocument(idSupplierBank);
        }

        public void UpdateASupplierBank(ObjectId idSupplierBank, SupplierBank document)
        {
            supplierBankCollection.UpdateADocument(idSupplierBank, document);

        }

    }
}
