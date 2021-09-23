using HRDepartment.Data;
using HRDepartment.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRDepartment.DAL
{
    public class ExperienceRepository : IExperienceRepository, IDisposable
    {
        private ApplicationDbContext context;

        public ExperienceRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        public IEnumerable<Experience> GetExperiences()
        {
            return context.Experiences.ToList();
        }


        public Experience GetExperienceByID(int experienceId)
        {
            return context.Experiences.Find(experienceId);
        }


        public void InsertExperience(Experience experience)
        {
            context.Experiences.Add(experience);
        }

        public void DeleteExperience(int experienceID)
        {
            Experience experience = context.Experiences.Find(experienceID);
            context.Experiences.Remove(experience);
        }

        public void UpdateExperience(Experience experience)
        {
            context.Entry(experience).State = EntityState.Modified;
        }

        public void Save()
        {
            context.SaveChanges();
        }


        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }


        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
      
    }
}
