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
        private readonly IDriverRepository _driverRepository;
        private readonly IPassengerRepository _passengerRepository;

        public ActiveController(IDriverRepository dr, IPassengerRepository pr) {
            this._driverRepository = dr;
            this._passengerRepository = pr;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ActiveDriverView(int driverID) {
            Driver driver = _driverRepository.GetBy(driverID);
            ViewData["Driver"] = driver.Naam;
            List<Passenger> passengers = null; // _passengerRepository.getAllInRange(driver.MaxDetour);
            return View(passengers);
        }
    }
}