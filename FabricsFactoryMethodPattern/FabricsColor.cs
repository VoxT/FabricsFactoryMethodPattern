using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;

namespace FabricsFactoryMethodPattern
{
    public class FabricsColor
    {
        private FabricsColorCollection fabricColorCollection;

        public FabricsColor()
        {
            fabricColorCollection = new FabricsColorCollection();
        }

        public void createFabricColor(BsonDocument document)
        {
            fabricColorCollection.createDocument(document);
        }

        public List<BsonDocument> getAllFabricColor()
        {
            return fabricColorCollection.selectAllDocument();
        }

        public BsonDocument getAFabricColor(ObjectId idFabricColor)
        {
            return fabricColorCollection.selectADocument(idFabricColor);
        }

        public Boolean deleteAFabricColor(ObjectId idFabricColor)
        {
            return fabricColorCollection.deleteADocument(idFabricColor);
        }

        public void UpdateAFabricColor(ObjectId idFabricColor, BsonDocument document)
        {
            fabricColorCollection.UpdateADocument(idFabricColor, document);

        }

    }
}
