using HRDepartment.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRDepartment.DAL
{
    public class ExperienceAndTechnologiesRepository : IExperienceAndTechnologiesRepository, IDisposable
    {


        private HrContext context;

        public ExperienceAndTechnologiesRepository(HrContext context)
        {
            this.context = context;
        }

        public IEnumerable<ExperienceAndTechnologies> GetExperienceAndTechnologies()
        {
            return context.ExperiencesAndTechnologies.ToList();
        }


        public ExperienceAndTechnologies GetExperienceAndTechnologiesByID(int experienceAndTechnologiesId)
        {
            return context.ExperiencesAndTechnologies.Find(experienceAndTechnologiesId);
        }


        public void InsertExperienceAndTechnologies(ExperienceAndTechnologies experienceAndTechnologies)
        {
            context.ExperiencesAndTechnologies.Add(experienceAndTechnologies);
        }

        public void DeleteExperienceAndTechnologies(int experienceAndTechnologiesID)
        {
            ExperienceAndTechnologies experienceAndTechnologies = context.ExperiencesAndTechnologies.Find(experienceAndTechnologiesID);
            context.ExperiencesAndTechnologies.Remove(experienceAndTechnologies);
        }

        public void UpdateExperienceAndTechnologies(ExperienceAndTechnologies experienceAndTechnologies)
        {
            context.Entry(experienceAndTechnologies).State = EntityState.Modified;
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
