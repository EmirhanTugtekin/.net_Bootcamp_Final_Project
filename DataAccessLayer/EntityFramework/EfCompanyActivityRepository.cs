using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfCompanyActivityRepository : GenericRepository<CompanyActivity>, ICompanyActivityDal
    {
        public List<CompanyActivity> GetListWithEverything(int id)
        {
            using (var c = new Context())
            {
                return c.CompanyActivities.Include(x => x.Company).Include(x => x.Activity).Where(x => x.ActivityId == id).ToList();
            }
        }

        
    }
}
