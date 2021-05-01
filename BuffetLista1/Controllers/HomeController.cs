using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BuffetLista1.Models;

namespace BuffetLista1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        //public IActionResult Login() 
        //{
        //    return View();
        //}
        //public IActionResult Cadastro() 
        //{
        //    return View();
        //}
        public IActionResult Recovery() 
        {
            return View();
        }
        public IActionResult Termos() 
        {
            return View();
        }
        public IActionResult Politica() 
        {
            return View();
        }

        
        
    }
}
