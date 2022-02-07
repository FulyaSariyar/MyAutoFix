﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MyAutoFix.Areas.Admin.Controllers
{
    public class ManageController:Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult User()
        {
            return View();
        }

        [AllowAnonymous]
        public IActionResult Login()
        {
            return View();
        }
    }
}
