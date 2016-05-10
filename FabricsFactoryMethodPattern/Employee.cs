using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;

namespace FabricsFactoryMethodPattern
{
    public abstract class Employee
    {
        public Employee()
        {
            invoice = createInvoice();
        }

        public Invoice invoice { get; set; }

        public abstract Invoice createInvoice();

        public void displayWhoCreateInvoice()
        {
            Console.WriteLine(invoice.GetType().ToString());
        }

    }

    public class Importer : Employee
    {
        public override Invoice createInvoice()
        {
            return new ImportInvoice();
        }
    }

    public class Seller : Employee
    {
        private Customer customer;
        public override Invoice createInvoice()
        {
            return new SellerInvoice();
        }

        public void createCustomer(BsonDocument document)
        {
            customer.createCustomer(document);
        }
    }
}
