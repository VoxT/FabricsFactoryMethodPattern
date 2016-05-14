using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace FabricsFactoryMethodPattern.Entities
{
    public abstract class Employee : Person
    {
        public string BirthDate { get; set; }
        public string IdentityCardNumber { get; set; }
        public int Salary { get; set; }
        public DateTime Date { get; set; }
        public string Degree { get; set; }
        public Shipper Shipper { get; set; }
        public List<Leave> Leave { get; set; }

        public Employee()
        {
            invoice = CreateInvoice();
            Leave = new List<Leave>();
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
