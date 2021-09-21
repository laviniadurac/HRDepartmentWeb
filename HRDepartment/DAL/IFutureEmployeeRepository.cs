using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HRDepartment.Models;

namespace HRDepartment.DAL
{
    public interface IFutureEmployeeRepository : IDisposable
    {
        IEnumerable<FutureEmployee> GetFutureEmployees();
        FutureEmployee GetFutureEmployeeByID(int futureEmployeeId);
        void InsertFutureEmployee(FutureEmployee futureEmployee);
        void DeleteFutureEmployee(int futureEmployeeID);
        void UpdateFutureEmployee(FutureEmployee futureEmployee);
        void Save();
    }
}
