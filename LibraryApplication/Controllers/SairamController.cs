﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace LibraryApplication.Controllers
{
    public class SairamController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
