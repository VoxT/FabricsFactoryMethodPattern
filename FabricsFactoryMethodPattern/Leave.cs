using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;

namespace FabricsFactoryMethodPattern
{
    public class Leave
    {
        private LeaveCollection leaveCollection;

        public Leave()
        {
            leaveCollection = new LeaveCollection();
        }

        public void createLeave(Leave document)
        {
            leaveCollection.createDocument(document);
        }

        public List<Leave> getAllLeave()
        {
            return leaveCollection.selectAllDocument();
        }

        public Leave getALeave(ObjectId idLeave)
        {
            return leaveCollection.selectADocument(idLeave);
        }

        public Boolean deleteALeave(ObjectId idLeave)
        {
            return leaveCollection.deleteADocument(idLeave);
        }

        public void UpdateALeave(ObjectId idLeave, Leave document)
        {
            leaveCollection.UpdateADocument(idLeave, document);

        }

    }
}
