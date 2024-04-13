using HK.AdminPanel.WebUI.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace HK.AdminPanel.WebUI.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginRequest loginRequest)
        {
            return View(loginRequest);
        }
    }
}
