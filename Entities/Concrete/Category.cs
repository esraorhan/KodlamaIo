using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Category : IEntity
    {
        public int categoryID { get; set; }
        public string categoryName { get; set; }
        public string description { get; set; }
    }
}
