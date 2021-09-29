using HRDepartment.DAL;
using HRDepartment.Data;
using HRDepartment.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRDepartment.Controllers
{
    public class ExperienceAndTechnologiesController : Controller
    {
        private readonly IExperienceAndTechnologiesRepository _experienceAndTechnologyRepository;
        public ExperienceAndTechnologiesController()
        {
            _experienceAndTechnologyRepository = new ExperienceAndTechnologiesRepository(new ApplicationDbContext());
        }
        public ExperienceAndTechnologiesController(IExperienceAndTechnologiesRepository experienceAndTechnologyRepository)
        {
            _experienceAndTechnologyRepository = experienceAndTechnologyRepository;
        }
        [HttpGet]
        public ActionResult Index()
        {
            var model = _experienceAndTechnologyRepository.GetExperienceAndTechnologies();
            return View(model);
        }
        [HttpGet]
        public ActionResult AddExperienceAndTechnology()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddExperienceAndTechnology(ExperienceAndTechnologies model)
        {
            if (ModelState.IsValid)
            {
                _experienceAndTechnologyRepository.InsertExperienceAndTechnologies(model);
                _experienceAndTechnologyRepository.Save();
                return RedirectToAction("Index", "Employee"); // MODIFICAM
            }
            return View();
        }
        [HttpGet]
        public ActionResult EditExperienceAndTechnology(int experienceAndTechnologyId)
        {
            ExperienceAndTechnologies model = _experienceAndTechnologyRepository.GetExperienceAndTechnologiesByID(experienceAndTechnologyId);
            return View(model);
        }

        [HttpPost]
        public ActionResult EditExperienceAndTechnology(ExperienceAndTechnologies model)
        {
            if (ModelState.IsValid)
            {
                _experienceAndTechnologyRepository.UpdateExperienceAndTechnologies(model);
                _experienceAndTechnologyRepository.Save();
                return RedirectToAction("Index", "Employee");// MODIFICAM
            }
            else
            {
                return View(model);
            }
        }
      
        [HttpPost]
        public ActionResult Delete(int experienceAndTechnologyId)
        {
            _experienceAndTechnologyRepository.DeleteExperienceAndTechnologies(experienceAndTechnologyId);
            _experienceAndTechnologyRepository.Save();
            return RedirectToAction("Index", "Employee");
        }

       
    }
}
