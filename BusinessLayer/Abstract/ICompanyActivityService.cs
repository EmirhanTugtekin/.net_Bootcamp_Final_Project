using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICompanyActivityService
    {
        void AddCompanyActivity(CompanyActivity companyActivity);
        void AddCompanyToActivity(CompanyActivity companyActivity);
        List<CompanyActivity> GetList(int id);
    }
}
