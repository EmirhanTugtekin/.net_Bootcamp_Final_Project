using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class CompanyActivity
    {
        [Key]
        public int CompanyActivityId { get; set; }

        public int CompanyId { get; set; }
        public Company Company { get; set; }

        public int ActivityId { get; set; }
        public Activity Activity { get; set; }
    }
}
