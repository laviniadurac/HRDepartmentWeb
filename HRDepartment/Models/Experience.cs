using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HRDepartment.Models
{
    public class Experience
    {
        public int ExperienceId { get; set; }

        [Display(Name = "Years of experience")]
        public string YearsOfExperience { get; set; }
    }
}
