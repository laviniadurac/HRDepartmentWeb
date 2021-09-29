using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRDepartment.ViewModels
{
    public class JobViewModel
    {
        public int JobId { get; set; }
        public string JobName { get; set; }
        public bool IsAvailable { get; set; }

    }
}
