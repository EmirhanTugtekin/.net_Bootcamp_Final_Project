using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;
        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public static bool IsAlphaNumeric(string inputAlphabet)
        {
            const string expression = @"^[A-Za-z0-9]+$";

            Regex regex = new Regex(expression);
            return regex.IsMatch(inputAlphabet);
        }// harf ve rakam içeriyorsa true döner

        public User GetById(int id)
        {
            return _userDal.GetById(id);
        }

        public List<User> GetList()
        {
            return _userDal.GetListAll();
        }

        public void AddT(User t)
        {
            if (t.UserPassword.Length >= 8 && IsAlphaNumeric(t.UserPassword) == true)
            {
                _userDal.Insert(t);
                t.IsActive = true;
            }
            
        }

        public void DeleteT(User t)
        {
            t.IsActive = false;
        }

        public void UpdateT(User t)
        {
            _userDal.Update(t);
        }
    }
}
