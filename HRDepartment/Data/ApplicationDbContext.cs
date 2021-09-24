using HRDepartment.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace HRDepartment.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }


        public ApplicationDbContext() { }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<FutureEmployee> FutureEmployees { get; set; }
        public DbSet<Technologies> Technologies { get; set; }
        public DbSet<ExperienceAndTechnologies> ExperiencesAndTechnologies { get; set; }
        public DbSet<FutureEmployeeTechnologies> FutureEmployeesTechnologies { get; set; }
        public DbSet<MultipleJobs> MultipleJobsPerEmployee { get; set; }
        public DbSet<Experience> Experiences { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=aspnet-HRDepartment-74D6F8CA-5AE4-474E-890D-1FC127205356;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Job>().HasData(new Job { JobId = 1, JobName = "Programmer", IsAvailable = true });
            modelBuilder.Entity<Job>().HasData(new Job { JobId = 2, JobName = "Tester", IsAvailable = true });
            modelBuilder.Entity<Job>().HasData(new Job { JobId = 3, JobName = "Web Developer", IsAvailable = true });
            modelBuilder.Entity<Job>().HasData(new Job { JobId = 4, JobName = "Data Scientist", IsAvailable = true });

        }
    }
}
