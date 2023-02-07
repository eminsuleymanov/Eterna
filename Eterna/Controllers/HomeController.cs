using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Eterna.DataAccessLayer;
using Microsoft.AspNetCore.Mvc;


namespace Eterna.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}

