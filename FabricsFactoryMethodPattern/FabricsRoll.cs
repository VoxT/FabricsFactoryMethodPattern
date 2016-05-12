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

        public void createFabricRoll(FabricsRoll document)
        {
            fabricRollCollection.createDocument(document);
        }

        public List<FabricsRoll> getAllFabricRoll()
        {
            return fabricRollCollection.selectAllDocument();
        }

        public FabricsRoll getAFabricRoll(ObjectId idFabricRoll)
        {
            return fabricRollCollection.selectADocument(idFabricRoll);
        }

        public Boolean deleteAFabricRoll(ObjectId idFabricRoll)
        {
            return fabricRollCollection.deleteADocument(idFabricRoll);
        }

        public void UpdateAFabricRoll(ObjectId idFabricRoll, FabricsRoll document)
        {
            fabricRollCollection.UpdateADocument(idFabricRoll, document);

        }

    }
}
