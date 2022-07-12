using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prjIHealth.Areas.Admin.Controllers
{
    [Area(areaName: "Admin")]
    public class OrderManageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
          public IActionResult order()
        {
            return View();
        }
        public IActionResult orderdetail()
        {
            return View();
        }
        public IActionResult orderedit()
        {
            return View();
        }
        public IActionResult orderdetailedit()
        {
            return View();
        }
    }
}
