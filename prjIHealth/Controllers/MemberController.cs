using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prjiHealth.Controllers
{
    public class MemberController : Controller
    {
        public IActionResult OrderList()
        {
            return View();
        }
        public IActionResult OrderdetailList()
        {
            return View();
        }

    }
}
