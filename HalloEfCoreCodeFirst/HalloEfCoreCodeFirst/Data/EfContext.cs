using HalloEfCoreCodeFirst.Model;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace HalloEfCoreCodeFirst.Data
{
    public class EfContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }
        public DbSet<Mitarbeiter> Mitarbeiter { get; set; }
        public DbSet<Abteilung> Abteilungen { get; set; }
        public DbSet<Kunde> Kunden { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var conString = "Server=(localdb)\\mssqllocaldb;Database=HalloEfCore;Trusted_Connection=true;TrustServerCertificate=true;";
            optionsBuilder.UseSqlServer(conString).UseLazyLoadingProxies().LogTo(x => Debug.WriteLine(x));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>().UseTptMappingStrategy();

            modelBuilder.Entity<Person>().Property(x => x.Name)
                .HasColumnName("DerName")
                .HasMaxLength(99);


        }

    }
}
