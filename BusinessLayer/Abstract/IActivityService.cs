using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
	public interface IActivityService
	{
        public void AddActivity(Activity activity);
        public void DeleteActivity(Activity activity);
        public void UpdateActivity(Activity activity);
        public Activity GetById(int id);
        public List<Activity> GetList();
        List<Activity> GetListWithCategory();
        List<Activity> GetListWithOrganizer();
	}
}
