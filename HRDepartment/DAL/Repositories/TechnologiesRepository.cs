using HRDepartment.Data;
using HRDepartment.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRDepartment.DAL
{
    public class TechnologiesRepository : ITechnologiesRepository, IDisposable
    {

        private ApplicationDbContext context;


        public TechnologiesRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        public IEnumerable<Technologies> GetTechnologies()
        {
            return context.Technologies.ToList();
        }


        public Technologies GetTechnologyByID(int technologyId)
        {
            return context.Technologies.Find(technologyId);
        }


        public void InsertTechnology(Technologies technology)
        {
            context.Technologies.Add(technology);
        }

        public void DeleteTechnology(int technologyID)
        {
            Technologies technology = context.Technologies.Find(technologyID);
            context.Technologies.Remove(technology);
        }

        public void UpdateTechnology(Technologies technology)
        {
            context.Entry(technology).State = EntityState.Modified;
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
