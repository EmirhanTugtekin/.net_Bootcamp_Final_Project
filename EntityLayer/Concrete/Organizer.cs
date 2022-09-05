using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Organizer
    {
        [Key]
        public int OrganizerId { get; set; }

        public string OrganizerName { get; set; }

        public string OrganizerSurname { get; set; }

        public string OrganizerMail { get; set; }

        public string OrganizerPassword { get; set; }

        public bool IsActive { get; set; }
        //public bool IsActive2 { get; set; }

        //----------relations--------------
        public List<Activity> Activities { get; set; }


       
    }
}
