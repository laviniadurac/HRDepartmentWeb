using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HRDepartment.Models
{
    public class FutureEmployeeTechnologies
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public int TechnologiesId { get; set; }

        [ForeignKey("EmployeeId")]
        public virtual FutureEmployee FutureEmployee { get; set; }

        [ForeignKey("TechnologiesId")]
        public virtual Technologies Technologies { get; set; }
    }
}
