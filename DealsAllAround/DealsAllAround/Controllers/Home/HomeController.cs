using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DealsAllAround.Models;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Data;


namespace Deals_All_Around.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }
        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }
        public IActionResult Error()
        {
            return View();
        }
        public IActionResult Choose()
        {
            return View();
        }
        public IActionResult AddDeals()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddDeals(DealProvider dealpro)
        {
            if (ModelState.IsValid)
            {
                DealsViewModel DealsVM = new DealsViewModel();
                DealsVM.GetDetails(dealpro);
                return RedirectToAction("Choose");
            }
            return View();
        }
        public IActionResult ShowAllData()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ShowAllData(DealsViewModel dealsVM)
        {
            List<DealProvider> DealsVM = dealsVM.GetAllData();
                return View(DealsVM);
        }
        public IActionResult UpdateData()
        {
            return View();

        }


        [HttpPost]

        public IActionResult UpdateData(DealProvider dealpro)
        {
            try
            {
                DealsViewModel DealsVM = new DealsViewModel();

                DealsVM.UpdateData(dealpro);
                return RedirectToAction("Choose");
            }
            catch
            {
                return View();
            }
        }


        //public IActionResult DeleteData(int id)
        //{
        //    try
        //    {
        //        DealsViewModel DealsVM = new DealsViewModel();
        //        if (DealsVM.DeleteData(id))
        //        {
        //            ViewBag.AlertMsg = "Employee details deleted successfully";

        //        }
        //        return RedirectToAction("Choose");

        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

    }
}