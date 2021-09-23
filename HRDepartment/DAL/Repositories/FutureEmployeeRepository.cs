using HRDepartment.Data;
using HRDepartment.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRDepartment.DAL
{
    public class FutureEmployeeRepository : IFutureEmployeeRepository, IDisposable
    {

        private ApplicationDbContext context;

        public FutureEmployeeRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        public IEnumerable<FutureEmployee> GetFutureEmployees()
        {
            return context.FutureEmployees.ToList();
        }


        public FutureEmployee GetFutureEmployeeByID(int futureEmployeeId)
        {
            return context.FutureEmployees.Find(futureEmployeeId);
        }


        public void InsertFutureEmployee(FutureEmployee futureEmployee)
        {
            context.FutureEmployees.Add(futureEmployee);
        }

        public void DeleteFutureEmployee(int futureEmployeeID)
        {
            FutureEmployee futureEmployee = context.FutureEmployees.Find(futureEmployeeID);
            context.FutureEmployees.Remove(futureEmployee);
        }

        public void UpdateFutureEmployee(FutureEmployee futureEmployee)
        {
            context.Entry(futureEmployee).State = EntityState.Modified;
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
