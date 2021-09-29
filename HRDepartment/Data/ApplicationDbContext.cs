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


            modelBuilder.Entity<Technologies>().HasData(new Technologies { TechnologiesId = 1, TechnologyName = "C#" });
            modelBuilder.Entity<Technologies>().HasData(new Technologies { TechnologiesId = 2, TechnologyName = "Java" });
            modelBuilder.Entity<Technologies>().HasData(new Technologies { TechnologiesId = 3, TechnologyName = "JavaScript" });
            modelBuilder.Entity<Technologies>().HasData(new Technologies { TechnologiesId = 4, TechnologyName = "ASP.Net Core" });
            modelBuilder.Entity<Technologies>().HasData(new Technologies { TechnologiesId = 5, TechnologyName = "WPF" });
            modelBuilder.Entity<Technologies>().HasData(new Technologies { TechnologiesId = 6, TechnologyName = "Angular" });
            modelBuilder.Entity<Technologies>().HasData(new Technologies { TechnologiesId = 7, TechnologyName = "SQL" });
            modelBuilder.Entity<Technologies>().HasData(new Technologies { TechnologiesId = 8, TechnologyName = "Automation" });
            modelBuilder.Entity<Technologies>().HasData(new Technologies { TechnologiesId = 9, TechnologyName = "C++" });
            modelBuilder.Entity<Technologies>().HasData(new Technologies { TechnologiesId = 10, TechnologyName = "Artificial Intelligence" });
            modelBuilder.Entity<Technologies>().HasData(new Technologies { TechnologiesId = 11, TechnologyName = "Statistics" });


            modelBuilder.Entity<Experience>().HasData(new Experience { ExperienceId = 1, YearsOfExperience = "0-2 years" });
            modelBuilder.Entity<Experience>().HasData(new Experience { ExperienceId = 2, YearsOfExperience = "2-5 years" });
            modelBuilder.Entity<Experience>().HasData(new Experience { ExperienceId = 3, YearsOfExperience = "5-8 years" });
            modelBuilder.Entity<Experience>().HasData(new Experience { ExperienceId = 4, YearsOfExperience = "8+ years" });

            modelBuilder.Entity<ExperienceAndTechnologies>().HasData(new ExperienceAndTechnologies { Id = 1, ExperienceId = 1, JobId = 1, TechnologiesId = 1 });
            modelBuilder.Entity<ExperienceAndTechnologies>().HasData(new ExperienceAndTechnologies { Id = 2, ExperienceId = 2, JobId = 1, TechnologiesId = 2 });
            modelBuilder.Entity<ExperienceAndTechnologies>().HasData(new ExperienceAndTechnologies { Id = 3, ExperienceId = 3, JobId = 1, TechnologiesId = 9 });
            modelBuilder.Entity<ExperienceAndTechnologies>().HasData(new ExperienceAndTechnologies { Id = 4, ExperienceId = 4, JobId = 1, TechnologiesId = 5 });
            modelBuilder.Entity<ExperienceAndTechnologies>().HasData(new ExperienceAndTechnologies { Id = 5, ExperienceId = 5, JobId = 1, TechnologiesId = 4 });
            modelBuilder.Entity<ExperienceAndTechnologies>().HasData(new ExperienceAndTechnologies { Id = 6, ExperienceId = 6, JobId = 2, TechnologiesId = 1 });
            modelBuilder.Entity<ExperienceAndTechnologies>().HasData(new ExperienceAndTechnologies { Id = 7, ExperienceId = 7, JobId = 2, TechnologiesId = 8 });
            modelBuilder.Entity<ExperienceAndTechnologies>().HasData(new ExperienceAndTechnologies { Id = 8, ExperienceId = 8, JobId = 2, TechnologiesId = 3 });
            modelBuilder.Entity<ExperienceAndTechnologies>().HasData(new ExperienceAndTechnologies { Id = 9, ExperienceId = 9, JobId = 2, TechnologiesId = 7 });
            modelBuilder.Entity<ExperienceAndTechnologies>().HasData(new ExperienceAndTechnologies { Id = 10, ExperienceId = 10, JobId = 3, TechnologiesId = 1 });
            modelBuilder.Entity<ExperienceAndTechnologies>().HasData(new ExperienceAndTechnologies { Id = 11, ExperienceId = 11, JobId = 3, TechnologiesId = 3 });
            modelBuilder.Entity<ExperienceAndTechnologies>().HasData(new ExperienceAndTechnologies { Id = 12, ExperienceId = 12, JobId = 3, TechnologiesId = 4 });
            modelBuilder.Entity<ExperienceAndTechnologies>().HasData(new ExperienceAndTechnologies { Id = 13, ExperienceId = 13, JobId = 3, TechnologiesId = 6 });
            modelBuilder.Entity<ExperienceAndTechnologies>().HasData(new ExperienceAndTechnologies { Id = 14, ExperienceId = 14, JobId = 3, TechnologiesId = 7 });
            modelBuilder.Entity<ExperienceAndTechnologies>().HasData(new ExperienceAndTechnologies { Id = 15, ExperienceId = 15, JobId = 4, TechnologiesId = 9 });
            modelBuilder.Entity<ExperienceAndTechnologies>().HasData(new ExperienceAndTechnologies { Id = 16, ExperienceId = 16, JobId = 4, TechnologiesId = 10 });
            modelBuilder.Entity<ExperienceAndTechnologies>().HasData(new ExperienceAndTechnologies { Id = 17, ExperienceId = 17, JobId = 4, TechnologiesId = 11 });


        }
    }
}
