using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Company
    {
        [Key]
        public int CompanyId { get; set; }

        public string CompanyName { get; set; }

        public string CompanyWebSite { get; set; }

        public string CompanyMail { get; set; }

        public string CompanyPassword { get; set; }

        //---------------------relations----------------

        public List<Query> Queries { get; set; }    

        public IEnumerable<CompanyActivity> CompanyActivities { get; set; }
    }
}
