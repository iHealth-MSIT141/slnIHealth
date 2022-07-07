using Microsoft.AspNetCore.Mvc;
using prjiHealth.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prjiHealth.Controllers
{
    public class BodyController : Controller
    {
        public IActionResult BodyCalculatorMain()
        {
            return View();
        }
        public IActionResult BMICalculator()
        {
            return View();
        }
        //[HttpPost]
        //public IActionResult BMICalculator(CBodyRecordViewModel body)
        //{
        //    return View(body);
        //}
        public IActionResult TDEECalculator()
        {
            return View();
        }
    }
}
