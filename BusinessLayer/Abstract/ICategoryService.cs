using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICategoryService
    {
        public void AddCategory(Category category);
        public void DeleteCategory(Category category);
        public void UpdateCategory(Category category);
        public Category GetById(int id);
        public List<Category> GetList();
        
    }
}
