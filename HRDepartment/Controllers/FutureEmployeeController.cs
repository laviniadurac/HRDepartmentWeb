using HRDepartment.DAL;
using HRDepartment.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRDepartment.Controllers
{
    public class FutureEmployeeController : Controller
    {
        IFutureEmployeeRepository _futureEmployeeRepository;
        public FutureEmployeeController()
        {
            _futureEmployeeRepository = new FutureEmployeeRepository(new HrContext());
        }
        public FutureEmployeeController(IFutureEmployeeRepository futureEmployeeRepository)
        {
            _futureEmployeeRepository = futureEmployeeRepository;
        }
        [HttpGet]
        public ActionResult Index()
        {
            var model = _futureEmployeeRepository.GetFutureEmployees();
            return View(model);
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
