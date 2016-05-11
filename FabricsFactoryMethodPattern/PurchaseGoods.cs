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

        public void createPurchaseGoods(BsonDocument document)
        {
            purchaseGoodsCollection.createDocument(document);
        }

        public List<BsonDocument> getAllPurchaseGoods()
        {
            return purchaseGoodsCollection.selectAllDocument();
        }

        public BsonDocument getAPurchaseGoods(ObjectId idPurchaseGoods)
        {
            return purchaseGoodsCollection.selectADocument(idPurchaseGoods);
        }

        public Boolean deleteAPurchaseGoods(ObjectId idPurchaseGoods)
        {
            return purchaseGoodsCollection.deleteADocument(idPurchaseGoods);
        }

        public void UpdateAPurchaseGoods(ObjectId idPurchaseGoods, BsonDocument document)
        {
            purchaseGoodsCollection.UpdateADocument(idPurchaseGoods, document);

        }

    }
}
