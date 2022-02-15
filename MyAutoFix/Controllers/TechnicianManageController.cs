using Microsoft.AspNetCore.Mvc;

namespace MyAutoFix.Controllers
{
    public class TechnicianManageController : TechnicianBaseController
    {
        public IActionResult ServiceProduct()
        {
            return View();
        }
    }
}
