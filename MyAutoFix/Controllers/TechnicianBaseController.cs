using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MyAutoFix.Controllers
{

    [Authorize(Roles = "Teknisyen")]
    public class TechnicianBaseController : Controller
    {

    }
}
