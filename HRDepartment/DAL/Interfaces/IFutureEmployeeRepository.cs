using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HRDepartment.Models;
using HRDepartment.ViewModels;

namespace HRDepartment.DAL
{
    public interface IFutureEmployeeRepository
    {
        IEnumerable<FutureEmployee> GetFutureEmployees();
        FutureEmployee GetFutureEmployeeByID(int futureEmployeeId);
        void InsertFutureEmployee(FutureEmployee futureEmployee);
        void DeleteFutureEmployee(int futureEmployeeID);
        void UpdateFutureEmployee(FutureEmployee futureEmployee);
        void Save();

        List<EmployeeViewModel> GetEmployeeData();
    }
}
