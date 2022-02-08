using Microsoft.AspNetCore.Mvc;

namespace MyAutoFix.Controllers
{
    public class CustomerManageController : CustomerBaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
