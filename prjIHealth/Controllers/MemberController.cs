
using prjIHealth.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using prjiHealth.ViewModels;

namespace prjIHealth.Controllers
{
    public class MemberController : Controller
    {
        private readonly IHealthContext _context;


        public MemberController(IHealthContext context)
        {
            _context = context;
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
        public IActionResult Edit(int ? id) {
          
            return View();
        
        }
        //[HttpPost]
        //public IActionResult Edit(){ }
        // GET: Member
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(TMember tm)
        {
            _context.TMembers.Add(tm);
            _context.SaveChanges(); return RedirectToRoute(new { controller = "Member", action = "Login" });
        }

        public IActionResult ShowTrackList()
        {
            return View();
        }

        public IActionResult Delete(int? id)
        {
            IHealthContext dblIHealth = new IHealthContext();
            TTrackList trackList = dblIHealth.TTrackLists.FirstOrDefault(t => t.FProductId == id);
            if (trackList != null)
            {
                dblIHealth.TTrackLists.Remove(trackList);
                dblIHealth.SaveChanges();
            }
            return RedirectToAction("ShowTrackList");
        }

        public IActionResult OrderList()
        {
            return View();
        }
        public IActionResult OrderdetailList()
        {
            return View();
        }


            
        
        public IActionResult ForgotPassword()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ForgotPassword(CLoginViewModel vModel)
        {
            var q = _context.TMembers.FirstOrDefault(m => m.FEmail == vModel.fEmail);
            if (q != null)
            {
                return RedirectToRoute(new { controller = "Member", action = "Login" });
            }
            else { return RedirectToRoute(new { controller = "Home", action = "一般ViewDemo" }); }
        }
    }
}


