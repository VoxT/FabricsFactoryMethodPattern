using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;

namespace FabricsFactoryMethodPattern
{
    public class GoodsSold
    {
        private GoodsSoldCollection goodsSoldCollection;

        public GoodsSold()
        {
            goodsSoldCollection = new GoodsSoldCollection();
        }

        public void createGoodsSold(GoodsSold document)
        {
            goodsSoldCollection.createDocument(document);
        }

        public List<GoodsSold> getAllGoodsSold()
        {
            return goodsSoldCollection.selectAllDocument();
        }

        public GoodsSold getAGoodsSold(ObjectId idGoodsSold)
        {
            return goodsSoldCollection.selectADocument(idGoodsSold);
        }

        public Boolean deleteAGoodsSold(ObjectId idGoodsSold)
        {
            return goodsSoldCollection.deleteADocument(idGoodsSold);
        }

        public void UpdateAGoodsSold(ObjectId idGoodsSold, GoodsSold document)
        {
            goodsSoldCollection.UpdateADocument(idGoodsSold, document);

        }

    }
}
