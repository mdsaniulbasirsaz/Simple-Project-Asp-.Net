using Microsoft.EntityFrameworkCore;
using PatientManagementApp.Models;

namespace PatientManagementApp.Data
{
    public class HospitalDbContext : DbContext
    {
        public HospitalDbContext(DbContextOptions<HospitalDbContext> options) : base(options)
        {
        }

        public DbSet<Patients> Patients { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Patients>()
                .HasKey(p => p.PatientId);  

            modelBuilder.Entity<Patients>()
                .ToTable("Patinets");  
        }
    }
}
