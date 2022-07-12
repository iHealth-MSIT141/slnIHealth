using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prjiHealth.Controllers
{
    public class CoachController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult TeachingList()
        {
            return View();
        }        
        public IActionResult ManageResume()
        {
            return View();
        }
        public IActionResult RecruitmentList()
        {
            return View();
        }
    }
}
