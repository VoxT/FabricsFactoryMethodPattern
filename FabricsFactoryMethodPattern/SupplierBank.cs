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

        public void createSupplierBank(SupplierBank document)
        {
            supplierBankCollection.createDocument(document);
        }

        public List<SupplierBank> getAllSupplierBank()
        {
            return supplierBankCollection.selectAllDocument();
        }

        public SupplierBank getASupplierBank(ObjectId idSupplierBank)
        {
            return supplierBankCollection.selectADocument(idSupplierBank);
        }

        public Boolean deleteASupplierBank(ObjectId idSupplierBank)
        {
            return supplierBankCollection.deleteADocument(idSupplierBank);
        }

        public void UpdateASupplierBank(ObjectId idSupplierBank, SupplierBank document)
        {
            supplierBankCollection.UpdateADocument(idSupplierBank, document);

        }

    }
}
