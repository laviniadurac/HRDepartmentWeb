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
        public List<SelectListItem> Jobs { get; set; }
        public FutureEmployee FutureEmployee { get; set; }
    }
}
