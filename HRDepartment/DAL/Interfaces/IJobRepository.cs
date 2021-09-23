using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HRDepartment.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HRDepartment.DAL
{
    public interface IJobRepository : IDisposable
    {
        List<SelectListItem> GetJobs();
        Job GetJobByID(int jobId);
        void InsertJob(Job job);
        void DeleteJob(int jobID);
        void UpdateJob(Job job);
<<<<<<< HEAD
        void Save();
=======
        IEnumerable<Job> GetAllJobs();
>>>>>>> 8fdd9118eb385d3a34ae65316bf3a9eb6cab4264
    }
}
