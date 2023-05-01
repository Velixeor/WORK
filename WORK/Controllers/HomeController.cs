using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using Npgsql;
using WORK.Models;
using Microsoft.EntityFrameworkCore;
using WORK.Context;

namespace WORK.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _dbContext ;


      
        public HomeController(ILogger<HomeController> logger, ApplicationDbContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        public async Task<IActionResult> Index()
        {
            
            //Interaction_with_the_database test = new Interaction_with_the_database(_dbContext);
            //await test.InsertUserAsync();
            Event e = new Event("Гулять", "Отдых");
            DAY d = new DAY(e);
            return View(d);
        }

        [HttpPost]
        public async Task<IActionResult> Input_Db(string input1, string input2)
        {

            Interaction_with_the_database Db = new Interaction_with_the_database(_dbContext);

            await Db.InsertDbAsync();

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