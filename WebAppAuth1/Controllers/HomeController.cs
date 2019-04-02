using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using DomainModel;
using Microsoft.AspNetCore.Mvc;
using WebAppAuth1.Models;

namespace WebAppAuth1.Controllers
{
    public class HomeController : Controller
    {
        IRepo _repo;

        public HomeController(IRepo repo)
        {
            _repo = repo;
        }

        public IActionResult Index()
        {
            
            var s = _repo.GetService();

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
