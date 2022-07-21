using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using prjiHealth.ViewModels;
using prjIHealth.Models;
using X.PagedList;

namespace prjIHealth.Areas.Admin.Controllers
{
    [Area("Admin")]
        public class MemberManageController : Controller
    {
        private IWebHostEnvironment _environment;
        private readonly IHealthContext _context;
        public MemberManageController(IHealthContext context, IWebHostEnvironment IWHE)
        {
            _context = context;
            _environment = IWHE;
        }

        // GET: Admin/MemberManage
        public IActionResult Index(int?  page)
        {
            var pageNumber = page ?? 1; // if no page was specified in the querystring, default to the first page (1)
            var iHealthContext = _context.TMembers.Include(t => t.FAuthority).ToList();
            var onePageOfMembers =iHealthContext.ToPagedList(pageNumber,6); // will only contain 6 items max because of the pageSize
            ViewBag.onePageOfMembers = onePageOfMembers;
            return View(onePageOfMembers);
        }

        // GET: Admin/MemberManage/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var tMember = await _context.TMembers
                .Include(t => t.FAuthority)
                .FirstOrDefaultAsync(m => m.FMemberId == id);
            if (tMember == null)
            {
                return NotFound();
            }

            return View(tMember);
        }

        // GET: Admin/MemberManage/Create
        public IActionResult Create()
        {
            ViewData["FAuthorityId"] = new SelectList(_context.TAuthorities, "FAutorityId", "FAuthorityName");
            return View();
        }

        // POST: Admin/MemberManage/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FMemberId,FMemberName,FPassword,FBirthday,FGender,FPicturePath,FUserName,FAddress,FPhone,FEmail,FRegisterDate,FAuthorityId,FDisabled,FRemarks")] TMember tMember)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tMember);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["FAuthorityId"] = new SelectList(_context.TAuthorities, "FAutorityId", "FAuthorityName", tMember.FAuthorityId);
            return View(tMember);
        }

        // GET: Admin/MemberManage/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tMember = await _context.TMembers.FindAsync(id);
            if (tMember == null)
            {
                return NotFound();
            }
            ViewData["FAuthorityId"] = new SelectList(_context.TAuthorities, "FAutorityId", "FAuthorityName", tMember.FAuthorityId);
            return View(tMember);
        }

        // POST: Admin/MemberManage/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(int id, [Bind("FMemberId,FMemberName,FPassword,FBirthday,FGender,FPicturePath,FUserName,FAddress,FPhone,FEmail,FRegisterDate,FAuthorityId,FDisabled,FRemarks")] TMember tMember)
        public IActionResult Edit(CLoginViewModel vModel)
        {
            var q = _context.TMembers.FirstOrDefault(m => m.FMemberId == vModel.fMemberId);
            if (q != null)
            {
                if (vModel.photo != null)
                {
                    string pName = Guid.NewGuid().ToString() + ".jpg";
                    vModel.photo.CopyTo(new FileStream(_environment.WebRootPath + "/img/member/" + pName, FileMode.Create));
                    q.FPicturePath = pName;
                }
                q.FPassword = vModel.fPassword;
                q.FPhone = vModel.fPhone;
                q.FMemberName = vModel.fMemberName;
            }
            _context.SaveChanges();
            return RedirectToAction("Index", "MemberManage");
        }

        // GET: Admin/MemberManage/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tMember = await _context.TMembers
                .Include(t => t.FAuthority)
                .FirstOrDefaultAsync(m => m.FMemberId == id);
            if (tMember == null)
            {
                return NotFound();
            }

            return View(tMember);
        }

        // POST: Admin/MemberManage/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tMember = await _context.TMembers.FindAsync(id);
            _context.TMembers.Remove(tMember);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TMemberExists(int id)
        {
            return _context.TMembers.Any(e => e.FMemberId == id);
        }
    }
}
