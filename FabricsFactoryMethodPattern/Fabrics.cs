using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;

namespace FabricsFactoryMethodPattern
{
    class Fabrics
    {
        private FabricsCollection fabricsCollection;

        public Fabrics()
        {
            fabricsCollection = new FabricsCollection();
        }

        public void createFabrics(BsonDocument document)
        {
            fabricsCollection.createDocument(document);
        }

        public List<BsonDocument> getAllFabrics()
        {
            return fabricsCollection.selectAllDocument();
        }

        public BsonDocument getAFabrics(ObjectId idFabrics)
        {
            return fabricsCollection.selectADocument(idFabrics);
        }

        public Boolean deleteAFabrics(ObjectId idFabrics)
        {
            return fabricsCollection.deleteADocument(idFabrics);
        }

        public void UpdateAFabrics(ObjectId idFabrics, BsonDocument document)
        {
            fabricsCollection.UpdateADocument(idFabrics, document);

        }
    }
}
