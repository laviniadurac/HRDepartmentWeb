using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HRDepartment.Models
{
    public class MultipleJobs
    {
        [Key]
        public int MultipleJobsId { get; set; }
        public int EmployeeId { get; set; }

        [ForeignKey("EmployeeId")]
        public virtual FutureEmployee Employee { get; set; }

        public int JobId { get; set; }

        [ForeignKey("JobId")]
        public virtual Job Job { get; set; }
    }
}
