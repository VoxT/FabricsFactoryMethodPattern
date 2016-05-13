using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;

namespace FabricsFactoryMethodPattern
{
    public class FabricsRoll
    {
        public ObjectId Id { get; private set; }
        public string Length { get; set; }
        public ObjectId FabricsId { get; set; }
        public ObjectId PlotsId { get; set; }
        public ObjectId PurchaseInvoiceId { get; set; }
        public ObjectId SalesInvoiceId { get; set; }

        private FabricsRollCollection fabricRollCollection;

        public FabricsRoll()
        {
            fabricRollCollection = new FabricsRollCollection();
        }

        public void CreateFabricRoll(FabricsRoll document)
        {
            fabricRollCollection.CreateDocument(document);
        }

        public List<FabricsRoll> GetAllFabricRoll()
        {
            return fabricRollCollection.SelectAllDocument();
        }

        public FabricsRoll GetAFabricRoll(ObjectId idFabricRoll)
        {
            return fabricRollCollection.SelectADocument(idFabricRoll);
        }

        public Boolean DeleteAFabricRoll(ObjectId idFabricRoll)
        {
            return fabricRollCollection.DeleteADocument(idFabricRoll);
        }

        public void UpdateAFabricRoll(ObjectId idFabricRoll, FabricsRoll document)
        {
            fabricRollCollection.UpdateADocument(idFabricRoll, document);

        }

    }
}
