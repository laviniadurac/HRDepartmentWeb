using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HRDepartment.Models;

namespace HRDepartment.DAL
{
    public interface ITechnologiesRepository : IDisposable
    {
        IEnumerable<Technologies> GetTechnologies();
        Technologies GetTechnologyByID(int technologyId);
        void InsertTechnology(Technologies technology);
        void DeleteTechnology(int technologyID);
        void UpdateTechnology(Technologies technology);
        void Save();
    }
}
