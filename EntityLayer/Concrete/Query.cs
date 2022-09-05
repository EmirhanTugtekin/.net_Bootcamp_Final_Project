using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Query
    {
        [Key]
        public int QueryId { get; set; }

        public DateTime QueryDate { get; set; }

        public bool IsActive { get; set; }

        //-----------------relations----------------

        public int CompanyId { get; set; }
        public Company Company { get; set; }
    }
}
