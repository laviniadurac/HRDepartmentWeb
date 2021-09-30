using HRDepartment.DAL;
using HRDepartment.Data;
using HRDepartment.Helpers;
using HRDepartment.Models;
using HRDepartment.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRDepartment.Controllers
{
    public class JobController : Controller
    {
        private readonly  IJobRepository _jobRepository;

        private readonly IJobControllerHelper _jobControllerHelper;


        public JobController(IJobControllerHelper jobControllerHelper)
        {
            this._jobRepository = new JobRepository(new ApplicationDbContext());
            _jobControllerHelper = jobControllerHelper;
        }

        [HttpGet]

        public ActionResult Index()
        {
            List<JobViewModel> jobViewModels = new List<JobViewModel>();
            var models = _jobRepository.GetAllJobs();

            foreach(var model in models)
            {
                jobViewModels.Add(_jobControllerHelper.BuildViewModel(model));
            }

            return View(jobViewModels);

        }


        [HttpPost]
        public JsonResult AddJob(JobViewModel model)
        {
            if (ModelState.IsValid)
            {
                _jobRepository.InsertJob(_jobControllerHelper.BuildQuery(model));
            }

            return new JsonResult(model);
        }

        [HttpPost]
        public ActionResult EditJob(JobViewModel model)
        {
            if (ModelState.IsValid)
            {
                _jobRepository.UpdateJob(_jobControllerHelper.BuildQuery(model));
            }
            return new JsonResult(model);
        }
 
        [HttpDelete]
        public ActionResult Delete(int jobID)
        {
            _jobRepository.Delete(jobID);
            return RedirectToAction("Index", "Job");
        }

        public ActionResult ListJobs()
        {
            var jobsList = _jobRepository.GetJobs().ToList();
            ViewBag.Jobs = new SelectList(jobsList, "JobId", "JobName");
            return View(jobsList);
        }
    }
}

