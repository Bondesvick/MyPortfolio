using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyPortfolio.Models;
using MyPortfolio.Repository;

namespace MyPortfolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly ViewModel _model;

        public HomeController(ILogger<HomeController> logger, IRepository repository, IClientRepo clientRepo)
        {
            _logger = logger;

            _model = new ViewModel { MyDetails = repository.GetAllData(), Clients = clientRepo.GetClients() };
        }

        public IActionResult _Layout()
        {
            return View(_model);
        }

        public IActionResult Index()
        {
            return View(_model);
        }

        //public IActionResult About()
        //{
        //    return View();
        //}

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}