using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;

namespace FabricsFactoryMethodPattern
{
    public class FabricsColor
    {
        private FabricsColorCollection fabricColorCollection;

        public FabricsColor()
        {
            fabricColorCollection = new FabricsColorCollection();
        }

        public void CreateFabricColor(FabricsColor document)
        {
            fabricColorCollection.CreateDocument(document);
        }

        public List<FabricsColor> GetAllFabricColor()
        {
            return fabricColorCollection.SelectAllDocument();
        }

        public FabricsColor GetAFabricColor(ObjectId idFabricColor)
        {
            return fabricColorCollection.SelectADocument(idFabricColor);
        }

        public Boolean DeleteAFabricColor(ObjectId idFabricColor)
        {
            return fabricColorCollection.DeleteADocument(idFabricColor);
        }

        public void UpdateAFabricColor(ObjectId idFabricColor, FabricsColor document)
        {
            fabricColorCollection.UpdateADocument(idFabricColor, document);

        }

    }
}
