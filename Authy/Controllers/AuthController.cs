using Authy.Models;
using Microsoft.AspNetCore.Mvc;
using Authy.Models;

namespace Authy.Controllers
{
    public class AuthController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            // Дії при успішній валідації
            Console.WriteLine($"Ім'я: {model.FirstName}");
            Console.WriteLine($"Прізвище: {model.LastName}");
            Console.WriteLine($"Email: {model.Email}");
            return RedirectToAction("Success");
        }
 

    }
}
