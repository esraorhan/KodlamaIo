using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Course:IEntity
    {
        public int courseID { get; set; }
        public int categoryID { get; set; }
        public int instructorId { get; set; }
        public string courseName { get; set; }
        public string courseDescription { get; set; }
        public DateTime creationDate { get; set; }
        public double price { get; set; }
        public string courseImage { get; set; }
        public bool status { get; set; }
    }
}
