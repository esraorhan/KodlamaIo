﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
   public  interface IInstructorService
    {
        void Update(Instructor instructor);
        void Add(Instructor instructor);
        void Delete(Instructor instructor);
        List<Instructor> GetAll();
        Instructor GetById(int id);
    }
}
