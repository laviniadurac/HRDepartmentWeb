using HRDepartment.DAL;
using HRDepartment.Data;
using HRDepartment.HelperVio;
using HRDepartment.Models;
using HRDepartment.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRDepartment.Controllers
{
    public class FutureEmployeeTableController : Controller
    {

        IFutureEmployeeRepository _futureEmployeeRepository;
        IJobRepository _jobRepository;

        public FutureEmployeeTableController()
        {
            _futureEmployeeRepository = new FutureEmployeeRepository(new ApplicationDbContext());
            _jobRepository = new JobRepository(new ApplicationDbContext());
        }

        [HttpGet]
        public ActionResult Index()
        {
            List<EmployeeViewModel> employees = _futureEmployeeRepository.GetEmployeeData();
           
            //    var model = new FutureEmployeeTableViewModel();
            //List<FutureEmployeeTableViewModel> ControllerList


            //model.FutureEmployees = _futureEmployeeRepository.GetFutureEmployees();
            //    model.Jobs = _jobRepository.GetAllJobs();

            //    foreach (var employee in model.FutureEmployees)
            //    {
            //        model.ControllerList.Add(_futureEmployeeTableRepository.BuildViewModelFutureEmployee(employee, model));
            //    }  

            //    foreach (var job in model.Jobs)
            //    {

            //        model.ControllerList.Add(_futureEmployeeTableRepository.BuildViewModelJob(job, model));
            //}


            return View(employees);
        }

        //[HttpGet]
        //public ActionResult AddExperience()
        //{
        //    return View();
        //}

        //[HttpPost]
        //public ActionResult AddExperience(Experience model)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _experienceRepository.InsertExperience(model);
        //        _experienceRepository.Save();
        //        return RedirectToAction("Index", "Employee"); // MODIFICAM
        //    }
        //    return View();
        //}
        //[HttpGet]
        //public ActionResult EditExperience(int experienceId)
        //{
        //    Experience model = _experienceRepository.GetExperienceByID(experienceId);
        //    return View(model);
        //}

        //[HttpPost]
        //public ActionResult EditExperience(Experience model)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _experienceRepository.UpdateExperience(model);
        //        _experienceRepository.Save();
        //        return RedirectToAction("Index", "Employee");// MODIFICAM
        //    }
        //    else
        //    {
        //        return View(model);
        //    }
        //}
        //[HttpGet]
        //public ActionResult DeleteExperience(int experienceId)
        //{
        //    Experience model = _experienceRepository.GetExperienceByID(experienceId);
        //    return View(model);
        //}
        //[HttpPost]
        //public ActionResult Delete(int experienceID)
        //{
        //    _experienceRepository.DeleteExperience(experienceID);
        //    _experienceRepository.Save();
        //    return RedirectToAction("Index", "Employee");
        //}
    }
}
