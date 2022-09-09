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
    public class EfUserActivityRepository:GenericRepository<UserActivity>, IUserActivityDal
    {
        public List<UserActivity> GetListWithEverything(int id)
        {
            using (var c = new Context())
            {
                return c.UserActivities.Include(x => x.User).Include(x => x.Activity).Where(x => x.UserId == id).ToList();
            }
        }
    }
}
