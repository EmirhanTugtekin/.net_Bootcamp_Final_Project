using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal; 
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public Category GetById (int id)
        {
            return _categoryDal.GetById(id);
        }

        public List<Category> GetList()
        {
            return _categoryDal.GetListAll();
        }
        //------------------------------------
        public void AddT(Category t)
        {
            _categoryDal.Insert(t);
            t.IsActive = true;
        }

        public void DeleteT(Category t)
        {
            t.IsActive = false;
        }

        public void UpdateT(Category t)
        {
            _categoryDal.Update(t);
        }
        
    }
}
