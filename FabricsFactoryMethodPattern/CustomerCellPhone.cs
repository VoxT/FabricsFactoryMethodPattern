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

        public void CreateCustomerCellPhone(CustomerCellPhone document)
        {
            customerCellPhoneCollection.CreateDocument(document);
        }

        public List<CustomerCellPhone> GetAllCustomerCellPhone()
        {
            return customerCellPhoneCollection.SelectAllDocument();
        }

        public CustomerCellPhone GetACustomerCellPhone(ObjectId idCustomerCellPhone)
        {
            return customerCellPhoneCollection.SelectADocument(idCustomerCellPhone);
        }

        public Boolean DeleteACustomerCellPhone(ObjectId idCustomerCellPhone)
        {
            return customerCellPhoneCollection.DeleteADocument(idCustomerCellPhone);
        }

        public void UpdateACustomerCellPhone(ObjectId idCustomerCellPhone, CustomerCellPhone document)
        {
            customerCellPhoneCollection.UpdateADocument(idCustomerCellPhone, document);

        }

    }
}
