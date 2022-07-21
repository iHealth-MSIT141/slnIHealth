using Microsoft.AspNetCore.Mvc;
using prjIHealth.Models;
using prjIHealth.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prjiHealth.Controllers
{
    public class StudentController : Controller
    {
        private IHealthContext db;
        public StudentController(IHealthContext context)
        {
            db = context;
        }

        public IActionResult CoachMainPage()    //教練專區主頁
        {
            return View();
        }
        public IActionResult CoachList()    //教練列表
        {
            return View();
        }
        public IActionResult ViewCoachDetails()     //教練詳細資料
        {
            return View();
        }                      
        public IActionResult CourseList()   //會員專區--課程列表
        {
            //TODO抓登入會員ID
            int theMemberId = 8;

            //var contacts = db.TCoachContacts.Where(c => c.FMemberId == theMemberId);
            //List<TCourse> tcourses = new List<TCourse>();
            //foreach (var con in contacts)
            //{
            //    var tcourse = db.TCourses.FirstOrDefault(c => c.FCoachContactId == con.FCoachContactId);
            //    if(tcourse!=null)
            //        tcourses.Add(tcourse);
            //}

            var tcourses = db.TCourses.Where(c => c.FCoachContact.FMemberId == theMemberId && c.FVisible == true);

            List<CCourseListViewModel> courseList = new List<CCourseListViewModel>();
            foreach(var c in tcourses)
            {
                CCourseListViewModel course = new CCourseListViewModel(db)
                {
                    FCourseId = c.FCourseId,
                    FCoachContactId = c.FCoachContactId,
                    FCourseName = c.FCourseName,
                    FCourseTotal = c.FCourseTotal,
                    FStatusNumber = c.FStatusNumber,
                    FAvailableTimeNum=c.FAvailableTimeNum
                };
                courseList.Add(course);
            }
            return View(courseList);
        }               
        public IActionResult createRate(TCoachRate rate) //會員專區--課程列表:儲存評價教練
        {
            //TODO抓登入會員ID
            int theMemberId = 8;

            var theRate = db.TCoachRates.Where(r => r.FCoachId == rate.FCoachId && r.FMemberId == theMemberId);
            if (theRate.Count() > 0)
            {
                theRate.First().FRateStar = rate.FRateStar;
                theRate.First().FRateText = rate.FRateText;
                theRate.First().FRateDate = DateTime.Now.ToString("d");
                theRate.First().FVisible = true;
                db.SaveChanges();
            }
            else
            {
                rate.FMemberId = theMemberId;
                rate.FRateDate = DateTime.Now.ToString("yyyyMMdd");
                rate.FVisible = true;
                db.TCoachRates.Add(rate);
                db.SaveChanges();
            }
            return Content("");
        }      
        public IActionResult viewRate(int? theCoachId)//會員專區--課程列表:顯示評價教練
        {
            //TODO抓登入會員ID
            int theMemberId = 8;

            var rate = db.TCoachRates.Where(r => r.FCoachId == theCoachId && r.FMemberId == theMemberId);
            if (rate.Count() > 0)
            {
                return Json(rate.First());
            }
            else
            {
                return Json(null);
            }
        }
        public IActionResult CandidateList()    //會員專區--候選教練
        {
            //TODO抓登入會員ID
            int theMemberId = 8;

            //載入候選教練
            var candidates = db.TCandidates.Where(c => c.FMemberId == theMemberId);
            List<CCandidateViewModel> candidateViewModels = new List<CCandidateViewModel>();
            foreach (var c in candidates)
            {
                CCandidateViewModel candidateViewModel = new CCandidateViewModel(db)
                {
                    FCandidateId = c.FCandidateId,
                    FCoachId = (int)(c.FCoachId)
                };
                candidateViewModels.Add(candidateViewModel);
            }

            //載入聯繫紀錄
            var contacts = db.TCoachContacts.Where(c => c.FMemberId == theMemberId);
            List<CContactViewModel> contactViewModels = new List<CContactViewModel>();
            foreach(var c in contacts)
            {
                CContactViewModel contactViewModel = new CContactViewModel(db)
                {
                    FCoachContactId = c.FCoachContactId,
                    FCoachId = c.FCoachId,
                    FStatusNumber = c.FStatusNumber,
                    FAvailableTimeNum = c.FAvailableTimeNum
                };
                contactViewModels.Add(contactViewModel);
            }

            CCandidateListViewModel candidateListViewModel = new CCandidateListViewModel()
            {
                CandidateViewModels = candidateViewModels,
                ContactViewModels = contactViewModels
            };
            return View(candidateListViewModel);
        }
        public IActionResult delCandidate(int? id)    //會員專區--候選教練:移除候選教練
        {
            var theCandidate = db.TCandidates.FirstOrDefault(c => c.FCandidateId == id);
            db.TCandidates.Remove(theCandidate);
            db.SaveChanges();
            return Content("");
        }
        public IActionResult loadContact(int? flag,int? statusNum)    //會員專區--候選教練:依聯繫時間排序
        {
            //TODO抓登入會員ID
            int theMemberId = 8;

            IEnumerable<TCoachContact> contacts = null;
            if (statusNum == 0)
            {
                if (flag == 1)
                {
                    contacts = db.TCoachContacts.Where(c => c.FMemberId == theMemberId).OrderByDescending(c => c.FContactDate);
                }
                else
                {
                    contacts = db.TCoachContacts.Where(c => c.FMemberId == theMemberId).OrderBy(c => c.FContactDate);
                }
            }
            else
            {
                if (flag == 1)
                {
                    contacts = db.TCoachContacts.Where(c => c.FMemberId == theMemberId && c.FStatusNumber == statusNum).OrderByDescending(c => c.FContactDate);
                }
                else
                {
                    contacts = db.TCoachContacts.Where(c => c.FMemberId == theMemberId && c.FStatusNumber == statusNum).OrderBy(c => c.FContactDate);
                }
            }
            List<CContactViewModel> contactViewModels = new List<CContactViewModel>();
            foreach (var c in contacts)
            {
                CContactViewModel contactViewModel = new CContactViewModel(db)
                {
                    FCoachContactId = c.FCoachContactId,
                    FCoachId = c.FCoachId,
                    FStatusNumber = c.FStatusNumber,
                    FAvailableTimeNum=c.FAvailableTimeNum
                };
                contactViewModels.Add(contactViewModel);
            }
            return Json(contactViewModels);
        }


        public IActionResult ViewCourseCalendar()   //課程行事曆
        {
            return View();
        }       
    }
}
