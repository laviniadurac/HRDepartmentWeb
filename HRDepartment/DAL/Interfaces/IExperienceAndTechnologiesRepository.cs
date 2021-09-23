using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HRDepartment.Models;

namespace HRDepartment.DAL
{
    public interface IExperienceAndTechnologiesRepository:IDisposable
    {
        IEnumerable<ExperienceAndTechnologies> GetExperienceAndTechnologies();
        ExperienceAndTechnologies GetExperienceAndTechnologiesByID(int experienceAndTechnologiesId);
        void InsertExperienceAndTechnologies(ExperienceAndTechnologies experienceAndTechnologies);
        void DeleteExperienceAndTechnologies(int experienceAndTechnologiesID);
        void UpdateExperienceAndTechnologies(ExperienceAndTechnologies experienceAndTechnologies);
        void Save();

    }
}
