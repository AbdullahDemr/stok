using DataAccessLayer.Abstract;
using EntitiyLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManeger : ICategoryDal
    {
        ICategoryDal _categoryDal;
        public CategoryManeger(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void Delete(Category t)
        {
           _categoryDal.Delete(t);
        }

        public Category GetById(int id)
        {
            return _categoryDal.GetById(id);    
        }

        public List<Category> GetList()
        {
            return new List<Category>();
        }

        public void Insert(Category t)
        {
            _categoryDal.Insert(t);
        }

        public void Update(Category t)
        {
           _categoryDal.Update(t);
        }
    }
}
