using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;

namespace FabricsFactoryMethodPattern
{
    public abstract class Goods
    {
    }

    public class GoodsSold : Goods
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

    public class PurchaseGoods : Goods
    {
        private PurchaseGoodsCollection purchaseGoodsCollection;

        public PurchaseGoods()
        {
            purchaseGoodsCollection = new PurchaseGoodsCollection();
        }

        public void CreatePurchaseGoods(PurchaseGoods document)
        {
            purchaseGoodsCollection.CreateDocument(document);
        }

        public List<PurchaseGoods> GetAllPurchaseGoods()
        {
            return purchaseGoodsCollection.SelectAllDocument();
        }

        public PurchaseGoods GetAPurchaseGoods(ObjectId idPurchaseGoods)
        {
            return purchaseGoodsCollection.SelectADocument(idPurchaseGoods);
        }

        public Boolean DeleteAPurchaseGoods(ObjectId idPurchaseGoods)
        {
            return purchaseGoodsCollection.DeleteADocument(idPurchaseGoods);
        }

        public void UpdateAPurchaseGoods(ObjectId idPurchaseGoods, PurchaseGoods document)
        {
            purchaseGoodsCollection.UpdateADocument(idPurchaseGoods, document);

        }

    }
}
