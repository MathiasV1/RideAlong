using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RideAlong.Models.Domain;

namespace RideAlong.Controllers
{
    public class PersonController : Controller
    {
        private readonly IDriverRepository _driverRepository;
        private readonly IPassengerRepository _passengerRepository;


        public IActionResult Index()
        {
            return View();
        }
    }
}