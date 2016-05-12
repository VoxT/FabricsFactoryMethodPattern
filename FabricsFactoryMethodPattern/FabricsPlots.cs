using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;

namespace FabricsFactoryMethodPattern
{
    public class FabricsPlots
    {
        private FabricsPlotsCollection plotsCollection;

        public FabricsPlots()
        {
            plotsCollection = new FabricsPlotsCollection();
        }

        public void CreatePlots(FabricsPlots document)
        {
            plotsCollection.CreateDocument(document);
        }

        public List<FabricsPlots> GetAllPlots()
        {
            return plotsCollection.SelectAllDocument();
        }

        public FabricsPlots GetAPlots(ObjectId idPlots)
        {
            return plotsCollection.SelectADocument(idPlots);
        }

        public Boolean DeleteAPlots(ObjectId idPlots)
        {
            return plotsCollection.DeleteADocument(idPlots);
        }

        public void UpdateAPlots(ObjectId idPlots, FabricsPlots document)
        {
            plotsCollection.UpdateADocument(idPlots, document);

        }

    }
}
