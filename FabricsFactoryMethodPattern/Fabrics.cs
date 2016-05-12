using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;

namespace FabricsFactoryMethodPattern
{
    public class Fabrics
    {
        private FabricsCollection fabricsCollection;

        public Fabrics()
        {
            fabricsCollection = new FabricsCollection();
        }

        public void CreateFabrics(Fabrics document)
        {
            fabricsCollection.CreateDocument(document);
        }

        public List<Fabrics> GetAllFabrics()
        {
            return fabricsCollection.SelectAllDocument();
        }

        public Fabrics GetAFabrics(ObjectId idFabrics)
        {
            return fabricsCollection.SelectADocument(idFabrics);
        }

        public Boolean DeleteAFabrics(ObjectId idFabrics)
        {
            return fabricsCollection.DeleteADocument(idFabrics);
        }

        public void UpdateAFabrics(ObjectId idFabrics, Fabrics document)
        {
            fabricsCollection.UpdateADocument(idFabrics, document);

        }
    }
}
