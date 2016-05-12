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
