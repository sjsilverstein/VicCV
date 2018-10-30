using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VicCV.Models;

namespace VicCV.Controllers
{
    public class HomeController : Controller
    {
        //Root
        [HttpGet]
        [Route("")]
        public IActionResult Index(){
            return View("Index");
        }   
    }
}
