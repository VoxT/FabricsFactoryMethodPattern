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

        public void createFabrics(Fabrics document)
        {
            fabricsCollection.createDocument(document);
        }

        public List<Fabrics> getAllFabrics()
        {
            return fabricsCollection.selectAllDocument();
        }

        public Fabrics getAFabrics(ObjectId idFabrics)
        {
            return fabricsCollection.selectADocument(idFabrics);
        }

        public Boolean deleteAFabrics(ObjectId idFabrics)
        {
            return fabricsCollection.deleteADocument(idFabrics);
        }

        public void UpdateAFabrics(ObjectId idFabrics, Fabrics document)
        {
            fabricsCollection.UpdateADocument(idFabrics, document);

        }
    }
}
