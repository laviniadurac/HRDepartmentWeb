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
        void Delete(int jobID);
        void UpdateJob(Job job);

        //void Save();

        IEnumerable<Job> GetAllJobs();

    }
}
