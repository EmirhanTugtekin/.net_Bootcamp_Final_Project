using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Activity
    {
        [Key]
        public int ActivityId { get; set; }

        public string ActivityName { get; set; }

        public DateTime Date { get; set; }

        public string Explanation { get; set; }

        public string Address { get; set; }

        public int Quota { get; set; } //kontenjan

        public bool IsItTicketed { get; set; }

        public decimal? Price { get; set; }

        public bool IsActive { get; set; }

        //------------------Relations-----------------

        [ForeignKey("City")]
        public int CityId { get; set; }
        public City City { get; set; }


        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        

        [ForeignKey("Organizer")]
        public int OrganizerId { get; set; }
        public Organizer Organizer { get; set; }


        public IEnumerable<CompanyActivity> CompanyActivities { get; set; }
        public IEnumerable<UserActivity> UserActivities { get; set; }
    }
}
