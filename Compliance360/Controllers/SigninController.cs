using Microsoft.AspNetCore.Mvc;

namespace Compliance360.Controllers
{
    public class SigninController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult OTP()
        {
            return View();
        }
    }
}
