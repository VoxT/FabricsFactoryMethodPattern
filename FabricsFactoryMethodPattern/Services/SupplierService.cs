using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;

namespace FabricsFactoryMethodPattern.Services
{
    using Entities;
    public class SupplierService : BusinesspersonService<Supplier>
    {
        public SupplierService()
        {
        }

        public double GetDebt(string id)
        {   
            // debt
            double debt = 0;
            
            //get list invoice of this supplier
            PurchaseInvoiceService purchaseInvoiceService = new PurchaseInvoiceService();
            var listInvoice = purchaseInvoiceService.GetInvoiceForSupplier(id);

            // get list payment of this invoice
            PaymentService paymentService = new PaymentService();
            var listPayment = paymentService.GetPaymentForSupplier(id);

            // get debt
            foreach (var invoice in listInvoice)
            {
                debt += purchaseInvoiceService.GetTotalMoney(invoice);    
            }

            foreach (var payment in listPayment)
            {
                debt -= payment.Money;
            }

            // return debt
            return debt;
        }
    }
}
