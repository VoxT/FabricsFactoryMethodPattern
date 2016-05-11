using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;

namespace FabricsFactoryMethodPattern
{
    class GoodsSold
    {
        private GoodsSoldCollection goodsSoldCollection;

        public GoodsSold()
        {
            goodsSoldCollection = new GoodsSoldCollection();
        }

        public void createGoodsSold(BsonDocument document)
        {
            goodsSoldCollection.createDocument(document);
        }

        public List<BsonDocument> getAllGoodsSold()
        {
            return goodsSoldCollection.selectAllDocument();
        }

        public BsonDocument getAGoodsSold(ObjectId idGoodsSold)
        {
            return goodsSoldCollection.selectADocument(idGoodsSold);
        }

        public Boolean deleteAGoodsSold(ObjectId idGoodsSold)
        {
            return goodsSoldCollection.deleteADocument(idGoodsSold);
        }

        public void UpdateAGoodsSold(ObjectId idGoodsSold, BsonDocument document)
        {
            goodsSoldCollection.UpdateADocument(idGoodsSold, document);

        }

    }
}
