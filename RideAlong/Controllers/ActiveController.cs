using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RideAlong.Models.Domain;

namespace RideAlong.Controllers
{
    public class ActiveController : Controller
    {



        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ActiveDriverView(int driverID, List<Passenger> passengers) {
            //ViewData["Driver"] = ;
            return View(passengers);
        }
    }
}