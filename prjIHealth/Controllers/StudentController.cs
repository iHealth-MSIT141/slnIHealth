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
using System.Text.Json;

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
                    .Include(c => c.TCoachSkills).ThenInclude(cs=>cs.FSkill).AsEnumerable()
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
                .Include(c => c.TCoachAvailableTimes).ThenInclude(t=>t.FAvailableTime)
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
                       where cr.FCoachId == id && cr.FVisible==true
                       select new { cr,cr.FMember.FMemberName };           
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
                .Include(c=>c.FMember)
                .Include(c=>c.FCity)                
                .Include(c => c.TCoachSkills).ThenInclude(cs=>cs.FSkill).AsEnumerable()
                .Where(c => c.FVisible == true && c.FCityId == cityId && c.FCoachId!=id &&
                (c.TCoachSkills.Select(cs => cs.FSkillId).ToArray().Intersect(skills)).Count() > 0)
                .OrderBy(c=>Guid.NewGuid()).Take(5);
            
            var coaches = CCoachViewModel.CoachList(datas.ToList());
            return Json(coaches);
        }
        //取得推薦教練專長
        public IActionResult GetSkillName(int id)
        {
            var data = _context.TCoachSkills.Include(cs => cs.FSkill).Where(cs => cs.FCoachId == id).Select(cs => cs.FSkill.FSkillName).ToArray();    
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
