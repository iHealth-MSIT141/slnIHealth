using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using prjIHealth.Models;
using prjIHealth.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Unicode;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;

namespace prjiHealth.Controllers
{
    public class CoachController : Controller
    {
        private readonly IHealthContext _context;
        private IWebHostEnvironment _environment;
        public CoachController(IHealthContext context, IWebHostEnvironment environment)
        {
            _context = context;
            _environment = environment;
        }
        public IActionResult Index()
        {
            return View();
        }

        //成為教練--MemberId尚無教練權限
        public IActionResult CreateResume()
        {
            TCoach c = _context.TCoaches.FirstOrDefault(c => c.FMemberId == userId);
            if (c != null)
                return RedirectToAction("EditResume");
            CCoachViewModel vModel = new CCoachViewModel(_context)
            {
                _coach = new TCoach()
            };
            return View(vModel);
        }

        [HttpPost] //送出履歷
        public IActionResult CreateResume(TCoach c, IFormFile File, int[] fCoachSkill, int[] fCoachTime, string[] fExperience, string[] fLicense)
        {
            c.FMemberId = userId;
            c.FStatusNumber = 50;
            c.FVisible = false;
            c.FApplyDate = DateTime.Now.ToString("yyyyMMddHHmmss");
            _context.TCoaches.Add(c);
            _context.SaveChanges();
            if (File != null)
                {
                    string photoName = Guid.NewGuid().ToString() + ".jpg";
                    File.CopyTo(new FileStream(_environment.WebRootPath + "/img/coach/coachImage/" + photoName, FileMode.Create));
                    c.FCoachImage = photoName;
                }

            //新增Skills            
            foreach (int skillId in fCoachSkill)
            {
                TCoachSkill newSkill = new TCoachSkill
                {
                    FCoachId = c.FCoachId,
                    FSkillId = skillId
                };
                _context.TCoachSkills.Add(newSkill);
            }

            //新增AvailableTime            
            foreach (int timeId in fCoachTime)
            {
                TCoachAvailableTime newTime = new TCoachAvailableTime
                {
                    FCoachId = c.FCoachId,
                    FAvailableTimeId = timeId
                };
                _context.TCoachAvailableTimes.Add(newTime);
            }

            //新增Experience            
            foreach (string Exp in fExperience)
            {
                if (Exp != null)
                {
                    TCoachExperience newExp = new TCoachExperience
                    {
                        FCoachId = c.FCoachId,
                        FExperience = Exp.Trim()
                    };
                    _context.TCoachExperiences.Add(newExp);
                }
            }

            //新增License           
            foreach (string Lic in fLicense)
            {
                if (Lic != null)
                {
                    TCoachLicense newLic = new TCoachLicense
                    {
                        FCoachId = c.FCoachId,
                        FLicense = Lic.Trim()
                    };
                    _context.TCoachLicenses.Add(newLic);
                }
            }
            _context.SaveChanges();
            return Content("Success", "text/plain");
        }        

        int userId = 127; //TODO 取登入者的MemberId
        //修改履歷
        public IActionResult EditResume()
        {
            TCoach data = _context.TCoaches.Include(c => c.TCoachSkills).Include(c => c.TCoachAvailableTimes).
                Include(c => c.TCoachExperiences).Include(c => c.TCoachLicenses).FirstOrDefault(c => c.FMemberId == userId);           
            CCoachViewModel vModel = new CCoachViewModel(_context)
            {
                _coach = data
            };
            return View(vModel);
        }

        [HttpPost]  //送出修改
        public IActionResult EditResume(TCoach c, IFormFile File, int[] fCoachSkill, int[] fCoachTime, string[] fExperience, string[] fLicense)
        {
            TCoach coach = _context.TCoaches.FirstOrDefault(c => c.FMemberId == userId);
            if (coach != null)
            {
                if (File != null)
                {
                    string photoName = Guid.NewGuid().ToString() + ".jpg";
                    File.CopyTo(new FileStream(_environment.WebRootPath + "/img/coach/coachImage/" + photoName, FileMode.Create));
                    coach.FCoachImage = photoName;
                }
                coach.FCityId = c.FCityId;
                coach.FCoachFee = c.FCoachFee;
                coach.FCoachDescription = c.FCoachDescription;
                coach.FSlogan = c.FSlogan;

                //新增Skills
                var currentSkills = _context.TCoachSkills.Where(cs => cs.FCoachId == coach.FCoachId).ToList();
                foreach (var skill in currentSkills)
                    _context.TCoachSkills.Remove(skill);
                foreach (int skillId in fCoachSkill)
                {
                    TCoachSkill newSkill = new TCoachSkill
                    {
                        FCoachId = coach.FCoachId,
                        FSkillId= skillId
                    };
                    _context.TCoachSkills.Add(newSkill);
                }

                //新增AvailableTime
                var currentTime = _context.TCoachAvailableTimes.Where(at => at.FCoachId == coach.FCoachId).ToList();
                foreach (var time in currentTime)
                    _context.TCoachAvailableTimes.Remove(time);
                foreach(int timeId in fCoachTime)
                {
                    TCoachAvailableTime newTime = new TCoachAvailableTime
                    {
                        FCoachId = coach.FCoachId,
                        FAvailableTimeId = timeId
                    };
                    _context.TCoachAvailableTimes.Add(newTime);
                }

                //新增Experience
                var currentExp = _context.TCoachExperiences.Where(e => e.FCoachId == coach.FCoachId).ToList();
                foreach (var exp in currentExp)
                    _context.TCoachExperiences.Remove(exp);
                foreach (string Exp in fExperience)
                {
                    if (Exp != null)
                    {
                        TCoachExperience newExp = new TCoachExperience
                        {
                            FCoachId = coach.FCoachId,
                            FExperience = Exp.Trim()
                        };
                        _context.TCoachExperiences.Add(newExp);
                    }                    
                }

                //新增License
                var currentLic = _context.TCoachLicenses.Where(e => e.FCoachId == coach.FCoachId).ToList();
                foreach (var lic in currentLic)
                    _context.TCoachLicenses.Remove(lic);
                foreach (string Lic in fLicense)
                {
                    if (Lic != null)
                    {
                        TCoachLicense newLic = new TCoachLicense
                        {
                            FCoachId = coach.FCoachId,
                            FLicense = Lic.Trim()
                        };
                        _context.TCoachLicenses.Add(newLic);
                    }                    
                }
            }
            _context.SaveChanges();
            return Content("Success", "text/plain");
        }
        public IActionResult RecruitmentList()
        {
            return View();
        }
        public IActionResult TeachingList()
        {
            return View();
        }
        //切換履歷顯示狀態
        public IActionResult ToggleVisible(int id)
        {
            var coach = _context.TCoaches.FirstOrDefault(c => c.FCoachId == id);
            if (coach.FVisible == true)
                coach.FVisible = false; //設為不公開 
            else
                coach.FVisible = true;  //設為公開
            _context.SaveChanges();
            return Content(coach.FVisible.ToString(), "text/plain");
        }
    }
}
