using Microsoft.AspNetCore.Mvc;
using prjiHealth.ViewModels;
using prjIHealth.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prjIHealth.Areas.Admin.Controllers
{
    [Area(areaName: "Admin")]
    public class ReplyController : Controller
    {
        public IActionResult ProblemReplyList()
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
                               Status = t.FStatusNumberNavigation
                           }).ToList();
            return View(datafix);
        }
        public IActionResult Reply(int? id)
        {
            IHealthContext db = new IHealthContext();
            var prob = (from t in db.TProblems
                        join p in db.TProblemCategroies
                        on t.FProblemCategoryId equals p.FProblemCategoryId
                        join s in db.TStatuses
                        on t.FStatusNumber equals s.FStatusNumber
                        where t.FProblemId == id
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
                            Status = t.FStatusNumberNavigation
                        }).ToList();
            if (prob == null)
            {
                return RedirectToAction("ProblemReplyList");
            }
            return View(prob);
        }
        [HttpPost]
        public IActionResult Reply(CProblemViewModel p)
        {
            DateTime date = DateTime.Now;
            ViewBag.Time = date.ToString("yyyy/MM/dd HH:mm:ss");
            //if (p.FStatusNumber <= 0 || p.FStatusNumber > 82)
            //{
            //    ViewBag.Message_SN = "Please select status";
            //}
            //else if (string.IsNullOrEmpty(p.FReplyType))
            //{
            //    ViewBag.Message_PC = "Please enter Replytype";
            ////}
            //else
            //{
            IHealthContext db = new IHealthContext();
            TProblem prob =db.TProblems.FirstOrDefault(t => t.FProblemId == p.FProblemId);
            prob.FStatusNumber = p.FStatusNumber;
            TReply reply = new TReply();
            reply.FProblemId = p.FProblemId;
            reply.FReplyTime = p.FReplyTime;
            reply.FReplyContent = p.FReplyContent;
            reply.FReplierId = p.FReplierId;
            reply.FReplyType = p.FReplyType;
            db.TReplies.Add(reply);
            
            db.SaveChanges();
            //ViewBag.Message_SUCCESS = "Reply Success";
            //}
            return RedirectToAction("ProblemReplyList");
        }
    }
}
