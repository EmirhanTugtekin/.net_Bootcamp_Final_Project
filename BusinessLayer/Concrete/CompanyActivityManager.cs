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
    public class CompanyActivityManager : ICompanyActivityService
    {
        ICompanyActivityDal _companyActivityDal;
        
        public CompanyActivityManager(ICompanyActivityDal companyActivityDal)
        {
            _companyActivityDal = companyActivityDal;
        }

        public void AddCompanyToActivity(CompanyActivity companyActivity)
        {
            throw new NotImplementedException();
        }

        public void AddT(CompanyActivity t)
        {
            throw new NotImplementedException();
        }

        public void DeleteT(CompanyActivity t)
        {
            throw new NotImplementedException();
        }

        public CompanyActivity GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<CompanyActivity> GetListWithEverything(int id)
        {
            return _companyActivityDal.GetListWithEverything(id);
        }

        public List<CompanyActivity> GetList()
        {
            throw new NotImplementedException();
        }

        public void UpdateT(CompanyActivity t)
        {
            throw new NotImplementedException();
        }
    }
}
