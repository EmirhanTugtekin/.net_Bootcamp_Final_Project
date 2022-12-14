using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IGenericService<T>
    {
        public void AddT(T t);
        public void DeleteT(T t);
        public void UpdateT(T t);
        public T GetById(int id);
        public List<T> GetList();
    }
}
