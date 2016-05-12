using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;

namespace FabricsFactoryMethodPattern
{
    public class CustomerCellPhone
    {
        private CustomerCellPhoneCollection customerCellPhoneCollection;

        public CustomerCellPhone()
        {
            customerCellPhoneCollection = new CustomerCellPhoneCollection();
        }

        public void createCustomerCellPhone(CustomerCellPhone document)
        {
            customerCellPhoneCollection.createDocument(document);
        }

        public List<CustomerCellPhone> getAllCustomerCellPhone()
        {
            return customerCellPhoneCollection.selectAllDocument();
        }

        public CustomerCellPhone getACustomerCellPhone(ObjectId idCustomerCellPhone)
        {
            return customerCellPhoneCollection.selectADocument(idCustomerCellPhone);
        }

        public Boolean deleteACustomerCellPhone(ObjectId idCustomerCellPhone)
        {
            return customerCellPhoneCollection.deleteADocument(idCustomerCellPhone);
        }

        public void UpdateACustomerCellPhone(ObjectId idCustomerCellPhone, CustomerCellPhone document)
        {
            customerCellPhoneCollection.UpdateADocument(idCustomerCellPhone, document);

        }

    }
}
