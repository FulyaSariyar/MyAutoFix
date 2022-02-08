using Microsoft.AspNetCore.Mvc;

namespace MyAutoFix.Controllers
{
    public class TechnicianManageController : TechnicianBaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
