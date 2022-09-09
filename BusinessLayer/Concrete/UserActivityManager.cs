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
    public class UserActivityManager : IUserActivityService
    {
        IUserActivityDal _userActivityDal;

        public UserActivityManager(IUserActivityDal userActivityDal)
        {
            _userActivityDal = userActivityDal;
        }

        public void AddT(UserActivity t)
        {
            throw new NotImplementedException();
        }

        public void DeleteT(UserActivity t)
        {
            throw new NotImplementedException();
        }

        public UserActivity GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<UserActivity> GetList()
        {
            return _userActivityDal.GetListAll();
        }

        public List<UserActivity> GetListWithEverything(int id)
        {
            return _userActivityDal.GetListWithEverything(id);
        }

        public void UpdateT(UserActivity t)
        {
            throw new NotImplementedException();
        }
    }
}
