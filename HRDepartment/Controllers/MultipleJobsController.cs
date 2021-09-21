using HRDepartment.DAL;
using HRDepartment.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRDepartment.Controllers
{
    public class MultipleJobsController : Controller
    {
        IMultipleJobsRepository _multipleJobsRepository;
        public MultipleJobsController()
        {
            _multipleJobsRepository = new MultipleJobsRepository(new HrContext());
        }
        public MultipleJobsController(IMultipleJobsRepository multipleJobsRepository)
        {
            _multipleJobsRepository = multipleJobsRepository;
        }
        [HttpGet]
        public ActionResult Index()
        {
            var model = _multipleJobsRepository.GetMultipleJobs();
            return View(model);
        }
        [HttpGet]
        public ActionResult AddMultipleJob()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddMultipleJob(MultipleJobs model)
        {
            if (ModelState.IsValid)
            {
                _multipleJobsRepository.InsertMultipleJobs(model);
                _multipleJobsRepository.Save();
                return RedirectToAction("Index", "Employee"); // MODIFICAM
            }
            return View();
        }
        [HttpGet]
        public ActionResult EditMultipleJobs(int mutltipleJobsId)
        {
            MultipleJobs model = _multipleJobsRepository.GetMultipleJobsByID(mutltipleJobsId);
            return View(model);
        }

        [HttpPost]
        public ActionResult EditMultipleJobs(MultipleJobs model)
        {
            if (ModelState.IsValid)
            {
                _multipleJobsRepository.UpdateMultipleJobs(model);
                _multipleJobsRepository.Save();
                return RedirectToAction("Index", "Employee");// MODIFICAM
            }
            else
            {
                return View(model);
            }
        }
        [HttpGet]
        public ActionResult DeleteMultipleJobs(int mutltipleJobsId)
        {
            MultipleJobs model = _multipleJobsRepository.GetMultipleJobsByID(mutltipleJobsId);
            return View(model);
        }
        [HttpPost]
        public ActionResult Delete(int mutltipleJobsId)
        {
            _multipleJobsRepository.DeleteMultipleJobs(mutltipleJobsId);
            _multipleJobsRepository.Save();
            return RedirectToAction("Index", "Employee");
        }
    }
}
