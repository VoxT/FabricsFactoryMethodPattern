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

        public void createPurchaseGoods(PurchaseGoods document)
        {
            purchaseGoodsCollection.createDocument(document);
        }

        public List<PurchaseGoods> getAllPurchaseGoods()
        {
            return purchaseGoodsCollection.selectAllDocument();
        }

        public PurchaseGoods getAPurchaseGoods(ObjectId idPurchaseGoods)
        {
            return purchaseGoodsCollection.selectADocument(idPurchaseGoods);
        }

        public Boolean deleteAPurchaseGoods(ObjectId idPurchaseGoods)
        {
            return purchaseGoodsCollection.deleteADocument(idPurchaseGoods);
        }

        public void UpdateAPurchaseGoods(ObjectId idPurchaseGoods, PurchaseGoods document)
        {
            purchaseGoodsCollection.UpdateADocument(idPurchaseGoods, document);

        }

    }
}
