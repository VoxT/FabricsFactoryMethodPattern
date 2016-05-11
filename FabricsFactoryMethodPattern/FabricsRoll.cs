using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;

namespace FabricsFactoryMethodPattern
{
    class FabricsRoll
    {
        private FabricsRollCollection fabricRollCollection;

        public FabricsRoll()
        {
            fabricRollCollection = new FabricsRollCollection();
        }

        public void createFabricRoll(BsonDocument document)
        {
            fabricRollCollection.createDocument(document);
        }

        public List<BsonDocument> getAllFabricRoll()
        {
            return fabricRollCollection.selectAllDocument();
        }

        public BsonDocument getAFabricRoll(ObjectId idFabricRoll)
        {
            return fabricRollCollection.selectADocument(idFabricRoll);
        }

        public Boolean deleteAFabricRoll(ObjectId idFabricRoll)
        {
            return fabricRollCollection.deleteADocument(idFabricRoll);
        }

        public void UpdateAFabricRoll(ObjectId idFabricRoll, BsonDocument document)
        {
            fabricRollCollection.UpdateADocument(idFabricRoll, document);

        }

    }
}
