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

        public void AddCompanyActivity(CompanyActivity companyActivity)
        {
            throw new NotImplementedException();
        }

        public void AddCompanyToActivity(CompanyActivity companyActivity)
        {
            throw new NotImplementedException();
        }

        public List<CompanyActivity> GetList(int id)
        {
            return _companyActivityDal.GetListAll(x => x.ActivityId == id);
        }
    }
}
