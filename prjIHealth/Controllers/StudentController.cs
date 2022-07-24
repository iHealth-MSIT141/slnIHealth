using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using prjiHealth.Models;
using prjiHealth.ViewModels;
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
    public class StudentController : Controller
    {
        private IHealthContext db;
        private readonly IHealthContext _context;
        public StudentController(IHealthContext context)
        {
            db = context;
            _context = context;
        }
       
        //教練專區主頁
        public IActionResult CoachMainPage()
        {
            return View();
        }
        //教練列表
        public IActionResult CoachList(CKeywordViewModel v)
        {
            IEnumerable<TCoach> datas = null;
            if (!String.IsNullOrEmpty(v.txtKeyword))
            {
                datas = _context.TCoaches
                    .Include(c => c.FMember)
                    .Include(c => c.FCity)
                    .Include(c => c.TCoachSkills).ThenInclude(cs => cs.FSkill)
                    .Include(c => c.TCoachExperiences)
                    .Include(c => c.TCoachLicenses).AsEnumerable()
                    .Where(c => c.FVisible == true &&
                    c.FCoachName.Contains(v.txtKeyword) || c.FCoachDescription.Contains(v.txtKeyword) || c.FSlogan.Contains(v.txtKeyword) ||
                        c.TCoachExperiences.Any(ce => ce.FExperience.Contains(v.txtKeyword)) || c.TCoachLicenses.Any(ce => ce.FLicense.Contains(v.txtKeyword)));
            }
            else
                datas = _context.TCoaches
                    .Include(c => c.FMember)
                    .Include(c => c.FCity)
                    .Include(c => c.TCoachSkills).ThenInclude(cs => cs.FSkill).AsEnumerable()
                    .Where(c => c.FVisible == true);

            var coaches = CCoachViewModel.CoachList(datas.ToList());
            return View(coaches);
        }

        //多重篩選
        [HttpPost]
        public IActionResult CoachList(int? FCityId, string[] fGender, int[] fCoachSkill, int[] fCoachTime)
        {
            var datas = _context.TCoaches
                .Include(c => c.FMember)
                .Include(c => c.FCity)
                .Include(c => c.TCoachSkills).ThenInclude(cs => cs.FSkill)
                .Include(c => c.TCoachAvailableTimes).AsEnumerable()
                .Where(c => c.FVisible == true &&
                        (FCityId != null ? c.FCityId == FCityId : true) &&
                        (fGender.Length != 0 ? fGender.Contains(c.FMember.FGender.ToString()) : true) &&
                        (fCoachSkill.Length != 0 ? c.TCoachSkills.Select(cs => (int)cs.FSkillId).ToArray<int>().Intersect<int>(fCoachSkill).Count() > 0 : true) &&
                        (fCoachTime.Length != 0 ? c.TCoachAvailableTimes.Select(at => (int)at.FAvailableTimeId).ToArray<int>().Intersect<int>(fCoachTime).Count() > 0 : true));

            var coaches = CCoachViewModel.CoachList(datas.ToList());
            return View(coaches);
        }

        //教練詳細資料
        public IActionResult ViewCoachDetails(int? id)
        {
            TCoach coach = _context.TCoaches.FirstOrDefault(c => c.FCoachId == id);
            if (coach == null)
                return RedirectToAction("CoachList");

            var data = _context.TCoaches
                .Include(c => c.FCity)
                .Include(c => c.TCoachSkills).ThenInclude(cs => cs.FSkill)
                .Include(c => c.TCoachAvailableTimes).ThenInclude(t => t.FAvailableTime)
                .Include(c => c.TCoachExperiences)
                .Include(c => c.TCoachLicenses).AsEnumerable()
                .Where(c => c.FVisible == true && c.FCoachId == id).FirstOrDefault();

            CCoachViewModel vModel = new CCoachViewModel
            {
                Coach = data
            };
            return View(vModel);
        }
        //取得教練評價
        public IActionResult GetCoachRate(int id)
        {
            var data = from cr in _context.TCoachRates
                       where cr.FCoachId == id && cr.FVisible == true
                       select new { cr, cr.FMember.FMemberName };
            return Json(data);
        }
        //取得教練評價-按最新排序
        public IActionResult GetNewRate(int id)
        {
            var data = from cr in _context.TCoachRates
                       where cr.FCoachId == id && cr.FVisible == true
                       orderby cr.FRateDate descending
                       select new { cr, cr.FMember.FMemberName };
            return Json(data);
        }
        //取得教練評價-按高至低排序
        public IActionResult GetDesRate(int id)
        {
            var data = from cr in _context.TCoachRates
                       where cr.FCoachId == id && cr.FVisible == true
                       orderby cr.FRateStar descending
                       select new { cr, cr.FMember.FMemberName };
            return Json(data);
        }
        //取得教練評價-按低至高排序
        public IActionResult GetAscRate(int id)
        {
            var data = from cr in _context.TCoachRates
                       where cr.FCoachId == id && cr.FVisible == true
                       orderby cr.FRateStar ascending
                       select new { cr, cr.FMember.FMemberName };
            return Json(data);
        }
        //取得推薦教練*5
        public IActionResult GetRecCoach(int id)
        {
            var cityId = _context.TCoaches.FirstOrDefault(c => c.FCoachId == id).FCityId;
            var skills = _context.TCoachSkills.Where(cs => cs.FCoachId == id).Select(cs => cs.FSkillId).ToArray();
            var datas = _context.TCoaches
                .Include(c => c.FMember)
                .Include(c => c.FCity)
                .Include(c => c.TCoachSkills).ThenInclude(cs => cs.FSkill).AsEnumerable()
                .Where(c => c.FVisible == true && c.FCityId == cityId && c.FCoachId != id &&
                (c.TCoachSkills.Select(cs => cs.FSkillId).ToArray().Intersect(skills)).Count() > 0)
                .OrderBy(c => Guid.NewGuid()).Take(5);

            var coaches = CCoachViewModel.CoachList(datas.ToList());
            return Json(coaches);
        }
        //取得推薦教練專長
        public IActionResult GetSkillName(int id)
        {
            var data = _context.TCoachSkills.Include(cs => cs.FSkill).Where(cs => cs.FCoachId == id).Select(cs => cs.FSkill.FSkillName).ToArray();
            return Json(data);
        }
        
        //教練預約時間表-可預約
        public IActionResult getAvailableTimeId(int? id)
        {
            var ids = db.TCoachAvailableTimes.Where(ca => ca.FCoachId == id).Select(ca=>ca.FAvailableTimeId).Distinct();
            return Json(ids);
        }
        //教練預約時間表-已額滿
        public IActionResult getAvailableTimeNum(int? id)
        {
            var nums = db.TCourses.Where(c=>c.FCoachContact.FCoachId==id).Select(c=>c.FAvailableTimeNum).Distinct();
            return Json(nums);
        }
        //通知教練
        public IActionResult createContact(TCoachContact coachContact)
        {
            //取得登入者ID
            int userId = 8; //備用帳號
            if (HttpContext.Session.Keys.Contains(CDictionary.SK_Logined_User))
            {
                string json = HttpContext.Session.GetString(CDictionary.SK_Logined_User);
                userId = (JsonSerializer.Deserialize<TMember>(json)).FMemberId;
            }
            else
            {
                MemberController.loginUser = null;
                MemberController.userName = "登入";
            }
            coachContact.FMemberId = userId;
            coachContact.FContactDate = DateTime.Now.ToString("yyyyMMddHHmmss");
            coachContact.FStatusNumber = 50;
            db.TCoachContacts.Add(coachContact);
            db.SaveChanges();
            return Content("");
        }

        //通知教練
        public IActionResult addCandidate(TCandidate candidate)
        {
            //取得登入者ID
            int userId = 8; //備用帳號
            if (HttpContext.Session.Keys.Contains(CDictionary.SK_Logined_User))
            {
                string json = HttpContext.Session.GetString(CDictionary.SK_Logined_User);
                userId = (JsonSerializer.Deserialize<TMember>(json)).FMemberId;
            }
            else
            {
                MemberController.loginUser = null;
                MemberController.userName = "登入";
            }
            candidate.FMemberId = userId;
            if (db.TCandidates.Any(c => c.FCoachId == candidate.FCoachId && c.FMemberId == candidate.FMemberId))
            {
                return Content("repeat");
            }
            else
            {
                db.TCandidates.Add(candidate);
                db.SaveChanges();
                return Content("ok");
            }
        }

        //會員專區--課程列表=========================================================
        public IActionResult CourseList()   
        {
            //取得登入者ID
            int theMemberId = 8; 
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
        //會員專區--課程列表:儲存評價教練
        public IActionResult createRate(TCoachRate rate) 
        {
            //取得登入者ID
            int theMemberId = 8;
            if (HttpContext.Session.Keys.Contains(CDictionary.SK_Logined_User))
            {
                string json = HttpContext.Session.GetString(CDictionary.SK_Logined_User);
                theMemberId = (JsonSerializer.Deserialize<TMember>(json)).FMemberId;
            }

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
        //會員專區--課程列表:顯示評價教練
        public IActionResult viewRate(int? theCoachId)
        {
            //取得登入者ID
            int theMemberId = 8;
            if (HttpContext.Session.Keys.Contains(CDictionary.SK_Logined_User))
            {
                string json = HttpContext.Session.GetString(CDictionary.SK_Logined_User);
                theMemberId = (JsonSerializer.Deserialize<TMember>(json)).FMemberId;
            }

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
        

        //會員專區--候選教練=========================================================
        public IActionResult CandidateList()    
        {
            //取得登入者ID
            int theMemberId = 8;
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
        //會員專區--候選教練:移除候選教練
        public IActionResult delCandidate(int? id)    
        {
            var theCandidate = db.TCandidates.FirstOrDefault(c => c.FCandidateId == id);
            db.TCandidates.Remove(theCandidate);
            db.SaveChanges();
            return Content("");
        }
        //會員專區--候選教練:依聯繫時間排序
        public IActionResult loadContact(int? flag,int? statusNum)    
        {
            //取得登入者ID
            int theMemberId = 8;
            if (HttpContext.Session.Keys.Contains(CDictionary.SK_Logined_User))
            {
                string json = HttpContext.Session.GetString(CDictionary.SK_Logined_User);
                theMemberId = (JsonSerializer.Deserialize<TMember>(json)).FMemberId;
            }

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
        //會員專區--候選教練:顯示訊息
        public IActionResult loadChatText(int? id)
        {
            var tContactTexts = db.TContactTexts.Where(t => t.FCoachContactId == id).OrderBy(t => t.FContactTextTime);
            List<CContactTextViewModel> texts = new List<CContactTextViewModel>();
            if (tContactTexts.Count() != 0)
            {
                foreach (var t in tContactTexts)
                {
                    CContactTextViewModel contactTextViewModel = new CContactTextViewModel(db);
                    contactTextViewModel.TcontactText = t;
                    texts.Add(contactTextViewModel);
                }
            }
            return Json(texts);
        }
        //會員專區--候選教練:傳送訊息
        public IActionResult saveText(TContactText contactText)
        {
            contactText.FContactTextTime = DateTime.Now.ToString("yyyyMMddHHmm");
            contactText.FIsCoach = false;
            db.TContactTexts.Add(contactText);
            db.SaveChanges();
            return Content("");
        }


        int userId = 11;    //TODO 取得登入MemberId
        public IActionResult ViewCourseCalendar()   //課程行事曆
        {
            return View();
        }
        //取得會員所有排課
        public IActionResult GetAllReservation()
        {
            var memId = _context.TMembers.FirstOrDefault(m => m.FMemberId == userId).FMemberId;
            var reservations = _context.TReservations
                .Include(r => r.FCourse).ThenInclude(c => c.FCoachContact).ThenInclude(c => c.FCoach)
                .Where(r => r.FCourse.FCoachContact.FMemberId == memId).OrderBy(r => r.FCourseTime).ToList();

            var reservationList = CCalendarViewModel.ReservationList(reservations);
            return Json(reservationList);
        }
        //取得所有有上課的CoachId
        public IActionResult GetReservationCoachId()
        {
            var memId = _context.TMembers.FirstOrDefault(m => m.FMemberId == userId).FMemberId;
            var coachIdList = _context.TReservations
                .Include(r => r.FCourse).ThenInclude(c => c.FCoachContact).ThenInclude(c => c.FCoach)
                .Where(r => r.FCourse.FCoachContact.FMemberId == memId)
                .Select(r => r.FCourse.FCoachContact.FCoachId).Distinct().ToList();
            return Json(coachIdList);
        }

    }
}
