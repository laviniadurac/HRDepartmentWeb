using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HRDepartment.Models;

namespace HRDepartment.DAL
{
    public interface IJobRepository : IDisposable
    {
        IEnumerable<Job> GetJobs();
        Job GetJobByID(int jobId);
        void InsertJob(Job job);
        void DeleteJob(int jobID);
        void UpdateJob(Job job);
        void Save();
        IEnumerable<Job> GetAllJobs();
    }
}
