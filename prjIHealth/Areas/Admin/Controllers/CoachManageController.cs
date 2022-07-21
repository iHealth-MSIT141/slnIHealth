using Microsoft.AspNetCore.Mvc;
using prjIHealth.Models;
using prjIHealth.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prjIHealth.Areas.Admin.Controllers
{
    [Area(areaName: "Admin")]
    public class CoachManageController : Controller
    {
        private IHealthContext db;
        public CoachManageController(IHealthContext context)
        {
            db = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CoachList()
        {
            List<CCoachViewModel> coaches = new List<CCoachViewModel>();
            foreach(var c in db.TCoaches.OrderByDescending(c=>c.FApplyDate))
            {
                CCoachViewModel coachViewModel = new CCoachViewModel(db)
                {
                    Coach = c
                };
                coaches.Add(coachViewModel);
            }
            return View(coaches);
        }
        public IActionResult getCoach(int? id)
        {
            CCoachViewModel coachViewModel = new CCoachViewModel(db);
            coachViewModel.Coach = db.TCoaches.FirstOrDefault(c => c.FCoachId == id);

            return Json(coachViewModel);
        }
        public IActionResult passResume(int? id)
        {
            var theCoach = db.TCoaches.FirstOrDefault(c => c.FCoachId == id);
            theCoach.FStatusNumber = 66;
            theCoach.FVisible = true;
            db.SaveChanges();
            return Content("");
        }
        public IActionResult returnResume(int? id)
        {
            var theCoach = db.TCoaches.FirstOrDefault(c => c.FCoachId == id);
            theCoach.FStatusNumber = 67;
            theCoach.FVisible = false;
            db.SaveChanges();
            return Content("");
        }

        public IActionResult loadCoach(CSearchCoachViewModel searchCoachViewModel)
        {
            IEnumerable<TCoach> tCoaches = null;
            if (searchCoachViewModel.SkillId != 0)
                tCoaches = db.TCoachSkills.Where(cs => cs.FSkillId == searchCoachViewModel.SkillId).Select(cs => cs.FCoach);
            else
                tCoaches = db.TCoaches;

            if (searchCoachViewModel.Sort == 1)
                tCoaches = tCoaches.OrderByDescending(c => c.FApplyDate);
            else
                tCoaches = tCoaches.OrderBy(c => c.FApplyDate);

            if (searchCoachViewModel.CityId != 0)
                tCoaches = tCoaches.Where(c => c.FCityId == searchCoachViewModel.CityId);
            if (!String.IsNullOrEmpty(searchCoachViewModel.KeyWord))
                tCoaches = tCoaches.Where(c => c.FCoachName.Contains(searchCoachViewModel.KeyWord) || c.FCoachId.ToString().Contains(searchCoachViewModel.KeyWord));
            if (searchCoachViewModel.StatusNum != 0)
                tCoaches = tCoaches.Where(c => c.FStatusNumber == searchCoachViewModel.StatusNum);

            List<CCoachViewModel> coaches = null;
            if (tCoaches.Count() != 0)
            {
                coaches = new List<CCoachViewModel>();
                foreach (var c in tCoaches)
                {
                    CCoachViewModel coachViewModel = new CCoachViewModel(db)
                    {
                        Coach = c
                    };
                    coaches.Add(coachViewModel);
                }
            }
            return Json(coaches);
        }
        public IActionResult RateList()
        {
            var tRates = db.TCoachRates.OrderByDescending(r=>r.FRateDate);
            List<CCoachRateViewModel> rates = new List<CCoachRateViewModel>();
            foreach (var r in tRates)
            {
                CCoachRateViewModel coachRateViewModel = new CCoachRateViewModel(db)
                {
                    FRateId = r.FRateId,
                    FMemberId = r.FMemberId,
                    FCoachId = r.FCoachId,
                    FRateStar = r.FRateStar,
                    FRateText = r.FRateText,
                    FRateDate = r.FRateDate,
                    FVisible = r.FVisible
                };
                rates.Add(coachRateViewModel);
            }
            return View(rates);
        }
        public IActionResult editVisible(int? flag,int? FRateId)
        {
            var theRate = db.TCoachRates.FirstOrDefault(r => r.FRateId == FRateId);
            if (flag == 1)
                theRate.FVisible = true;
            else
                theRate.FVisible = false;
            db.SaveChanges();
            return Content("");
        }
    }
}
