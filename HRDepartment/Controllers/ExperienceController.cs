using HRDepartment.DAL;
using HRDepartment.Data;
using HRDepartment.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRDepartment.Controllers
{
    public class ExperienceController : Controller
    {

        IExperienceRepository _experienceRepository;
        public ExperienceController()
        {
            _experienceRepository = new ExperienceRepository(new ApplicationDbContext());
        }
        public ExperienceController(IExperienceRepository experienceRepository)
        {
            _experienceRepository = experienceRepository;
        }
        [HttpGet]
        public ActionResult Index()
        {
            var model = _experienceRepository.GetExperiences();
            return View(model);
        }
        [HttpGet]
        public ActionResult AddExperience()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddExperience(Experience model)
        {
            if (ModelState.IsValid)
            {
                _experienceRepository.InsertExperience(model);
                _experienceRepository.Save();
                return RedirectToAction("Index", "Employee"); // MODIFICAM
            }
            return View();
        }
        [HttpGet]
        public ActionResult EditExperience(int experienceId)
        {
            Experience model = _experienceRepository.GetExperienceByID(experienceId);
            return View(model);
        }

        [HttpPost]
        public ActionResult EditExperience(Experience model)
        {
            if (ModelState.IsValid)
            {
                _experienceRepository.UpdateExperience(model);
                _experienceRepository.Save();
                return RedirectToAction("Index", "Employee");// MODIFICAM
            }
            else
            {
                return View(model);
            }
        }
        [HttpGet]
        public ActionResult DeleteExperience(int experienceId)
        {
            Experience model = _experienceRepository.GetExperienceByID(experienceId);
            return View(model);
        }
        [HttpPost]
        public ActionResult Delete(int experienceID)
        {
            _experienceRepository.DeleteExperience(experienceID);
            _experienceRepository.Save();
            return RedirectToAction("Index", "Employee");
        }
    }
}
