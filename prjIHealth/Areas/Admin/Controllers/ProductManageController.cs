using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prjIHealth.Areas.Admin.Controllers
{
    [Area(areaName: "Admin")]
    public class ProductManageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Product()
        {
            return View();
        }
        public IActionResult Productimg()
        {
            return View();
        }
        public IActionResult Productedit()
        {
            return View();
        }
        public IActionResult Productcreate()
        {
            return View();
        }
    }
}
