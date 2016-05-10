using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;

namespace FabricsFactoryMethodPattern
{
    public abstract class Invoice
    {

    }

    public class ImportInvoice : Invoice
    {

    }

    public class SellerInvoice : Invoice
    {

    }
}
