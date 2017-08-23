using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using webIntro_dotnet.Models;

namespace webIntro_dotnet.Controllers
{
    public class SubscribeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string subscribe, string email)
        {
            Console.WriteLine("got submit " + subscribe + " " + email);
            ViewData["Subscribe"] = subscribe;
            ViewData["Email"] = email;
            using (var writer = new StreamWriter(System.IO.File.Open("emails.csv", FileMode.Append)))
            {
                writer.WriteLine($"{subscribe}, {email}");
            }
            
            return View();
        }
    }
}