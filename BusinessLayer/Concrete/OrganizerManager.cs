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
    public class OrganizerManager : IGenericService<Organizer>
    {
        IOrganizerDal _organizerDal;

        public OrganizerManager(IOrganizerDal organizerDal)
        {
            _organizerDal = organizerDal;
        }
        public static bool IsAlphaNumeric(string inputAlphabet)
        {
            const string expression = @"^[A-Za-z0-9]+$";

            Regex regex = new Regex(expression);
            return regex.IsMatch(inputAlphabet);
        }// harf ve rakam içeriyorsa true döner

        public void AddT(Organizer t)
        {
            if (t.OrganizerPassword.Length >= 8 && IsAlphaNumeric(t.OrganizerPassword) == true)
            {
                _organizerDal.Insert(t);
                t.IsActive = true;
            }
        }

        public void DeleteT(Organizer t)
        {
            throw new NotImplementedException();
        }

        public Organizer GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Organizer> GetList()
        {
            throw new NotImplementedException();
        }

        public void UpdateT(Organizer t)
        {
            throw new NotImplementedException();
        }
    }
}
