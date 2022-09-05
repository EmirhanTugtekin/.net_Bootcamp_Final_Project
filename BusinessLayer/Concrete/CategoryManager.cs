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
        ICategoryDal _categoryDal; //bunun yerine EfCategoryRepository'yi kullansaydık Dependency Injection yapmamış ve bağımlı bir yapı oluşturmuş olurduk
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void AddCategory(Category category)
        {
            if (category.CategoryName != "")
            {
                _categoryDal.Insert(category);
                category.IsActive = true;
            }
        }

        public void DeleteCategory(Category category)
        {
            category.IsActive = false;
        }

        public void UpdateCategory(Category category)
        {
            _categoryDal.Update(category);
        }

        public Category GetById (int id)
        {
            return _categoryDal.GetById(id);
        }

        public List<Category> GetList()
        {
            return _categoryDal.GetListAll();
        }
    }
}
