using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Activity = EntityLayer.Concrete.Activity;

namespace BusinessLayer.Concrete
{
	public class ActivityManager : IActivityService
	{
        IActivityDal _activityDal; //bunun yerine EfActivityRepository'yi kullansaydık Dependency Injection yapmamış ve bağımlı bir yapı oluşturmuş olurduk
        public ActivityManager(IActivityDal activityDal)
        {
            _activityDal = activityDal;
        }

        public Activity GetById(int id)
        {
            return _activityDal.GetById(id);
        }

        public List<Activity> GetActivityById(int id)
        {
            return _activityDal.GetListAll(x => x.ActivityId == id);
        }

        public List<Activity> GetList()
        {
            return _activityDal.GetListAll();
        }

        public List<Activity> GetListWithCategory()
        {
            throw new NotImplementedException();
        }

        public List<Activity> GetListWithOrganizer()
        {
            throw new NotImplementedException();
        }

        public void AddT(Activity t)
        {
            _activityDal.Insert(t);
            t.IsActive = true;
        }

        public void DeleteT(Activity t)
        {
            t.IsActive = false;
        }

        public void UpdateT(Activity t)
        {
            _activityDal.Update(t);
        }
    }
}
