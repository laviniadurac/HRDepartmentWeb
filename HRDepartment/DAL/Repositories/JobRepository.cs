﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HRDepartment.Data;
using HRDepartment.Models;
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
            Save();
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
        private void Save()
        {
            context.SaveChanges();
        }
    }
}
