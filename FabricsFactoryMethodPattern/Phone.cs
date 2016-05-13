using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;

namespace FabricsFactoryMethodPattern
{
    public abstract class Phone
    {
    }

    public abstract class CellPhone : Phone
    {
        public string CellPhoneNumber { get; set; }

    }

    public abstract class DeskPhone : Phone
    {
        public string DeskPhoneNumber { get; set; }
    }

    public class SupplierCellPhone : CellPhone
    {
        public ObjectId SupplierId { get; set; }
        private SupplierCellPhoneCollection supplierCellPhoneCollection;

        public SupplierCellPhone()
        {
            supplierCellPhoneCollection = new SupplierCellPhoneCollection();
        }

        public void CreateSupplierCellPhone(SupplierCellPhone document)
        {
            supplierCellPhoneCollection.CreateDocument(document);
        }

        public List<SupplierCellPhone> GetAllSupplierCellPhone()
        {
            return supplierCellPhoneCollection.SelectAllDocument();
        }

        public SupplierCellPhone GetASupplierCellPhone(ObjectId idSupplierCellPhone)
        {
            return supplierCellPhoneCollection.SelectADocument(idSupplierCellPhone);
        }

        public Boolean DeleteASupplierCellPhone(ObjectId idSupplierCellPhone)
        {
            return supplierCellPhoneCollection.DeleteADocument(idSupplierCellPhone);
        }

        public void UpdateASupplierCellPhone(ObjectId idSupplierCellPhone, SupplierCellPhone document)
        {
            supplierCellPhoneCollection.UpdateADocument(idSupplierCellPhone, document);

        }

    }

    public class SupplierDeskPhone
    {
        public ObjectId SupplierId { get; set; }
        private SupplierDeskPhoneCollection supplierDeskPhoneCollection;

        public SupplierDeskPhone()
        {
            supplierDeskPhoneCollection = new SupplierDeskPhoneCollection();
        }

        public void CreateSupplierDeskPhone(SupplierDeskPhone document)
        {
            supplierDeskPhoneCollection.CreateDocument(document);
        }

        public List<SupplierDeskPhone> GetAllSupplierDeskPhone()
        {
            return supplierDeskPhoneCollection.SelectAllDocument();
        }

        public SupplierDeskPhone GetASupplierDeskPhone(ObjectId idSupplierDeskPhone)
        {
            return supplierDeskPhoneCollection.SelectADocument(idSupplierDeskPhone);
        }

        public Boolean DeleteASupplierDeskPhone(ObjectId idSupplierDeskPhone)
        {
            return supplierDeskPhoneCollection.DeleteADocument(idSupplierDeskPhone);
        }

        public void UpdateASupplierDeskPhone(ObjectId idSupplierDeskPhone, SupplierDeskPhone document)
        {
            supplierDeskPhoneCollection.UpdateADocument(idSupplierDeskPhone, document);

        }

    }

    public class CustomerCellPhone
    {
        public ObjectId CustomerId { get; set; }
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

    public class CustomerDeskPhone
    {
        public ObjectId CustomerId { get; set; }
        private CustomerDeskPhoneCollection customerDeskPhoneCollection;

        public CustomerDeskPhone()
        {
            customerDeskPhoneCollection = new CustomerDeskPhoneCollection();
        }

        public void CreateCustomerDeskPhone(CustomerDeskPhone document)
        {
            customerDeskPhoneCollection.CreateDocument(document);
        }

        public List<CustomerDeskPhone> GetAllCustomerDeskPhone()
        {
            return customerDeskPhoneCollection.SelectAllDocument();
        }

        public CustomerDeskPhone GetACustomerDeskPhone(ObjectId idCustomerDeskPhone)
        {
            return customerDeskPhoneCollection.SelectADocument(idCustomerDeskPhone);
        }

        public Boolean DeleteACustomerDeskPhone(ObjectId idCustomerDeskPhone)
        {
            return customerDeskPhoneCollection.DeleteADocument(idCustomerDeskPhone);
        }

        public void UpdateACustomerDeskPhone(ObjectId idCustomerDeskPhone, CustomerDeskPhone document)
        {
            customerDeskPhoneCollection.UpdateADocument(idCustomerDeskPhone, document);
        }

    }
}
