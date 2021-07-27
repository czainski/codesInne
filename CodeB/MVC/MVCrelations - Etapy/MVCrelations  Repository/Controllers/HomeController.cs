using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCrelations.Context;
using MVCrelations.Models;
using MVCrelations.Repository;

namespace MVCrelations.Controllers
{
    public class HomeController : Controller
    {
        Repository<Country> _repositoryCountry;
              
        public HomeController(UnitOfWork unitOfWork) =>
            
            _repositoryCountry = unitOfWork.CountryRepository();

        public async Task<IActionResult> Index() =>
        
             View(await _repositoryCountry.Select(includes: "Citys"));

                      
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
