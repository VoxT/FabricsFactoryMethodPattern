using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;

namespace FabricsFactoryMethodPattern
{
    public class PurchaseGoods
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
