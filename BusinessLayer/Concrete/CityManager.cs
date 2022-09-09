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
	public class CityManager : ICityService
	{
		ICityDal _cityDal;
		public CityManager(ICityDal cityDal)
		{
			_cityDal = cityDal;
		}
		public void AddT(City t)
		{
			throw new NotImplementedException();
		}

		public void DeleteT(City t)
		{
			throw new NotImplementedException();
		}

		public City GetById(int id)
		{
			throw new NotImplementedException();
		}

		public List<City> GetList()
		{
            return _cityDal.GetListAll();
        }

		public void UpdateT(City t)
		{
			throw new NotImplementedException();
		}
	}
}
