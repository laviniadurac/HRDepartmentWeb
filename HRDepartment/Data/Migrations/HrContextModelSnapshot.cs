﻿/*// <auto-generated />
using HRDepartment.DAL;
using HRDepartment.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HRDepartment.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HRDepartment.Models.Experience", b =>
                {
                    b.Property<int>("ExperienceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("YearsOfExperience")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ExperienceId");

                    b.ToTable("Experiences");
                });

            modelBuilder.Entity("HRDepartment.Models.ExperienceAndTechnologies", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ExperienceId")
                        .HasColumnType("int");

                    b.Property<int>("JobId")
                        .HasColumnType("int");

                    b.Property<int>("TechnologiesId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ExperienceId");

                    b.HasIndex("JobId");

                    b.HasIndex("TechnologiesId");

                    b.ToTable("ExperiencesAndTechnologies");
                });

            modelBuilder.Entity("HRDepartment.Models.FutureEmployee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CV")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmployeeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Experience")
                        .HasColumnType("int");

                    b.Property<string>("OtherDetails")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PhoneNumber")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Technologies")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmployeeId");

                    b.ToTable("FutureEmployees");
                });

            modelBuilder.Entity("HRDepartment.Models.FutureEmployeeTechnologies", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<int>("TechnologiesId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("TechnologiesId");

                    b.ToTable("FutureEmployeesTechnologies");
                });

            modelBuilder.Entity("HRDepartment.Models.Job", b =>
                {
                    b.Property<int>("JobId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsAvailable")
                        .HasColumnType("bit");

                    b.Property<string>("JobName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("JobId");

                    b.ToTable("Jobs");

                    b.HasData(
                        new
                        {
                            JobId = 1,
                            IsAvailable = true,
                            JobName = "Programmer"
                        },
                        new
                        {
                            JobId = 2,
                            IsAvailable = true,
                            JobName = "Tester"
                        },
                        new
                        {
                            JobId = 3,
                            IsAvailable = true,
                            JobName = "Web Developer"
                        },
                        new
                        {
                            JobId = 4,
                            IsAvailable = true,
                            JobName = "Data Scientist"
                        });
                });

            modelBuilder.Entity("HRDepartment.Models.MultipleJobs", b =>
                {
                    b.Property<int>("MultipleJobsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<int>("JobId")
                        .HasColumnType("int");

                    b.HasKey("MultipleJobsId");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("JobId");

                    b.ToTable("MultipleJobsPerEmployee");
                });

            modelBuilder.Entity("HRDepartment.Models.Technologies", b =>
                {
                    b.Property<int>("TechnologiesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TechnologyName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TechnologiesId");

                    b.ToTable("Technologies");
                });

            modelBuilder.Entity("HRDepartment.Models.ExperienceAndTechnologies", b =>
                {
                    b.HasOne("HRDepartment.Models.Experience", "Experience")
                        .WithMany()
                        .HasForeignKey("ExperienceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HRDepartment.Models.Job", "Job")
                        .WithMany()
                        .HasForeignKey("JobId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HRDepartment.Models.Technologies", "Technologies")
                        .WithMany()
                        .HasForeignKey("TechnologiesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Experience");

                    b.Navigation("Job");

                    b.Navigation("Technologies");
                });

            modelBuilder.Entity("HRDepartment.Models.FutureEmployeeTechnologies", b =>
                {
                    b.HasOne("HRDepartment.Models.FutureEmployee", "FutureEmployee")
                        .WithMany()
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HRDepartment.Models.Technologies", "Technologies")
                        .WithMany()
                        .HasForeignKey("TechnologiesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FutureEmployee");

                    b.Navigation("Technologies");
                });

            modelBuilder.Entity("HRDepartment.Models.MultipleJobs", b =>
                {
                    b.HasOne("HRDepartment.Models.FutureEmployee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HRDepartment.Models.Job", "Job")
                        .WithMany()
                        .HasForeignKey("JobId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");

                    b.Navigation("Job");
                });
#pragma warning restore 612, 618
        }
    }
}
*/