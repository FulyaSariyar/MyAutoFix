using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MyAutoFix.Areas.Admin.Controllers
{
    public class ManageController : AdminBaseController
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Users()
        {
            return View();
        }

        [AllowAnonymous]
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Role()
        {
            return View();
        }
        public IActionResult ServiceProducts()
        {
            return View();
        }
        public IActionResult Deneme()
        {
            return View();
        }
    }
}
