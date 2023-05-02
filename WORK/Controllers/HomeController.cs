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
            List<DAY> T=new List<DAY>();
            T.Add(d);
            for(int i = 0; i < 29; i++)
            {
                DAY t = new DAY();
                T.Add(t);
            }
            return View(T);
        }

        [HttpPost]
        public async Task<IActionResult> Input_Db(string nameDay, string nameMonth, string categori, string nameEvent, int DayNumber)
        {

            Interaction_with_the_database Db = new Interaction_with_the_database(_dbContext);

            await Db.InsertDbAsync(nameDay,  nameMonth,  categori, nameEvent, DayNumber);

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