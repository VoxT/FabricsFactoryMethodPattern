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
        public ObjectId EmployeeId { get; set; }
        public DateTime Date { get; set; }

        private LeaveCollection leaveCollection;

        public Leave()
        {
            leaveCollection = new LeaveCollection();
        }

        public void CreateLeave(Leave document)
        {
            leaveCollection.CreateDocument(document);
        }

        public List<Leave> GetAllLeave()
        {
            return leaveCollection.SelectAllDocument();
        }

        public Leave GetALeave(ObjectId idLeave)
        {
            return leaveCollection.SelectADocument(idLeave);
        }

        public Boolean DeleteALeave(ObjectId idLeave)
        {
            return leaveCollection.DeleteADocument(idLeave);
        }

        public void UpdateALeave(ObjectId idLeave, Leave document)
        {
            leaveCollection.UpdateADocument(idLeave, document);

        }

    }
}
