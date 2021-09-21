using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HRDepartment.Models
{
    public class ExperienceAndTechnologies
    {
        public int Id { get; set; }
        public int ExperienceId { get; set; }
        public int TechnologiesId { get; set; }
        public int JobId { get; set; }

        [ForeignKey("ExperienceId")]
        public virtual Experience Experience { get; set; }

        [ForeignKey("TechnologiesId")]
        public virtual Technologies Technologies { get; set; }

        [ForeignKey("JobId")]
        public virtual Job Job { get; set; }
    }
}
