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

        public void CreateSupplier(Supplier document)
        {
            supplierCollection.CreateDocument(document);
        }

        public List<Supplier> GetAllSupplier()
        {
            return supplierCollection.SelectAllDocument();
        }

        public Supplier GetASupplier(ObjectId idsupplier)
        {
            return supplierCollection.SelectADocument(idsupplier);
        }

        public Boolean DeleteASupplier(ObjectId idSupplier)
        {
            return supplierCollection.DeleteADocument(idSupplier);
        }

        public void UpdateAsupplier(ObjectId idSupplier, Supplier document)
        {
            supplierCollection.UpdateADocument(idSupplier, document);

        }
    }
}
