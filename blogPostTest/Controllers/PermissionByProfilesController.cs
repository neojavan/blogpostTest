using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using blogPostTest.Models;

namespace blogPostTest.Controllers
{
    public class PermissionByProfilesController : Controller
    {
        private readonly blogpostTestContext _context;

        public PermissionByProfilesController(blogpostTestContext context)
        {
            _context = context;
        }

        // GET: PermissionByProfiles
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.PermissionByProfiles.Include(p => p.PbpPerm).Include(p => p.PbpProf);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: PermissionByProfiles/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var permissionByProfile = await _context.PermissionByProfiles
                .Include(p => p.PbpPerm)
                .Include(p => p.PbpProf)
                .FirstOrDefaultAsync(m => m.PbpId == id);
            if (permissionByProfile == null)
            {
                return NotFound();
            }

            return View(permissionByProfile);
        }

        // GET: PermissionByProfiles/Create
        public IActionResult Create()
        {
            ViewData["PbpPermId"] = new SelectList(_context.Permissions, "PermsId", "PermsId");
            ViewData["PbpProfId"] = new SelectList(_context.Profiles, "ProfId", "ProfId");
            return View();
        }

        // POST: PermissionByProfiles/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PbpId,PbpPermId,PbpProfId")] PermissionByProfile permissionByProfile)
        {
            if (ModelState.IsValid)
            {
                _context.Add(permissionByProfile);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["PbpPermId"] = new SelectList(_context.Permissions, "PermsId", "PermsId", permissionByProfile.PbpPermId);
            ViewData["PbpProfId"] = new SelectList(_context.Profiles, "ProfId", "ProfId", permissionByProfile.PbpProfId);
            return View(permissionByProfile);
        }

        // GET: PermissionByProfiles/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var permissionByProfile = await _context.PermissionByProfiles.FindAsync(id);
            if (permissionByProfile == null)
            {
                return NotFound();
            }
            ViewData["PbpPermId"] = new SelectList(_context.Permissions, "PermsId", "PermsId", permissionByProfile.PbpPermId);
            ViewData["PbpProfId"] = new SelectList(_context.Profiles, "ProfId", "ProfId", permissionByProfile.PbpProfId);
            return View(permissionByProfile);
        }

        // POST: PermissionByProfiles/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PbpId,PbpPermId,PbpProfId")] PermissionByProfile permissionByProfile)
        {
            if (id != permissionByProfile.PbpId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(permissionByProfile);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PermissionByProfileExists(permissionByProfile.PbpId))
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
            ViewData["PbpPermId"] = new SelectList(_context.Permissions, "PermsId", "PermsId", permissionByProfile.PbpPermId);
            ViewData["PbpProfId"] = new SelectList(_context.Profiles, "ProfId", "ProfId", permissionByProfile.PbpProfId);
            return View(permissionByProfile);
        }

        // GET: PermissionByProfiles/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var permissionByProfile = await _context.PermissionByProfiles
                .Include(p => p.PbpPerm)
                .Include(p => p.PbpProf)
                .FirstOrDefaultAsync(m => m.PbpId == id);
            if (permissionByProfile == null)
            {
                return NotFound();
            }

            return View(permissionByProfile);
        }

        // POST: PermissionByProfiles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var permissionByProfile = await _context.PermissionByProfiles.FindAsync(id);
            _context.PermissionByProfiles.Remove(permissionByProfile);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PermissionByProfileExists(int id)
        {
            return _context.PermissionByProfiles.Any(e => e.PbpId == id);
        }
    }
}
