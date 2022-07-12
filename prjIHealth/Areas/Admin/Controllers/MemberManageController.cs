using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using prjIHealth.Models;

namespace prjIHealth.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MemberManageController : Controller
    {
        private readonly IHealthContext _context;

        public MemberManageController(IHealthContext context)
        {
            _context = context;
        }

        // GET: Admin/MemberManage
        public async Task<IActionResult> Index()
        {
            var iHealthContext = _context.TMembers.Include(t => t.FAuthority);
            return View(await iHealthContext.ToListAsync());
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
        public async Task<IActionResult> Edit(int id, [Bind("FMemberId,FMemberName,FPassword,FBirthday,FGender,FPicturePath,FUserName,FAddress,FPhone,FEmail,FRegisterDate,FAuthorityId,FDisabled,FRemarks")] TMember tMember)
        {
            if (id != tMember.FMemberId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tMember);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TMemberExists(tMember.FMemberId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["FAuthorityId"] = new SelectList(_context.TAuthorities, "FAutorityId", "FAuthorityName", tMember.FAuthorityId);
            return View(tMember);
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
