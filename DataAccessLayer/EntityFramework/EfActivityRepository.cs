using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfActivityRepository : GenericRepository<Activity>, IActivityDal
    {
        public List<Activity> GetListWithCategory()
        {
            using (var c = new Context())
            {
                return c.Activities.Include(x => x.Category).ToList();
            }
                
        }

        public List<Activity> GetListWithCategory2(int id)
        {
            using (var c = new Context())
            {
                return c.Activities.Include(x => x.Category).Where(x => x.ActivityId == id).ToList();
            }
        }
    }
}
