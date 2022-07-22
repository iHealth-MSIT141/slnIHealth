using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using prjiHealth.Models;
using prjIHealth.Controllers;
using prjIHealth.Models;
using prjIHealth.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
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
            //取得登入者ID
            int theMemberId = 8; //TODO:改為演示用教練MemberID
            if (HttpContext.Session.Keys.Contains(CDictionary.SK_Logined_User))
            {
                string json = HttpContext.Session.GetString(CDictionary.SK_Logined_User);
                theMemberId = (JsonSerializer.Deserialize<TMember>(json)).FMemberId;
            }
            else
            {
                MemberController.loginUser = null;
                MemberController.userName = "登入";
            }

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
        } //教練專區-招生紀錄
        public IActionResult changeContactStatus(TCoachContact contact)
        {
            db.TCoachContacts.FirstOrDefault(c => c.FCoachContactId == contact.FCoachContactId).FStatusNumber = contact.FStatusNumber;
            db.SaveChanges();
            return Content("");
        } //教練專區-招生紀錄:改變聯繫狀態
        public IActionResult showMember(int? memberId)
        {
            CContactViewModel member = new CContactViewModel(db)
            {
                FMemberId = memberId
            };

            return Json(member);
        } //教練專區-招生紀錄:顯示學員資料
        public IActionResult createCourse(TCourse course)
        {
            //加入課程
            course.FStatusNumber = 55;
            course.FVisible = true;
            db.TCourses.Add(course);

            //改變聯繫狀態
            db.TCoachContacts.FirstOrDefault(c => c.FCoachContactId == course.FCoachContactId).FStatusNumber = 52;

            db.SaveChanges(); 

            //計算排課起始日
            int day = 0;
            switch (DateTime.Now.DayOfWeek.ToString())
            {
                case "Monday":
                    day = 1;
                    break;
                case "Tuesday":
                    day = 2;
                    break;
                case "Wednesday":
                    day = 3;
                    break;
                case "Thursday":
                    day = 4;
                    break;
                case "Friday":
                    day = 5;
                    break;
                case "Saturday":
                    day = 6;
                    break;
                case "Sunday":
                    day = 7;
                    break;
            }
            int courseDay = int.Parse(course.FAvailableTimeNum.ToString().Substring(0, 1));
            DateTime date;
            if ((courseDay - day) > 0)
            {
                int interval = 7 - (courseDay - day);
                date = DateTime.Now.AddDays(interval);
            }
            else
            {
                int interval = 7 - (day - courseDay);
                date = DateTime.Now.AddDays(interval);
            }
            //計算上課時間
            string courseTime = course.FAvailableTimeNum.ToString().Substring(1, course.FAvailableTimeNum.ToString().Length - 1);
            if (courseTime.Length < 2)
                courseTime = $"0{courseTime}00";
            else
                courseTime = $"{courseTime}00";

            //加入排課
            for(int i = 0; i < course.FCourseTotal; i++)
            {
                TReservation reservation = new TReservation()
                {
                    FCourseId=course.FCourseId,
                    FCourseTime=date.ToString("yyyyMMdd")+courseTime,
                    FStatusNumber=60
                };
                db.TReservations.Add(reservation);
                date = date.AddDays(7);
            }
            db.SaveChanges();

            return Content("");
        } //教練專區-招生紀錄:新增課程&排課
        public IActionResult loadContact(int? flag, int? statusNum)    //教練專區-招生紀錄:依聯繫時間排序
        {
            //取得登入者ID
            int theCoachMemberId = 8; //TODO:改為演示用教練MemberID
            if (HttpContext.Session.Keys.Contains(CDictionary.SK_Logined_User))
            {
                string json = HttpContext.Session.GetString(CDictionary.SK_Logined_User);
                theCoachMemberId = (JsonSerializer.Deserialize<TMember>(json)).FMemberId;
            }

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
