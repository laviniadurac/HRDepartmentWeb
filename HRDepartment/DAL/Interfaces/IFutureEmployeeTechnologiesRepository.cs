using HRDepartment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRDepartment.DAL
{
    public interface IFutureEmployeeTechnologiesRepository: IDisposable
    {
        IEnumerable<FutureEmployeeTechnologies> GetFutureEmployeeTechnologies();
        FutureEmployeeTechnologies GetFutureEmployeeTechnologiesByID(int futureEmployeeTechnologiesId);
        void InsertFutureEmployeeTechnologies(FutureEmployeeTechnologies futureEmployeeTechnologies);
        void DeleteFutureEmployeeTechnologies(int futureEmployeeTechnologiesID);
        void UpdateFutureEmployeeTechnologies(FutureEmployeeTechnologies futureEmployeeTechnologies);
        void Save();
    }
}
