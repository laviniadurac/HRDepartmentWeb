using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HRDepartment.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HRDepartment.DAL
{
    public interface IExperienceRepository : IDisposable
    {

        List<string> GetExperiences();
        Experience GetExperienceByID(int experienceId);
        void InsertExperience(Experience experience);
        void DeleteExperience(int experienceID);
        void UpdateExperience(Experience experience);
        void Save();
    }
}
