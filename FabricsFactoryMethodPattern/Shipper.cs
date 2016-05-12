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

        public void createShipper(Shipper document)
        {
            shipperCollection.createDocument(document);
        }

        public List<Shipper> getAllShipper()
        {
            return shipperCollection.selectAllDocument();
        }

        public Shipper getAShipper(ObjectId idShipper)
        {
            return shipperCollection.selectADocument(idShipper);
        }

        public Boolean deleteAShipper(ObjectId idShipper)
        {
            return shipperCollection.deleteADocument(idShipper);
        }

        public void UpdateAShipper(ObjectId idShipper, Shipper document)
        {
            shipperCollection.UpdateADocument(idShipper, document);

        }

    }
}
