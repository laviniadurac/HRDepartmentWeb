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
        ITechnologiesRepository _technologiesRepository;
        IExperienceRepository _experienceRepository;

        public FutureEmployeeController(IFutureEmployeeRepository futureEmployeeRepository, IJobRepository jobRepository, ITechnologiesRepository technologiesRepository, IExperienceRepository experienceRepository)
        {
            _futureEmployeeRepository = futureEmployeeRepository;
            _jobRepository = jobRepository;
            _technologiesRepository = technologiesRepository;
            _experienceRepository = experienceRepository;
        }

        public IActionResult Create(JobListViewModel jobListViewModel, List<string> TechItems)
        {
            var futureEmployee = new FutureEmployee()
            {
                EmployeeName = jobListViewModel.EmployeeName,
                PhoneNumber = jobListViewModel.PhoneNumber,
                Address = jobListViewModel.Address,
                Email = jobListViewModel.Email,
                OtherDetails = jobListViewModel.OtherDetails,
                CV = jobListViewModel.CV,
                Experience = jobListViewModel.ExperienceItem,
                
                
            };

            AddFutureEmployee(futureEmployee);

            //return RedirectToAction("NumeMetoda", "NumeController");
            return View();
        }

        [HttpGet]
        public ActionResult Index()
        {
            var model = _futureEmployeeRepository.GetFutureEmployees();
            return View(model);
        }


        public ActionResult Application()
        {

            var jobListVM = new JobListViewModel
            {
                FutureEmployee = new FutureEmployee(),
                Jobs = _jobRepository.GetJobs(),
                Technologies = _technologiesRepository.GetTechnologies(),
                Experiences = _experienceRepository.GetExperiences().ConvertAll(x =>
                {
                    return new SelectListItem()
                    {
                        Text = x.ToString(),
                        Value = x.ToString(),
                        Selected = false
                    };
                }),

            };
            return View(jobListVM);
        }


        [HttpGet]
        public ActionResult AddJob()
        {
            return View();
        }
        public void AddFutureEmployee(FutureEmployee model)
        {
            ///summary
            ///we will comment modelstate for back-end testing purposes
           // if (ModelState.IsValid)
            //{
                _futureEmployeeRepository.InsertFutureEmployee(model);
                _futureEmployeeRepository.Save();
               
            //}
        }

        [HttpGet]
        public ActionResult GetFutureEmployeeById(int futureEmployeeId)
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
       
        [HttpPost]
        public ActionResult Delete(int futureEmployeeID)
        {
            _futureEmployeeRepository.DeleteFutureEmployee(futureEmployeeID);
            _futureEmployeeRepository.Save();
            return RedirectToAction("Index", "Employee");
        }
    }
}
