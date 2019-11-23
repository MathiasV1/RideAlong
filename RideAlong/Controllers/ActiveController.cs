using Microsoft.AspNetCore.Mvc;
using RideAlong.Models.Domain;
using System.Collections.Generic;

namespace RideAlong.Controllers {
    public class ActiveController : Controller {
        private readonly IDriverRepository _driverRepository;
        private readonly IPassengerRepository _passengerRepository;

        public ActiveController(IDriverRepository dr, IPassengerRepository pr) {
            this._driverRepository = dr;
            this._passengerRepository = pr;
        }

        public IActionResult Index() {
            return View();
        }

        public IActionResult ActiveDriverView(int driverID) {
            Driver driver = _driverRepository.GetBy(driverID);
            ViewData["Driver"] = driver.Naam;
            List<Passenger> passengers = _passengerRepository.getAllInRange(driver.StartLocation, driver.MaxDetour);
            return View(passengers);
        }
    }
}