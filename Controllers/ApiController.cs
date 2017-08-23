using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using webIntro_dotnet.Models;

namespace webIntro_dotnet.Controllers
{
    public class ApiController : Controller
    {

        // [Route("/Api")]
        public IActionResult Index()
        {
            var person = new ApiModel
            {
                Name = "Robby",
                HeightInch = 70,
                Motto = "YOLO"
            };

            return Json(person); 
        }

        // public IActionResult ApiModel()
        // {
        //     return Json(new ApiModel() { Name = "Robby", HeightInch = 70, Motto = "YOLO"});
        // }
    }
}