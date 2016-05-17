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
    public abstract class InvoiceService<T> : EntityService<T> where T : IEntity
    {
        public void UpdateStatus()
        { 
            
        }
    }

    /// <summary>
    /// class PurchaseInvoiceService.
    /// provided API for a pủchase invoice.
    /// </summary>
    public class PurchaseInvoiceService : InvoiceService<PurchaseInvoice>
    {
        /// <summary>
        /// Contructor
        /// </summary>
        public PurchaseInvoiceService()
        {
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
