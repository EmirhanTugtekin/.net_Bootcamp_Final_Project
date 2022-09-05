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
	public class ActivityManager : IActivityService
	{
        IActivityDal _activityDal; //bunun yerine EfActivityRepository'yi kullansaydık Dependency Injection yapmamış ve bağımlı bir yapı oluşturmuş olurduk
        public ActivityManager(IActivityDal activityDal)
        {
            _activityDal = activityDal;
        }

        public void AddActivity(Activity activity)
        {
            if (activity.ActivityName != "")
            {
                _activityDal.Insert(activity);
                activity.IsActive = true;
            }
        }

        public void DeleteActivity(Activity activity)
        {
            activity.IsActive = false;
        }

        public void UpdateActivity(Activity activity)
        {
            _activityDal.Update(activity);
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
    }
}
