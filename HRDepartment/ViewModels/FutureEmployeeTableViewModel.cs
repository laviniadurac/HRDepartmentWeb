using HRDepartment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRDepartment.ViewModels
{
    public class EmployeeViewModel
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string JobName { get; set; }
        public string Status { get; set; }
        public string Technology { get; set; }
        public string Experience { get; set; }

    }

    public class FutureEmployeeTableViewModel
    {
        public IEnumerable<Job> Jobs { get; set; }
        public IEnumerable<FutureEmployee> FutureEmployees { get; set; }
        public FutureEmployee FutureEmployee { get; set; }
        public Job Job { get; set; }

        public FutureEmployeeTableViewModel()
        {
            Job = new Job();
        }
    }
}
