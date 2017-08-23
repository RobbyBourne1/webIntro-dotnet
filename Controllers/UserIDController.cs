using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using webIntro_dotnet.Models;

namespace webIntro_dotnet.Controllers
{
    public class UserIDController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public string Index(int ID)
        {
            return $"Hi User {ID}";
        }
    }
}