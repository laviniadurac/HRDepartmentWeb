using HRDepartment.DAL;
using HRDepartment.Data;
using HRDepartment.Models;
using HRDepartment.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRDepartment.Controllers
{
    public class FutureEmployeeController : Controller
    {
        IFutureEmployeeRepository _futureEmployeeRepository;
        IJobRepository _jobRepository;

        public FutureEmployeeController(IFutureEmployeeRepository futureEmployeeRepository, IJobRepository jobRepository)
        {
            _futureEmployeeRepository = futureEmployeeRepository;
            _jobRepository = jobRepository;
        }

        [HttpGet]
        public ActionResult Index()
        {
            var model = _futureEmployeeRepository.GetFutureEmployees();
            return View(model);
        }


        [AllowAnonymous]
        public ActionResult Application()
        {
           
            var jobListVM = new JobListViewModel
            {
                FutureEmployee = new FutureEmployee(),
                Jobs = _jobRepository.GetJobs()
            };
            return View(jobListVM);
        }


        [HttpGet]
        public ActionResult AddJob()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddFutureEmployee(FutureEmployee model)
        {
            if (ModelState.IsValid)
            {
                _futureEmployeeRepository.InsertFutureEmployee(model);
                _futureEmployeeRepository.Save();
                return RedirectToAction("Index", "Employee"); // MODIFICAM
            }
            return View();
        }
        [HttpGet]
        public ActionResult EditFutureEmployee(int futureEmployeeId)
        {
            FutureEmployee model = _futureEmployeeRepository.GetFutureEmployeeByID(futureEmployeeId);
            return View(model);
        }

        [HttpPost]
        public ActionResult EditFutureEmployee(FutureEmployee model)
        {
            if (ModelState.IsValid)
            {
                _futureEmployeeRepository.UpdateFutureEmployee(model);
                _futureEmployeeRepository.Save();
                return RedirectToAction("Index", "Employee");// MODIFICAM
            }
            else
            {
                return View(model);
            }
        }
        [HttpGet]
        public ActionResult DeleteFutureEmployee(int futureEmployeeId)
        {
            FutureEmployee model = _futureEmployeeRepository.GetFutureEmployeeByID(futureEmployeeId);
            return View(model);
        }
        [HttpPost]
        public ActionResult Delete(int futureEmployeeID)
        {
            _futureEmployeeRepository.DeleteFutureEmployee(futureEmployeeID);
            _futureEmployeeRepository.Save();
            return RedirectToAction("Index", "Employee");
        }
    }
}
