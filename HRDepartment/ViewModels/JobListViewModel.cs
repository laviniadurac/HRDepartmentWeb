using HRDepartment.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRDepartment.ViewModels
{
    public class JobListViewModel
    {
        public string EmployeeName { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string OtherDetails { get; set; }
        public string CV { get; set; }

        public List<SelectListItem> Jobs { get; set; }
        public FutureEmployee FutureEmployee { get; set; }
        public IEnumerable<Technologies> Technologies { get; set; }
        public List<string> TechItems { get; set; }
        public List<SelectListItem> Experiences { get; set; }
        public string ExperienceItem { get; set; }
        public string Job { get; set; }
    }
}
