using Microsoft.AspNetCore.Mvc;
using prjIHealth.Models;
using prjIHealth.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prjiHealth.Controllers
{
    public class CoachController : Controller
    {
        private IHealthContext db;
        public CoachController(IHealthContext context)
        {
            db = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult TeachingList()
        {
            return View();
        }        
        public IActionResult ManageResume()
        {
            return View();
        }
        public IActionResult RecruitmentList()
        {
            //TODO 拿登入會員的ID
            int theMemberId = 11;

            var contacts = db.TCoachContacts.Where(c =>c.FCoach.FMemberId==theMemberId);
            List<CContactViewModel> contactViewModels = new List<CContactViewModel>();
            foreach(var c in contacts)
            {
                CContactViewModel contactViewModel = new CContactViewModel(db)
                {
                    FCoachContactId = c.FCoachContactId,
                    FMemberId = c.FMemberId,
                    FStatusNumber = c.FStatusNumber,
                    FAvailableTimeNum = c.FAvailableTimeNum
                };
                contactViewModels.Add(contactViewModel);
            }

            return View(contactViewModels);
        }
        public IActionResult changeContactStatus(TCoachContact contact)
        {
            db.TCoachContacts.FirstOrDefault(c => c.FCoachContactId == contact.FCoachContactId).FStatusNumber = contact.FStatusNumber;
            db.SaveChanges();
            return Content("");
        }

        public IActionResult showMember(int? memberId)
        {
            CContactViewModel member = new CContactViewModel(db)
            {
                FMemberId = memberId
            };

            return Json(member);
        }
        public IActionResult createCourse(TCourse course)
        {
            course.FStatusNumber = 55;
            course.FVisible = true;
            db.TCourses.Add(course);
            db.SaveChanges();

            return Content("");
        }
        public IActionResult loadContact(int? flag, int? statusNum)    //教練專區-招生紀錄:依聯繫時間排序
        {
            //TODO抓登入會員ID
            int theCoachMemberId = 11;

            IEnumerable<TCoachContact> contacts = null;
            if (statusNum == 0)
            {
                if (flag == 1)
                {
                    contacts = db.TCoachContacts.Where(c => c.FCoach.FMemberId == theCoachMemberId).OrderByDescending(c => c.FContactDate);
                }
                else
                {
                    contacts = db.TCoachContacts.Where(c => c.FCoach.FMemberId == theCoachMemberId).OrderBy(c => c.FContactDate);
                }
            }
            else
            {
                if (flag == 1)
                {
                    contacts = db.TCoachContacts.Where(c => c.FCoach.FMemberId == theCoachMemberId && c.FStatusNumber == statusNum).OrderByDescending(c => c.FContactDate);
                }
                else
                {
                    contacts = db.TCoachContacts.Where(c => c.FCoach.FMemberId == theCoachMemberId && c.FStatusNumber == statusNum).OrderBy(c => c.FContactDate);
                }
            }
            List<CContactViewModel> contactViewModels = new List<CContactViewModel>();
            foreach (var c in contacts)
            {
                CContactViewModel contactViewModel = new CContactViewModel(db)
                {
                    FCoachContactId = c.FCoachContactId,
                    FMemberId = c.FMemberId,
                    FStatusNumber = c.FStatusNumber,
                    FAvailableTimeNum = c.FAvailableTimeNum
                };
                contactViewModels.Add(contactViewModel);
            }
            return Json(contactViewModels);
        }



    }
}
