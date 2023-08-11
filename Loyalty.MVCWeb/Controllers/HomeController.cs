using Loyalty.MVCWeb.Helper;
using Loyalty.MVCWeb.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Loyalty.MVCWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IFlight _flight;
        private readonly IConfiguration _configuration;

        public HomeController(ILogger<HomeController> logger, IFlight flight, IConfiguration configuration)
        {
            _logger = logger;
            _flight = flight;
            _configuration = configuration;
        }

        public IActionResult Index()
        {
            //Flights fligts = new Flights();
            //fligts.GetFlightDetails();
            var result =_flight.GetFlightDetails();
            //Connection
            //var connection = _configuration.GetValue<string>("ConnectionStrings:DefaultConnection");
            ViewBag.Data = result;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}