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

    /// <summary>
    /// abstract class InvoiceService.
    /// base class for invoice
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class InvoiceService<T> : EntityService<T> where T : Invoice
    {
        public abstract List<FabricsRoll> GetFabricsRoll(string id);

        public abstract double GetTotalMoney(T entity);

        public List<T> GetInvoiceByDate(DateTime fromDate, DateTime toDate)
        {
            var filterBuilder = Builders<T>.Filter;
            var filter = filterBuilder.Gt(p => p.Time, fromDate) & filterBuilder.Lt(p => p.Time, toDate);
            return this.Collection.Find(filter).ToList();
        }
    }

    /// <summary>
    /// class PurchaseInvoiceService.
    /// provided API for a purchase invoice.
    /// </summary>
    public class PurchaseInvoiceService : InvoiceService<PurchaseInvoice>
    {
        /// <summary>
        /// Contructor
        /// </summary>
        public PurchaseInvoiceService()
        {
        }

        public List<PurchaseInvoice> GetInvoiceForWareHouse(string id)
        {
            var filter = Builders<PurchaseInvoice>.Filter.Eq(p => p.WareHouseId, ObjectId.Parse(id));
            return this.Collection.Find(filter).ToList();
        }

        public List<PurchaseInvoice> GetInvoiceForSupplier(string id)
        {
            var filter = Builders<PurchaseInvoice>.Filter.Eq(p => p.SupplierId, ObjectId.Parse(id));
            return this.Collection.Find(filter).ToList();
        }

        public override List<FabricsRoll> GetFabricsRoll(string id)
        {
            FabricsRollService service = new FabricsRollService();
            return service.GetFabricsRollForPurchaseInvoice(id);
        }

        public override double GetTotalMoney(PurchaseInvoice entity)
        {
            var fabricsRoll = this.GetFabricsRoll(entity.Id.ToString());

            SupplierService supplierService = new SupplierService();
            var prices = supplierService.GetById(entity.SupplierId.ToString()).Prices;

            var totalMoney = 0;
            foreach(var roll in fabricsRoll)
            {
                var fabricsColor = prices.Where(p => p.FabricsColorId == roll.FabricsColorId).FirstOrDefault();
                totalMoney += roll.Length * fabricsColor.Price;
            }

            return totalMoney;
        }
    }

    /// <summary>
    /// Class SalesInvoiceService. 
    /// provided API for a sales invoice.
    /// </summary>
    public class SalesInvoiceService : InvoiceService<SalesInvoice>
    {
        /// <summary>
        /// contructor
        /// </summary>
        public SalesInvoiceService()
        {
        }

        public List<SalesInvoice> GetInvoiceForCustomer(string id)
        {
            var filter = Builders<SalesInvoice>.Filter.Eq(p => p.CustomerId, ObjectId.Parse(id));
            return this.Collection.Find(filter).ToList();
        }

        public override List<FabricsRoll> GetFabricsRoll(string id)
        {
            FabricsRollService service = new FabricsRollService();
            return service.GetFabricsRollForSalesInvoice(id);
        }

        public override double GetTotalMoney(SalesInvoice entity)
        {
            var fabricsRoll = this.GetFabricsRoll(entity.Id.ToString());

            CustomerService supplierService = new CustomerService();
            var prices = supplierService.GetById(entity.CustomerId.ToString()).Prices;

            var totalMoney = 0;
            foreach (var roll in fabricsRoll)
            {
                var fabricsColor = prices.Where(p => p.FabricsColorId == roll.FabricsColorId).FirstOrDefault();
                totalMoney += roll.Length * fabricsColor.Price;
            }

            return totalMoney;
        }

        /// <summary>
        /// Add a delivery to Invoice.
        /// </summary>
        /// <param name="id"> Id sales invoice </param>
        /// <param name="delivery"> Delivery info </param>
        public void AddDelivery(string id, Delivery delivery)
        {
            var filter = Builders<SalesInvoice>.Filter.Eq(p => p.Id, ObjectId.Parse(id));
            var update = Builders<SalesInvoice>.Update.Push<Delivery>(p => p.Delivery, delivery);
            var updateResult = this.Collection.UpdateOne(filter, update);
        }

        /// <summary>
        /// Add list Delivery to Invoice.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="phones"></param>
        public void AddDelivery(string id, List<Delivery> phones)
        {
            var filter = Builders<SalesInvoice>.Filter.Eq(p => p.Id, ObjectId.Parse(id));
            foreach (var value in phones)
            {
                var update = Builders<SalesInvoice>.Update.Push<Delivery>(p => p.Delivery, value);
                this.Collection.UpdateOne(filter, update);
            }

        }
    }

}
