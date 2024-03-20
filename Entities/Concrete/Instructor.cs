using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Instructor :IEntity
    {
        public int instructorId { get; set; }
        public string fullName { get; set; }
        public List<Course> Courses { get; set; }
    }
}
