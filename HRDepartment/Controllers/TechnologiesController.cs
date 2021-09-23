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
    public class TechnologiesController : Controller
    {
        ITechnologiesRepository _technologyRepository;
        public TechnologiesController()
        {
            _technologyRepository = new TechnologiesRepository(new ApplicationDbContext());
        }
        public TechnologiesController(ITechnologiesRepository technologyRepository)
        {
            _technologyRepository = technologyRepository;
        }
        [HttpGet]
        public ActionResult Index()
        {
            var model = _technologyRepository.GetTechnologies();
            return View(model);
        }
        [HttpGet]
        public ActionResult AddTechnology()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddTechnology(Technologies model)
        {
            if (ModelState.IsValid)
            {
                _technologyRepository.InsertTechnology(model);
                _technologyRepository.Save();
                return RedirectToAction("Index", "Employee"); // MODIFICAM
            }
            return View();
        }
        [HttpGet]
        public ActionResult EditTechnology(int technologyId)
        {
            Technologies model = _technologyRepository.GetTechnologyByID(technologyId);
            return View(model);
        }

        [HttpPost]
        public ActionResult EditTechnology(Technologies model)
        {
            if (ModelState.IsValid)
            {
                _technologyRepository.UpdateTechnology(model);
                _technologyRepository.Save();
                return RedirectToAction("Index", "Employee");// MODIFICAM
            }
            else
            {
                return View(model);
            }
        }
        [HttpGet]
        public ActionResult DeleteTechnology(int technologyId)
        {
            Technologies model = _technologyRepository.GetTechnologyByID(technologyId);
            return View(model);
        }
        [HttpPost]
        public ActionResult Delete(int technologyId)
        {
            _technologyRepository.DeleteTechnology(technologyId);
            _technologyRepository.Save();
            return RedirectToAction("Index", "Employee");
        }
    }
}
