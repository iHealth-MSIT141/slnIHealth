using Microsoft.AspNetCore.Mvc;
using prjIHealth.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prjiHealth.Controllers
{
    public class MemberController : Controller
    {
        public IActionResult ShowTrackList()
        {
            return View();
        }

        public IActionResult Delete(int? id)
        {
            IHealthContext dblIHealth = new IHealthContext();
            TTrackList trackList = dblIHealth.TTrackLists.FirstOrDefault(t => t.FProductId == id);
            if (trackList != null)
            {
                dblIHealth.TTrackLists.Remove(trackList);
                dblIHealth.SaveChanges();
            }
            return RedirectToAction("ShowTrackList");
        }
    }
}
