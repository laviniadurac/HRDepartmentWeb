using HRDepartment.Data;
using HRDepartment.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRDepartment.DAL
{
    public class FutureEmployeeTechnologiesRepository : IFutureEmployeeTechnologiesRepository, IDisposable
    {
        private ApplicationDbContext context;

        public FutureEmployeeTechnologiesRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        public IEnumerable<FutureEmployeeTechnologies> GetFutureEmployeeTechnologies()
        {
            return context.FutureEmployeesTechnologies.ToList();
        }


        public FutureEmployeeTechnologies GetFutureEmployeeTechnologiesByID(int futureEmployeeTechnologiesId)
        {
            return context.FutureEmployeesTechnologies.Find(futureEmployeeTechnologiesId);
        }


        public void InsertFutureEmployeeTechnologies(FutureEmployeeTechnologies futureEmployeeTechnologies)
        {
            context.FutureEmployeesTechnologies.Add(futureEmployeeTechnologies);
        }

        public void DeleteFutureEmployeeTechnologies(int futureEmployeeTechnologiesID)
        {
            FutureEmployeeTechnologies futureEmployeeTechnologies = context.FutureEmployeesTechnologies.Find(futureEmployeeTechnologiesID);
            context.FutureEmployeesTechnologies.Remove(futureEmployeeTechnologies);
        }

        public void UpdateFutureEmployeeTechnologies(FutureEmployeeTechnologies futureEmployeeTechnologies)
        {
            context.Entry(futureEmployeeTechnologies).State = EntityState.Modified;
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
