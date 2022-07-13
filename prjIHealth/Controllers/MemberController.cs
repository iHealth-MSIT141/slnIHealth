
using prjIHealth.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using prjiHealth.ViewModels;
using HealthyLifeApp;
using Microsoft.AspNetCore.Http;

namespace prjIHealth.Controllers
{
    public class MemberController : Controller
    {
        utilities ul = new utilities();
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
                    HttpContext.Session.SetString("SK_Logined_User",q.FUserName);

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

            _context.SaveChanges();
            //return RedirectToRoute(new { controller = "Member", action = "Login" });
            return RedirectToAction("Login","member");
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
        public IActionResult ForgotPassword([Bind("fEmail")]CLoginViewModel vModel)
        {
            var q = _context.TMembers.FirstOrDefault(m => m.FEmail == vModel.fEmail);
            if (q != null)
            {
                utilities.sendMail(q.FUserName, q.FEmail);
                return RedirectToRoute(new { controller = "Member", action = "Login" });
            }
            else { return RedirectToRoute(new { controller = "Home", action = "一般ViewDemo" }); }



            //labForgotPWD.BackColor = Color.AliceBlue;
            //if (string.IsNullOrEmpty(txtAccountName.Text)) { MessageBox.Show("請輸入使用者名稱!"); labForgotPWD.BackColor = Color.Transparent; }
            //var q = this.dbContext.Members.AsEnumerable().Where(m => m.AccountName == txtAccountName.Text).FirstOrDefault();
            //if (q != null)
            //{
            //    if (string.IsNullOrEmpty(q.Email))
            //    {
            //        MessageBox.Show("電子信箱錯誤或註冊時未輸入電子信箱地址 !");
            //        return;
            //    }
            //    else
            //    {
            //        q.Password = utilities.getCryptPWD(txtAccountName.Text, txtAccountName.Text, q.Birthday.ToString());
            //        dbContext.SaveChanges();
            //        utilities.sendMail(txtAccountName.Text, q.Email);
            //        MessageBox.Show($"{txtAccountName.Text}, 您密碼已重設成功, 敬請到您的註冊信箱收取,使用新的密碼登入後, 並修改您的密碼,以確保資安!!");
            //        labForgotPWD.BackColor = Color.Transparent;
            //    }
            //}
        }
    }
}


