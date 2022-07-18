
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
using prjiHealth.Models;
using System.Text.Json;
using System.IO;
using Microsoft.Extensions.Hosting;

namespace prjIHealth.Controllers
{
    public class MemberController : Controller
    {
        utilities ul = new utilities();
        public static TMember loginUser = null; 
        public static string userName = "登入";
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
        public IActionResult Login(CLoginViewModel vModel,string ReturnUrl)
        {
            var q = _context.TMembers.FirstOrDefault(tm => tm.FUserName == vModel.fUserName);
            if (q != null)
            {
                if (q.FPassword == vModel.fPassword)
                {
                    string loginSession = JsonSerializer.Serialize(q);
                    HttpContext.Session.SetString(CDictionary.SK_Logined_User, loginSession);
                    loginUser = JsonSerializer.Deserialize<TMember>(loginSession);
                    userName = $"{loginUser.FUserName}";
                    if (!string.IsNullOrEmpty(ReturnUrl))
                    { return LocalRedirect(ReturnUrl); }
                   return RedirectToAction( "會員專區ViewDemo","Home" );
                }
            }
            return View();
        }
        public IActionResult Logout()
        {
            HttpContext.Session.Remove(CDictionary.SK_Logined_User);
            userName = "登入";
            return RedirectToAction("Index","Home");
        }
        public IActionResult Edit(int ? id) {
            var memberEdit = HttpContext.Session.GetString(CDictionary.SK_Logined_User);
            loginUser = JsonSerializer.Deserialize<TMember>(memberEdit);
           var q=_context.TMembers.FirstOrDefault(m => m.FMemberId == loginUser.FMemberId);
            return View(q);
        
        }
        //[HttpPost]
        //public IActionResult Edit(CLoginViewModel vModel)
        //{
        //    var memberEdit = HttpContext.Session.GetString(CDictionary.SK_Logined_User);
        //    loginUser = JsonSerializer.Deserialize<TMember>(memberEdit);
        //    var q = _context.TMembers.FirstOrDefault(m=>m.FMemberId == loginUser.FMemberId);
        //    if (q != null)
        //    {
        //        //    if (vModel.photo != null)
        //        //    {
        //        //        string pName = Guid.NewGuid().ToString() + ".jpg";
        //        //        vModel.photo.CopyTo(new FileStream(Environments.WebRootPath + "/Images/" + pName, FileMode.Create));
        //        //        q.FImagePath = pName;
        //        //    }
        //        //    q.FName = cp.FName;
        //        //    q.FCost = cp.FCost;
        //        //    q.FPrice = cp.FPrice;
        //        //    q.FQty = cp.FQty;
        //    }
        //    //db.SaveChanges();
        //    //return RedirectToAction("List");
        //}
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
            return RedirectToAction("Login", "Member");
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
            //var exists = _context.Members.Any(m => m.Name == name);
            //return Content(exists.ToString(), "text/plain");
            //var q = _context.TMembers.Any(m => m.FEmail == vModel.fEmail);
            var q = _context.TMembers.FirstOrDefault(m => m.FEmail == vModel.fEmail);

            if (q != null)
            {
                utilities.sendMail(q.FUserName, q.FEmail);
                return RedirectToRoute(new { controller = "Member", action = "Login" });
            }
            else { return RedirectToRoute(new { controller = "Home", action = "Index" }); }



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


