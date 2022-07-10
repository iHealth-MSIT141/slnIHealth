using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using prjiHealth.Models;
using prjiHealth.ViewModels;
using prjIHealth.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace prjiHealth.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IHealthContext _context;
        public HomeController(ILogger<HomeController> logger, IHealthContext context)
        {
            _logger = logger;
            _context = context;
        }
   
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(CLoginViewModel vModel)
        {
            var q = _context.TMembers.FirstOrDefault(tm => tm.FUserName == vModel.fUserName);
            if (q != null)
            {
                if (q.FPassword == vModel.fPassword)
                {
                    return RedirectToRoute(new { controller = "Home", action = "會員專區ViewDemo" });
                }
            }
            return View();
        }

        public IActionResult 一般ViewDemo()
        {
            return View();
        }
        public IActionResult 會員專區ViewDemo()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
