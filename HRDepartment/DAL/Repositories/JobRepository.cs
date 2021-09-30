using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HRDepartment.Data;
using HRDepartment.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace HRDepartment.DAL
{
    public class JobRepository: IJobRepository, IDisposable
    {

        private ApplicationDbContext context;


        public JobRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        public List<SelectListItem> GetJobs()
        {
            return context.Jobs
                .Select(x =>
                    new SelectListItem
                    {
                        Value = x.JobId.ToString(),
                        Text = x.JobName
                    }
                ).ToList();
        }

        public Job GetJobByID(int id)
        {
            return context.Jobs.Find(id);
        }

        public void InsertJob(Job job)
        {
            context.Jobs.Add(job);
            context.SaveChanges();

        }

        public void Delete(int jobID)
        {
            Job job = context.Jobs.Find(jobID);
            context.Jobs.Remove(job);
            context.SaveChanges();
        }

        public void UpdateJob( Job job)
        {

               
                context.Entry(job).State = EntityState.Modified;
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


        public IEnumerable<Job> GetAllJobs()
        {
            return context.Jobs.ToList();
        }

        //public void Save()
        //{
        //    context.SaveChanges();
        //}

    }
}
