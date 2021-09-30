using HRDepartment.Data;
using HRDepartment.Models;
using HRDepartment.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HRDepartment.Helpers;

namespace HRDepartment.DAL
{
    public class FutureEmployeeRepository : IFutureEmployeeRepository
    {

        private ApplicationDbContext context;

        public FutureEmployeeRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        public IEnumerable<FutureEmployee> GetFutureEmployees()
        {
            return context.FutureEmployees.ToList();
        }


        public FutureEmployee GetFutureEmployeeByID(int futureEmployeeId)
        {
            return context.FutureEmployees.Find(futureEmployeeId);
        }


        public void InsertFutureEmployee(FutureEmployee futureEmployee)
        {
            context.FutureEmployees.Add(futureEmployee);
        }

        public void DeleteFutureEmployee(int futureEmployeeID)
        {
            FutureEmployee futureEmployee = context.FutureEmployees.Find(futureEmployeeID);
            context.FutureEmployees.Remove(futureEmployee);
        }

        public void UpdateFutureEmployee(FutureEmployee futureEmployee)
        {
            context.Entry(futureEmployee).State = EntityState.Modified;
            Save();
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public List<EmployeeViewModel> GetEmployeeData()
        {
            var a = context.MultipleJobsPerEmployee.Join(
            context.FutureEmployeesTechnologies,
            futureEmployee => futureEmployee.EmployeeId,
            mJob => mJob.EmployeeId,
            (futureEmployee, mJob) => new EmployeeViewModel
            {
                Technology = mJob.Technologies.TechnologyName,
                JobName = futureEmployee.Job.JobName,
                EmployeeId = futureEmployee.Employee.EmployeeId,
                EmployeeName = futureEmployee.Employee.EmployeeName,
                Status = StatusEnumConvert.GetEnumerator(futureEmployee.Employee.Status),
                Experience = futureEmployee.Employee.Experience
            })
                .ToList();

            return a;
        }
    }
}
