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

        public void createPayment(Payment document)
        {
            paymentCollection.createDocument(document);
        }

        public List<Payment> getAllPayment()
        {
            return paymentCollection.selectAllDocument();
        }

        public Payment getAPayment(ObjectId idPayment)
        {
            return paymentCollection.selectADocument(idPayment);
        }

        public Boolean deleteAPayment(ObjectId idPayment)
        {
            return paymentCollection.deleteADocument(idPayment);
        }

        public void UpdateAPayment(ObjectId idPayment, Payment document)
        {
            paymentCollection.UpdateADocument(idPayment, document);

        }
    }
}
