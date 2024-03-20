using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class InstructorManager : IInstructorService
    {
        private IInstructorDal _instructorDal;

        public InstructorManager(IInstructorDal instructorDal)
        {
            _instructorDal = instructorDal;
        }

        public void Add(Instructor instructor)
        {
            _instructorDal.ADD(instructor);
        }

        public void Delete(Instructor instructor)
        {
            _instructorDal.DELETE(instructor);
        }

        public List<Instructor> GetAll()
        {
            return _instructorDal.GETLIST();
        }

        public Instructor GetById(int id)
        {
            return _instructorDal.GET(c => c.instructorId == id);
        }

        public void Update(Instructor instructor)
        {
            _instructorDal.UPDATE(instructor);
        }
    }
}
