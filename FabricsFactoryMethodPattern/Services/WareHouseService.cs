using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricsFactoryMethodPattern.Services
{
    using Entities;
    public class WareHouseService : EntityService<WareHouse>
    {
        public WareHouseService()
        {
        }

        public List<FabricsRoll> GetFabricsRoll(string id)
        {
            var invoiceService = new PurchaseInvoiceService();
            var listInvoice = invoiceService.GetInvoiceForWareHouse(id);

            List<FabricsRoll> listFabricsRoll = new List<FabricsRoll>();;

            foreach (var invoice in listInvoice)
            {
                listFabricsRoll.Concat(invoiceService.GetFabricsRoll(invoice.Id.ToString()));
            }

            return listFabricsRoll.ToList();
        }



    }
}
