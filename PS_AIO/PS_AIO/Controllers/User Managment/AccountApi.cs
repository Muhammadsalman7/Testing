using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PS_AIO.Controllers.User_Managment
{
    public class AccountApi : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
