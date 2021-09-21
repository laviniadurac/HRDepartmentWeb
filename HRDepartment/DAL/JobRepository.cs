using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HRDepartment.Models;
using Microsoft.EntityFrameworkCore;

namespace HRDepartment.DAL
{
    public class JobRepository: IJobRepository, IDisposable
    {

        private HrContext context;

        public JobRepository(HrContext context)
        {
            this.context = context;
        }

        public IEnumerable<Job> GetJobs()
        {
            return context.Jobs.ToList();
        }

        public Job GetJobByID(int id)
        {
            return context.Jobs.Find(id);
        }

        public void InsertJob(Job job)
        {
            context.Jobs.Add(job);
        }

        public void DeleteJob(int jobID)
        {
            Job job = context.Jobs.Find(jobID);
            context.Jobs.Remove(job);
        }

        public void UpdateJob(Job job)
        {
            context.Entry(job).State = EntityState.Modified;
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
