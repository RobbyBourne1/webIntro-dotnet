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
        [Route("/userid/{id}")]
        public IActionResult Index()
        {
            return View();
        }

        // public string UserID(int ID)
        // {
        //     return $"Hi User {ID}";
        // }
    }
}