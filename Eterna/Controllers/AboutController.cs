using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Eterna.DataAccessLayer;
using Eterna.Models;
using Eterna.ViewModels.AboutVM;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Eterna.Controllers
{
    public class AboutController : Controller
    {
        private readonly AppDbContext _context;
        public AboutController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            List<Client> clients = await _context.Clients.ToListAsync();
            List<Statistic> statistics = await _context.Statistics.ToListAsync();
            List<Testimonial> testimonials = await _context.Testimonials.ToListAsync();
            AboutVM aboutVM = new AboutVM
            {
                Statistics=statistics,
                Clients=clients,
                Testimonials=testimonials

            };

            return View(aboutVM);
        }
    }
}

