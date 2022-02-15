using Microsoft.AspNetCore.Mvc;
using MyAutoFix.Models.Entities;
using System.Threading.Tasks;

namespace MyAutoFix.Controllers
{
    public class CustomerManageController : CustomerBaseController
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult FailureLogging()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> FailureLogging(string lat, string lng, FailureLogging model)
        {
            if (!ModelState.IsValid)
            {
                return Ok(model);
            }
            return Ok(model);
        }
    }
}
