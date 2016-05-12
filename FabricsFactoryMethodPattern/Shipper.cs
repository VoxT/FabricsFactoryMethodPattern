using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;

namespace FabricsFactoryMethodPattern
{
    public class Shipper
    {
        private ShipperCollection shipperCollection;

        public Shipper()
        {
            shipperCollection = new ShipperCollection();
        }

        public void CreateShipper(Shipper document)
        {
            shipperCollection.CreateDocument(document);
        }

        public List<Shipper> GetAllShipper()
        {
            return shipperCollection.SelectAllDocument();
        }

        public Shipper GetAShipper(ObjectId idShipper)
        {
            return shipperCollection.SelectADocument(idShipper);
        }

        public Boolean DeleteAShipper(ObjectId idShipper)
        {
            return shipperCollection.DeleteADocument(idShipper);
        }

        public void UpdateAShipper(ObjectId idShipper, Shipper document)
        {
            shipperCollection.UpdateADocument(idShipper, document);

        }

    }
}
