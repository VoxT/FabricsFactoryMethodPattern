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
            invoice = CreateInvoice();
        }

        public Invoice invoice { get; set; }

        public abstract Invoice CreateInvoice();

        public void DisplayWhoCreateInvoice()
        {
            Console.WriteLine(invoice.GetType().ToString());
        }

    }

    public class Importer : Employee
    {
        private Supplier supplier;

        public override Invoice CreateInvoice()
        {
            return new PurchaseInvoice();
        }

        public Supplier GetSupplierService()
        {
            supplier = new Supplier();

            return supplier;
        }

    }

    public class Seller : Employee
    {
        private Customer customer;

        public override Invoice CreateInvoice()
        {
            return new SalesInvoice();
        }

        public Customer GetCustomerService()
        {
            customer = new Customer();

            return customer;
        }
    }
}
