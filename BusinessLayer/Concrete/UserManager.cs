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

        public void AddUser(User user)
        {
            if (user.UserName != "" && user.UserSurname != "" && user.UserPassword.Length >= 8 && IsAlphaNumeric(user.UserPassword) == true)
            {
                _userDal.Insert(user);
                user.IsActive = true;
                //user.RoleId = 1;
            }
        }
        public static bool IsAlphaNumeric(string inputAlphabet)
        {
            const string expression = @"^[A-Za-z0-9]+$";

            Regex regex = new Regex(expression);
            return regex.IsMatch(inputAlphabet);
        }// harf ve rakam içeriyorsa true döner

        public void DeleteUser(User user)
        {
            user.IsActive = false;
        }

        public void UpdateUser(User user)
        {
            _userDal.Update(user);
        }

        public User GetById(int id)
        {
            return _userDal.GetById(id);
        }

        public List<User> GetList()
        {
            return _userDal.GetListAll();
        }
    }
}
