using EntityLayer.Concrete;
using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IUserActivityService:IGenericService<UserActivity>
    {
        List<UserActivity> GetListWithEverything(int id);
    }
}
