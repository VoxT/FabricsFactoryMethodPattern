using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;
using FabricsFactoryMethodPattern.Entities;

namespace FabricsFactoryMethodPattern.Services
{
    using Entities;
    public class FabricsRollService : EntityService<FabricsRoll>
    {
        public FabricsRollService()
        {
        }

        public override void Create(FabricsRoll entity)
        {
        //    /*------------------------- update supplier debt ----------------------- */
        //    // get purchase invoice
        //    PurchaseInvoiceService purchaseInvoiceService = new PurchaseInvoiceService();
        //    var purchaseInvoice = purchaseInvoiceService.GetById(entity.PurchaseInvoiceId.ToString());
        //    // get supplier
        //    SupplierService supplierService = new SupplierService();
        //    var supplier = supplierService.GetById(purchaseInvoice.SupplierId.ToString());
        //    // get list supplier price
        //    var prices = supplier.Prices;
        //    // get fabrics color price
        //    var fabricsColorPrice = prices.Where(p => p.FabricsColorId == entity.FabricsColorId).FirstOrDefault().Price;
        //    // update supplier debt
        //    supplier.Debts += (1 - purchaseInvoice.DiscountPercent) * fabricsColorPrice * entity.Length;
        //    supplierService.Update(supplier);

        //    /*------------------------ Update purchase order status -------------------*/


            base.Create(entity);
        }

        public List<FabricsRoll> GetFabricsRollForSalesInvoice(string salesInvoiceId)
        {
            var filter = Builders<FabricsRoll>.Filter.Eq(p => p.SalesInvoiceId, ObjectId.Parse(salesInvoiceId));
            var sort = Builders<FabricsRoll>.Sort.Ascending(p => p.FabricsColorId);
            var result = this.Collection.Find(filter).Sort(sort).ToList();

            return result;
        }

        public List<FabricsRoll> GetFabricsRollForPurchaseInvoice(string purchaseInvoiceId)
        {
            var filter = Builders<FabricsRoll>.Filter.Eq(p => p.PurchaseInvoiceId, ObjectId.Parse(purchaseInvoiceId));
            var sort = Builders<FabricsRoll>.Sort.Ascending(p => p.FabricsColorId);
            var result = this.Collection.Find(filter).Sort(sort).ToList();

            return result;
        }

    }
}
