using HRDepartment.DAL;
using HRDepartment.Data;
using HRDepartment.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
   
namespace HRDepartment.Controllers
{
    public class JobController : Controller
{
        private IJobRepository _jobRepository;
       
        //GET: JOB

        public JobController()
        {
            this._jobRepository = new JobRepository(new ApplicationDbContext());
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

        public ActionResult ListJobs()
        {
            var jobsList = _jobRepository.GetJobs().ToList();
            ViewBag.Jobs = new SelectList(jobsList, "JobId", "JobName");
            return View(jobsList);
        }

    }
}
