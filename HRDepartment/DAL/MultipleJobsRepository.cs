using HRDepartment.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRDepartment.DAL
{
    public class MultipleJobsRepository : IMultipleJobsRepository, IDisposable
    {

        private HrContext context;

        public MultipleJobsRepository(HrContext context)
        {
            this.context = context;
        }

 

        public IEnumerable<MultipleJobs> GetMultipleJobs()
        {
            return context.MultipleJobsPerEmployee.ToList();
        }


        public MultipleJobs GetMultipleJobsByID(int multipleJobsId)
        {
            return context.MultipleJobsPerEmployee.Find(multipleJobsId);
        }


        public void InsertMultipleJobs(MultipleJobs multipleJobs)
        {
            context.MultipleJobsPerEmployee.Add(multipleJobs);
        }

        public void DeleteMultipleJobs(int multipleJobsID)
        {
            MultipleJobs MultipleJobs = context.MultipleJobsPerEmployee.Find(multipleJobsID);
            context.MultipleJobsPerEmployee.Remove(MultipleJobs);
        }

        public void UpdateMultipleJobs(MultipleJobs multipleJobs)
        {
            context.Entry(multipleJobs).State = EntityState.Modified;
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
