using BullsAndCows.Web.Models.BindingModels;
using Microsoft.AspNetCore.Mvc;

namespace BullsAndCows.Web.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(UserBindingModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }



            return RedirectToAction(nameof(Login));
        }
        public IActionResult Login()
        {
            return View();
        }
    }
}