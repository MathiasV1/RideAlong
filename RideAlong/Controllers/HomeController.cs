using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RideAlong.Models.Domain;
using System;
using System.Collections.Generic;

namespace RideAlong.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDriverRepository _driverRepository;
        private readonly IPassengerRepository _passengerRepository;
        private readonly ILogger<HomeController> _logger;
        public HomeController(ILogger<HomeController> logger, IDriverRepository dr, IPassengerRepository pr)
        {
            _logger = logger;
            _driverRepository = dr;
            _passengerRepository = pr;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ActiveDriverView()
        {
            Random r = new Random();
            int index = r.Next(5);
            Driver driver = _driverRepository.GetBy(index);
            ViewData["Driver"] = driver.Naam;
            List<Passenger> passengers = _passengerRepository.getAllInRange(driver.StartLocation, driver.MaxDetour);
            return View(passengers);
        }
    }
}