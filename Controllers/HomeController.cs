using Final.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Final.Controllers
{
    public class HomeController : Controller
    {
        private IFinal repo;

        public HomeController(IFinal temp)
        {
            repo = temp;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Edit(double entertainerId)
        {
            var entertainer = repo.Entertainers.FirstOrDefault(x => x.EntertainerId == entertainerId);

            if (entertainer == null)
            {
                return NotFound();
            }

            return View(entertainer);
        }

        [HttpPost]
        public IActionResult Edit(Entertainer entertainer)
        {

            if (entertainer == null)
            {
                return NotFound();
            }

            repo.EditEntertainer(entertainer);

            ViewData["Message"] = "Record updated successfully.";

            return RedirectToAction("Entertainer", "Home");
        }

        [HttpGet]
        public IActionResult Delete (double entertainerId)
        {
            var entertainer = repo.Entertainers.FirstOrDefault(x => x.EntertainerId == entertainerId);

            if (entertainer == null)
            {
                return NotFound();
            }
            repo.DeleteEntertainer(entertainerId);

            return RedirectToAction("Entertainer", "Home");
        }

        public IActionResult Entertainer()
        {
            var listy = repo.Entertainers.ToList();

            return View(listy);
        }

        [HttpGet]
        public IActionResult CreateEntertainer()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateEntertainer(Entertainer entertainer)
        {
            if (entertainer == null)
            {
                return NotFound();
            }

            repo.CreateEntertainer(entertainer);

            return RedirectToAction("Entertainer");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
