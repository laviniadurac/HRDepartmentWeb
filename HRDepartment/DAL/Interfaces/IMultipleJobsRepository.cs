using HRDepartment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRDepartment.DAL
{
    public interface IMultipleJobsRepository : IDisposable
    {
        IEnumerable<MultipleJobs> GetMultipleJobs();
        MultipleJobs GetMultipleJobsByID(int jobId);
        void InsertMultipleJobs(MultipleJobs MultipleJobs);
        void DeleteMultipleJobs(int multipleJobsID);
        void UpdateMultipleJobs(MultipleJobs multipleJobs);
        void Save();
    }
}
