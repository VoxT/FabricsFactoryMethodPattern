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

        public void createPlots(FabricsPlots document)
        {
            plotsCollection.createDocument(document);
        }

        public List<FabricsPlots> getAllPlots()
        {
            return plotsCollection.selectAllDocument();
        }

        public FabricsPlots getAPlots(ObjectId idPlots)
        {
            return plotsCollection.selectADocument(idPlots);
        }

        public Boolean deleteAPlots(ObjectId idPlots)
        {
            return plotsCollection.deleteADocument(idPlots);
        }

        public void UpdateAPlots(ObjectId idPlots, FabricsPlots document)
        {
            plotsCollection.UpdateADocument(idPlots, document);

        }

    }
}
