using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CateringLarissa2.Data;
using CateringLarissa2.Models;

namespace CateringLarissa2.Controllers
{
    public class Dashboard : Controller
    {

        private readonly ApplicationDbContext _context;

        public Dashboard(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Review(String SearchString)
        {
            return View(await _context.Review.ToListAsync());
        }

        public IActionResult Account()
        {
            return View();
        }

        public async Task<IActionResult> Menu(String SearchString)
        {
            return View(await _context.Menu.ToListAsync());
        }
    }
}
