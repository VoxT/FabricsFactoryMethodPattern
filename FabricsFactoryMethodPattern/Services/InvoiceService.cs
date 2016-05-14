using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricsFactoryMethodPattern.Services
{
    using Entities;

    public abstract class InvoiceService<T> : EntityService<T> where T : IEntity
    {
    }

    public class PurchaseInvoiceService : InvoiceService<PurchaseInvoice>
    {
        public PurchaseInvoiceService()
        {
        }
    }

    public class SalesInvoiceService : InvoiceService<SalesInvoice>
    {
        public SalesInvoiceService()
        {
        }
    }

}
