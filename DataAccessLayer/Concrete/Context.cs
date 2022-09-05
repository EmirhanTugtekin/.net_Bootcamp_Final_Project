using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete;
using System.ComponentModel.DataAnnotations;

namespace DataAccessLayer.Concrete
{
    public class Context : DbContext
    {
        protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-6TUVH6H; database=DbTechcareerProject; integrated security=true;");
        }// bağlantı adresini verdim

        public DbSet<Activity> Activities { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<CompanyActivity> CompanyActivities { get; set; }
        public DbSet<Organizer> Organizers { get; set; }
        public DbSet<Query> Queries { get; set; } 
        public DbSet<User> Users { get; set; }
        public DbSet<UserActivity> UserActivities { get; set; }

    }

   
}
