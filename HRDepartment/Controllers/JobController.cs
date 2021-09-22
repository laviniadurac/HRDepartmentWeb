using HRDepartment.DAL;
using HRDepartment.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
   
namespace HRDepartment.Controllers
{
    public class JobController : Controller

    {
        IJobRepository _jobRepository;
        public JobController()
        {
            _jobRepository = new JobRepository(new HrContext());
        }
        public JobController(IJobRepository jobRepository)
        {
            _jobRepository = jobRepository;
        }
        [HttpGet]
        public ActionResult Index()
        {
            var model = _jobRepository.GetJobs();
            return View(model);
        }
        [HttpGet]
        public ActionResult AddJob()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddJob(Job model)
        {
            if (ModelState.IsValid)
            {
                _jobRepository.InsertJob(model);
                _jobRepository.Save();
                return RedirectToAction("Index", "Employee"); // MODIFICAM
            }
            return View();
        }
        [HttpGet]
        public ActionResult EditJob(int jobId)
        {
            Job model = _jobRepository.GetJobByID(jobId);
            return View(model);
        }

        [HttpPost]
        public ActionResult EditJob(Job model)
        {
            if (ModelState.IsValid)
            {
                _jobRepository.UpdateJob(model);
                _jobRepository.Save();
                return RedirectToAction("Index", "Employee");// MODIFICAM
            }
            else
            {
                return View(model);
            }
        }
        [HttpGet]
        public ActionResult DeleteJob(int jobId)
        {
            Job model = _jobRepository.GetJobByID(jobId);
            return View(model);
        }
        [HttpPost]
        public ActionResult Delete(int jobID)
        {
            _jobRepository.DeleteJob(jobID);
            _jobRepository.Save();
            return RedirectToAction("Index", "Employee");
        }

        public ViewResult ListOfJobs()
        {
            return View(_jobRepository.GetJobs());
        }

    }
}
