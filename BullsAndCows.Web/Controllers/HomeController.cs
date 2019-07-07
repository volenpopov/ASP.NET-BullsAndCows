using BullsAndCows.Models;
using BullsAndCows.Services.Contracts;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Threading.Tasks;

namespace BullsAndCows.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUsersService usersService;

        public HomeController(IUsersService usersService)
        {
            this.usersService = usersService;
        }
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Ranking()
        {
            var ranking = await this.usersService.GetTop25Async();

            return View(ranking);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
