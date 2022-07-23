using Microsoft.EntityFrameworkCore;
using prjIHealth.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prjIHealth.ViewModels
{
    public class CCoachViewModel
    {
        private IHealthContext db;
        public CCoachViewModel(IHealthContext context)
        {
            db = context;
        }
        public TCoach Coach { get; set; }
        public string CityName
        {
            get
            {
                if (Coach.FCityId != null)
                    return db.TCities.FirstOrDefault(c => c.FCityId == Coach.FCityId).FCityName;
                else
                    return null;

            }
        }
        public string ApplyDate
        {
            get
            {
                if (!String.IsNullOrEmpty(Coach.FApplyDate))
                {
                    string fApplyDate = Coach.FApplyDate;
                    string yyyy = fApplyDate.Substring(0, 4);
                    string MM = fApplyDate.Substring(4, 2);
                    string dd = fApplyDate.Substring(6, 2);
                    string hh = fApplyDate.Substring(8, 2);
                    string mm = fApplyDate.Substring(10, 2);
                    return $"{yyyy}-{MM}-{dd} {hh}:{mm}";
                }
                else
                    return null;
            }
        }
        public string Status
        {
            get
            {
                if (Coach.FStatusNumber != null)
                    return db.TStatuses.FirstOrDefault(s => s.FStatusNumber == Coach.FStatusNumber).FStatus;
                else
                    return null;
            }
        }
        public string Visible
        {
            get
            {
                if (Coach.FVisible != null)
                {
                    if ((bool)(Coach.FVisible))
                        return "公開";
                    else
                        return "未公開";
                }
                else
                    return null;
            }
        }

        public IEnumerable<string> Skills
        {
            get
            {
                if (Coach.FCoachId != null && Coach.FCoachId != 0)
                    return db.TCoachSkills.Where(cs => cs.FCoachId == Coach.FCoachId).Include(cs => cs.FSkill).Select(cs => cs.FSkill.FSkillName);
                else
                    return null;
            }
        }
        public IEnumerable<string> Experiences
        {
            get
            {
                if (Coach.FCoachId != null && Coach.FCoachId != 0)
                    return db.TCoachExperiences.Where(e => e.FCoachId == Coach.FCoachId).Select(e => e.FExperience);
                else
                    return null;
            }
        }
        public IEnumerable<string> Licenses
        {
            get
            {
                if (Coach.FCoachId != null && Coach.FCoachId != 0)
                    return db.TCoachLicenses.Where(l => l.FCoachId == Coach.FCoachId).Select(l => l.FLicense);
                else
                    return null;
            }
        }
    }
}