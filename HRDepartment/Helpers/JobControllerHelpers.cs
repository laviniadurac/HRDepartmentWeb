using HRDepartment.Models;
using HRDepartment.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRDepartment.Helpers
{
    public class JobControllerHelpers: IJobControllerHelper
    {
        
        public JobViewModel BuildViewModel(Job job)
        {
            return new JobViewModel
            {
                JobId = job.JobId,
                JobName = job.JobName,
                IsAvailable = job.IsAvailable
            };
        }

        //add a new job
        public Job BuildQuery(JobViewModel jobViewModel)
        {
            return new Job
            {
                JobId = jobViewModel.JobId,
                JobName = jobViewModel.JobName,
                IsAvailable = jobViewModel.IsAvailable
            };
        }
    }
}
