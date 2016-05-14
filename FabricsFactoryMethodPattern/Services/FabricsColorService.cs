using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricsFactoryMethodPattern.Services
{
    using Entities;
    public class FabricsColorService : EntityService<FabricsColor>
    {
        public FabricsColorService()
        {
        }
    }
}
