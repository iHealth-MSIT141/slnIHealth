using Microsoft.AspNetCore.Mvc;
using prjiHealth.ViewModels;
using prjIHealth.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prjiHealth.Controllers
{
    public class ProblemController : Controller
    {
        public IActionResult ReplyProblem()
        {
            DateTime date = DateTime.Now;
            ViewBag.Time = date.ToString("yyyy/MM/dd HH:mm:ss");
            return View();
        }
        [HttpPost]
        public IActionResult ReplyProblem(TProblem p)
        {
            DateTime date = DateTime.Now;
            ViewBag.Time = date.ToString("yyyy/MM/dd HH:mm:ss");
            if (string.IsNullOrEmpty(p.FContactPhone) && string.IsNullOrEmpty(p.FEmail))
            {
                ViewBag.Message_EP = "Please enter EMail or Phone";
            }
            else if (string.IsNullOrEmpty(p.FProblemContent))
            {
                ViewBag.Message_PC = "Please enter ProblemContent";
            }
            else if (p.FProblemCategoryId <= 0 || p.FProblemCategoryId > 6)
            {
                ViewBag.Message_PCID = "Please select ProblemCategory";
            }
            else
            {
                IHealthContext db = new IHealthContext();
                db.TProblems.Add(p);
                db.SaveChanges();
                ViewBag.Message_SUCCESS = "Problem reply Success";
            }

            return View();
        }


        public IActionResult CheckReply()
        {
            IHealthContext db = new IHealthContext();
            var datafix = (from t in db.TProblems
                           join p in db.TProblemCategroies
                           on t.FProblemCategoryId equals p.FProblemCategoryId
                           join s in db.TStatuses
                           on t.FStatusNumber equals s.FStatusNumber
                           select new CProblemViewModel()
                           {
                               FProblemId = t.FProblemId,
                               FProblemTime = t.FProblemTime,
                               FProblemCategory = t.FProblemCategory,
                               FProblemContent = t.FProblemContent,
                               FMemberId = t.FMemberId,
                               FOrderId = t.FOrderId,
                               FEmail = t.FEmail,
                               FContactPhone = t.FContactPhone,
                               Status=t.FStatusNumberNavigation
                           }).ToList();
            return View(datafix);
        }

        public IActionResult LoadReply(int id)
        {
            IHealthContext db = new IHealthContext();
            var data = (from t in db.TReplies
                        where t.FProblemId == id
                        select t.FReplyContent).FirstOrDefault();
            return Json(data);
        }
    }

}
