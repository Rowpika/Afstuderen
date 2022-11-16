using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Afstuderen.Domain
{
    public class AfstudeerContext : DbContext
    {
        public DbSet<Student> Studenten { get; set; }
        public DbSet<Opdracht> Opdrachten { get; set; }
        public DbSet<Begeleider> Begeleiders { get; set; }
        public DbSet<Bedrijf> Bedrijven { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=AfstudeerDB;Trusted_Connection=True;TrustServerCertificate=True");
        }
    }
}
