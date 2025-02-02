﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICourseService
    {
        void Update(Course course);
        void Add(Course course);
        void Delete(Course course);
        List<Course> GetAll();
        Course GetById(int id);
    }
}
