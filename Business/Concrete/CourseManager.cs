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
    public class CourseManager : ICourseService
    {
        private ICourseDal _courseDal;

        public CourseManager(ICourseDal courseDal)
        {
            _courseDal = courseDal;
        }

        public void Add(Course course)
        {
            _courseDal.ADD(course);
        }

        public void Delete(Course course)
        {
            _courseDal.DELETE(course);
        }

        public List<Course> GetAll()
        {
            return _courseDal.GETLIST();
        }

        public Course GetById(int id)
        {
            return _courseDal.GET(c => c.courseID == id);
        }

        public void Update(Course course)
        {
            _courseDal.UPDATE(course);
        }
    }
}
