using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VicCV.Models;
using VicCV.Context;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;

namespace VicCV.Controllers
{
    public class HomeController : Controller
    {
        //Connection to Database
        private VicCVContext _context;
        public HomeController(VicCVContext context){
            _context = context;
        }

        //Root
        [HttpGet]
        [Route("")]
        public IActionResult Index(){
            return View("Index");
        }   
    }
}
