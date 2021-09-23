using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HRDepartment.Models;

namespace HRDepartment.DAL
{
    public interface IExperienceRepository : IDisposable
    {

        IEnumerable<Experience> GetExperiences();
        Experience GetExperienceByID(int experienceId);
        void InsertExperience(Experience experience);
        void DeleteExperience(int experienceID);
        void UpdateExperience(Experience experience);
        void Save();
    }
}
