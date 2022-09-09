using BusinessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System.Text.RegularExpressions;

namespace BusinessLayer.Concrete
{
    public class CompanyManager : IGenericService<Company>
    {
        ICompanyDal _companyDal;

        public CompanyManager(ICompanyDal companyDal)
        {
            _companyDal = companyDal;
        }
        public static bool IsAlphaNumeric(string inputAlphabet)
        {
            const string expression = @"^[A-Za-z0-9]+$";

            Regex regex = new Regex(expression);
            return regex.IsMatch(inputAlphabet);
        }// harf ve rakam içeriyorsa true döner
        public void AddT(Company t)
        {
            if (t.CompanyPassword.Length >= 8 && IsAlphaNumeric(t.CompanyPassword) == true)
            {
                _companyDal.Insert(t);
            }
        }

        public void DeleteT(Company t)
        {
            throw new NotImplementedException();
        }

        public Company GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Company> GetList()
        {
            throw new NotImplementedException();
        }

        public void UpdateT(Company t)
        {
            throw new NotImplementedException();
        }
    }
}
