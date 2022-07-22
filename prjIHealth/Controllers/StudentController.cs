using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using prjIHealth.Models;
using prjIHealth.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using prjiHealth.ViewModels;

namespace prjiHealth.Controllers
{
    public class StudentController : Controller
    {
        private readonly IHealthContext _context;
        public StudentController(IHealthContext context)
        {
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
                datas = from c in _context.TCoaches.Include(c => c.TCoachSkills).Include(c=>c.TCoachExperiences).Include(c => c.TCoachLicenses).AsEnumerable()
                        where c.FVisible==true &&
                        c.FCoachName.Contains(v.txtKeyword) || c.FCoachDescription.Contains(v.txtKeyword) || c.FSlogan.Contains(v.txtKeyword)||
                        c.TCoachExperiences.Any(ce=>ce.FExperience.Contains(v.txtKeyword)) || 
                        c.TCoachLicenses.Any(ce => ce.FLicense.Contains(v.txtKeyword))
                        select c;
            }           
            else
                datas = _context.TCoaches.Include(c => c.TCoachSkills).Where(c => c.FVisible == true);

            List<CCoachViewModel> coaches = new List<CCoachViewModel>();
            foreach (var c in datas)
            {
                CCoachViewModel coach = new CCoachViewModel(_context)
                {
                    _coach = c
                };
                coaches.Add(coach);
            }
            return View(coaches);
        }      
        
        //多重篩選
        [HttpPost]
        public IActionResult CoachList(int? FCityId, string[] fGender, int[] fCoachSkill, int[] fCoachTime)
        {
            var datas = from c in _context.TCoaches.Include(c => c.FMember).Include(c => c.TCoachSkills).Include(c => c.TCoachAvailableTimes).AsEnumerable()
                        where c.FVisible == true &&
                        (FCityId != null ? c.FCityId == FCityId : true) &&
                        (fGender.Length != 0 ? fGender.Contains(c.FMember.FGender.ToString()) : true) &&
                        (fCoachSkill.Length != 0 ? c.TCoachSkills.Select(cs => (int)cs.FSkillId).ToArray<int>().Intersect<int>(fCoachSkill).Count() > 0 : true) &&
                        (fCoachTime.Length != 0 ? c.TCoachAvailableTimes.Select(at => (int)at.FAvailableTimeId).ToArray<int>().Intersect<int>(fCoachTime).Count() > 0 : true)
                        select c;
            List<CCoachViewModel> coaches = new List<CCoachViewModel>();
            foreach (var c in datas)
            {
                CCoachViewModel coach = new CCoachViewModel(_context)
                {
                    _coach = c
                };
                coaches.Add(coach);
            }
            return View(coaches);
        }

        //教練詳細資料
        public IActionResult ViewCoachDetails(int? id)
        {
            TCoach coach = _context.TCoaches.FirstOrDefault(c => c.FCoachId == id);
            if (coach == null)
                return RedirectToAction("CoachList");

            var data = (from c in _context.TCoaches.Include(c => c.TCoachSkills).Include(c => c.TCoachAvailableTimes).AsSplitQuery()
                        .Include(c => c.TCoachExperiences).Include(c => c.TCoachLicenses).Include(c => c.FCity)
                       where c.FVisible == true && c.FCoachId == id
                       select c).FirstOrDefault();

            CCoachViewModel vModel = new CCoachViewModel(_context)
            {
                _coach = data
            };
            return View(vModel);
        }
        public IActionResult GetCoachRate(int id)
        {
            var data = from cr in _context.TCoachRates
                       where cr.FCoachId == id && cr.FVisible==true
                       select new { cr,cr.FMember.FMemberName };           
            return Json(data);
        }
        public IActionResult GetNewRate(int id)
        {
            var data = from cr in _context.TCoachRates
                       where cr.FCoachId == id && cr.FVisible == true
                       orderby cr.FRateDate descending
                       select new { cr, cr.FMember.FMemberName };
            return Json(data);
        }
        public IActionResult GetDesRate(int id)
        {
            var data = from cr in _context.TCoachRates
                       where cr.FCoachId == id && cr.FVisible == true
                       orderby cr.FRateStar descending
                       select new { cr, cr.FMember.FMemberName };
            return Json(data);
        }
        public IActionResult GetAscRate(int id)
        {
            var data = from cr in _context.TCoachRates
                       where cr.FCoachId == id && cr.FVisible == true
                       orderby cr.FRateStar ascending
                       select new { cr, cr.FMember.FMemberName };
            return Json(data);
        }
        public IActionResult GetRecCoach(int id)
        {
            var city = _context.TCoaches.FirstOrDefault(c => c.FCoachId == id).FCityId;
            var skills = _context.TCoaches.Include(c=>c.TCoachSkills).FirstOrDefault(c => c.FCoachId == id).TCoachSkills.Select(cs => (int)cs.FSkillId).ToArray();
            var data = (from c in _context.TCoaches.Include(c=>c.TCoachSkills).AsEnumerable()
                        where c.FVisible == true && c.FCityId == city &&
                        //skills.Any(s=>c.TCoachSkills.Select(cs=>cs.FSkillId).ToList().Contains(s))
                        c.TCoachSkills.Select(cs => (int)cs.FSkillId).ToArray<int>().Intersect<int>(skills).Count() > 0
                        orderby Guid.NewGuid()
                        select c).Take(5);        
            return Json(data);
        }
        //會員專區--課程列表
        public IActionResult CourseList()   
        {
            return View();
        }

        //會員專區--候選教練
        public IActionResult CandidateList()    
        {
            return View();
        }

        //課程行事曆
        public IActionResult ViewCourseCalendar()   
        {
            return View();
        } 
        
        
        public IActionResult Index()
        {
            return View();
        }     
        
       
    }
}
