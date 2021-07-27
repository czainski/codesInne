using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCrelations.Context;
using MVCrelations.Models;

namespace MVCrelations.Controllers
{
    public class HomeController : Controller
    {
        private Db _context;
        public HomeController(Db context) => _context = context;
        
        public IActionResult Index()
        {
            long i = 1;
            Country entity = _context.Countrys.Find(i);
            if (entity == null)
                entity = new Country();

            List<City> Citys = _context.Entry(entity)
                            .Collection(e => e.Citys)
                            .Query().ToList();
            entity.Citys = Citys;
            return View(entity);
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
