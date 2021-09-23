using HRDepartment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRDepartment.ViewModels
{
    public class JobListViewModel
    {
        public List<Job> Jobs { get; set; }
        public List<FutureEmployee> FutureEmployees { get; set; }
    }
}
