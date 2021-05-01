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
    public class AdminController : Controller
    {
        private readonly ILogger<AdminController> _logger;

        public AdminController(ILogger<AdminController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Logout()
        {
            return View();
        }
        public IActionResult Painel() 
        {
            return View();
        }
        public IActionResult Secao() 
        {
            return View();
        }
        public IActionResult Ajuda() 
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
