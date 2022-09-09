using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICompanyActivityService:IGenericService<CompanyActivity>
    {
        void AddCompanyToActivity(CompanyActivity companyActivity);
        List<CompanyActivity> GetListWithEverything(int id);
        
    }
}
