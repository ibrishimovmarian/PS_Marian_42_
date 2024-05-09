
/*using DataLayer.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Welcome.Others;

namespace DataLayer.Database
{

    public class DataBaseContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            string solutionFolder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string databaseFile = "Welcome.db";
            string databasePath = Path.Combine(solutionFolder, databaseFile);
            optionsBuilder.UseSqlite($"Data Source= {databasePath}");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<DatabaseUser>().Property(e => e.ID).ValueGeneratedOnAdd();

            var user = new DatabaseUser()
            {
                ID = 1,
                Name = "qwe qwe",
                Password = "1234",
                Role = UserRolesEnum.ADMIN,
                Expires = DateTime.Now.AddYears(10)
            };
            var user2 = new DatabaseUser()
            {
                ID = 2,
                Name = "asd asd",
                Password = "321",
                Role = UserRolesEnum.STUDENT,
                Expires = DateTime.Now.AddYears(100)
            };
            modelBuilder.Entity<DatabaseUser>().HasData(user);
            modelBuilder.Entity<DatabaseUser>().HasData(user2);
        }
        //public DbSet<DatabaseUser> Users { get; set; }
    }
}
*/
using DataLayer.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Logging.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Welcome.Model;

namespace DataLayer.Database
{
    public class DatabaseContext : DbContext
    {
        public DbSet<DatabaseUser> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=users.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var user = new DatabaseUser()
            {
                ID = 1,
                Name = "John Doe",
                Password = "1234",
                Role = Welcome.Others.UserRolesEnum.ADMIN,
                Email = "jDoe@tu-sofia.bg",
                Expires = DateTime.Now.AddYears(10),
                IsActive = true,
                FacultiNumber = "12345"
            };

            var user2 = new DatabaseUser()
            {
                ID = 2,
                Name = "Ivan Petrov",
                Password = "1234",
                Role = Welcome.Others.UserRolesEnum.STUDENT,
                Email = "iPetrov@tu-sofia",
                Expires = DateTime.Now.AddYears(10),
                IsActive = true,
                FacultiNumber = "12345"
            };

            var user3 = new DatabaseUser()
            {
                ID = 3,
                Name = "Petar Stoqnov",
                Password = "1234",
                Role = Welcome.Others.UserRolesEnum.PROFESSOR,
                Email = "pStoqnov",
                Expires = DateTime.Now.AddYears(10),
                IsActive = true,
                FacultiNumber = "12345"
            };

            modelBuilder.Entity<DatabaseUser>().HasData(user);
            modelBuilder.Entity<DatabaseUser>().HasData(user2);
            modelBuilder.Entity<DatabaseUser>().HasData(user3);
        }
    }
}