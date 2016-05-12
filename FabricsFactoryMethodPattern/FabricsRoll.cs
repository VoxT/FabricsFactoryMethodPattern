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
