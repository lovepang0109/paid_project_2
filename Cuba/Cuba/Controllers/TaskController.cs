﻿using Microsoft.AspNetCore.Mvc;

namespace Cuba.Controllers
{
    public class TaskController : Controller
    {
        public IActionResult Task()
        {
            return View();
        }
    }
}
