using Front_Back.Data;
using Front_Back.Models;
using Front_Back.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Front_Back.Controllers
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
            List<Slider> sliders = _context.Sliders.ToList();
            List<Image> images = _context.Images.ToList();

            HomeVM model = new HomeVM
            {
                Sliders = sliders,
                Images = images
            };

            return View(model);
        }       
    }
}
