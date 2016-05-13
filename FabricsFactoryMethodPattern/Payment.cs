using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;

namespace FabricsFactoryMethodPattern
{
    public class Payment
    {
        public ObjectId Id { get; private set; }
        public Database Time { get; set; }
        public double Money { get; set; }
        public string PaymentMethod { get; set; }
        public string RecipientOrSender { get; set; }
        public string BankName { get; set; }
        public string AccountNumber { get; set; }
        public string Method { get; set; }
        public ObjectId EmployeeId { get; set; }
        public ObjectId CustomerId { get; set; }
        public ObjectId SupplierId { get; set; }


        private PaymentCollection paymentCollection;

        public Payment()
        {
            paymentCollection = new PaymentCollection();
        }

        public void CreatePayment(Payment document)
        {
            paymentCollection.CreateDocument(document);
        }

        public List<Payment> GetAllPayment()
        {
            return paymentCollection.SelectAllDocument();
        }

        public Payment GetAPayment(ObjectId idPayment)
        {
            return paymentCollection.SelectADocument(idPayment);
        }

        public Boolean DeleteAPayment(ObjectId idPayment)
        {
            return paymentCollection.DeleteADocument(idPayment);
        }

        public void UpdateAPayment(ObjectId idPayment, Payment document)
        {
            paymentCollection.UpdateADocument(idPayment, document);

        }
    }
}
