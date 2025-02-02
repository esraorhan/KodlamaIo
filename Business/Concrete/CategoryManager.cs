﻿using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void Add(Category category)
        {
            _categoryDal.ADD(category);
        }

        public void Delete(Category category)
        {
            _categoryDal.DELETE(category);
        }

        public List<Category> GetAll()
        {
          return  _categoryDal.GETLIST().ToList();
        }

        public Category GetById(int id)
        {
           return _categoryDal.GET(c => c.categoryID == id);
        }

        public void Update(Category category)
        {
            _categoryDal.UPDATE(category);
        }
    }
}
