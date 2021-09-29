using HRDepartment.Models;
using HRDepartment.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRDepartment.Helpers
{
    public interface IJobControllerHelper
    {
        JobViewModel BuildViewModel(Job job);

        Job BuildQuery(JobViewModel jobViewModel);
    }
}
