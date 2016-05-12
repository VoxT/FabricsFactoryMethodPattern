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

        public void CreateGoodsSold(GoodsSold document)
        {
            goodsSoldCollection.CreateDocument(document);
        }

        public List<GoodsSold> GetAllGoodsSold()
        {
            return goodsSoldCollection.SelectAllDocument();
        }

        public GoodsSold GetAGoodsSold(ObjectId idGoodsSold)
        {
            return goodsSoldCollection.SelectADocument(idGoodsSold);
        }

        public Boolean DeleteAGoodsSold(ObjectId idGoodsSold)
        {
            return goodsSoldCollection.DeleteADocument(idGoodsSold);
        }

        public void UpdateAGoodsSold(ObjectId idGoodsSold, GoodsSold document)
        {
            goodsSoldCollection.UpdateADocument(idGoodsSold, document);

        }

    }
}
