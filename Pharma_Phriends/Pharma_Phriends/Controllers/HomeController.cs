using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Pharma_Phriends.Data;
using Pharma_Phriends.Models;
using Pharma_Phriends.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Pharma_Phriends.Controllers
{
    public class HomeController : Controller
    {
        readonly ApplicationDbContext context;

        public HomeController(ApplicationDbContext dbContext)
        {
            context = dbContext;
        }
        DbSet<RxDrug> RxDrugs { get; set; }

        public IActionResult Detail()
        {
            
                var drugInfo = context.RxDrugs.ToList();
                return View(drugInfo);
                
           
        }
    

       

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Contact()
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
