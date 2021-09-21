using HRDepartment.DAL;
using HRDepartment.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRDepartment.Controllers
{
    public class FutureEmployeeTechnologiesController : Controller
    {
        IFutureEmployeeTechnologiesRepository _futureEmployeeTechnologiesRepository;
        public FutureEmployeeTechnologiesController()
        {
            _futureEmployeeTechnologiesRepository = new FutureEmployeeTechnologiesRepository(new HrContext());
        }
        public FutureEmployeeTechnologiesController(IFutureEmployeeTechnologiesRepository futureEmployeeTechnologiesRepository)
        {
            _futureEmployeeTechnologiesRepository = futureEmployeeTechnologiesRepository;
        }
        [HttpGet]
        public ActionResult Index()
        {
            var model = _futureEmployeeTechnologiesRepository.GetFutureEmployeeTechnologies();
            return View(model);
        }
        [HttpGet]
        public ActionResult AddFutureEmployeeTechnology()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddFutureEmployeeTechnology(FutureEmployeeTechnologies model)
        {
            if (ModelState.IsValid)
            {
                _futureEmployeeTechnologiesRepository.InsertFutureEmployeeTechnologies(model);
                _futureEmployeeTechnologiesRepository.Save();
                return RedirectToAction("Index", "Employee"); // MODIFICAM
            }
            return View();
        }
        [HttpGet]
        public ActionResult EditFutureEmployeeTechnology(int futureEmployeeTechnologyId)
        {
            FutureEmployeeTechnologies model = _futureEmployeeTechnologiesRepository.GetFutureEmployeeTechnologiesByID(futureEmployeeTechnologyId);
            return View(model);
        }

        [HttpPost]
        public ActionResult EditFutureEmployeeTechnology(FutureEmployeeTechnologies model)
        {
            if (ModelState.IsValid)
            {
                _futureEmployeeTechnologiesRepository.UpdateFutureEmployeeTechnologies(model);
                _futureEmployeeTechnologiesRepository.Save();
                return RedirectToAction("Index", "Employee");// MODIFICAM
            }
            else
            {
                return View(model);
            }
        }
        [HttpGet]
        public ActionResult DeleteTechnology(int futureEmployeeTechnologyId)
        {
            FutureEmployeeTechnologies model = _futureEmployeeTechnologiesRepository.GetFutureEmployeeTechnologiesByID(futureEmployeeTechnologyId);
            return View(model);
        }
        [HttpPost]
        public ActionResult Delete(int futureEmployeeTechnologyId)
        {
            _futureEmployeeTechnologiesRepository.DeleteFutureEmployeeTechnologies(futureEmployeeTechnologyId);
            _futureEmployeeTechnologiesRepository.Save();
            return RedirectToAction("Index", "Employee");
        }
    }
}
