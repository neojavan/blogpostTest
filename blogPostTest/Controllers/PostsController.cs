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
    public class PostsController : Controller
    {
        private readonly blogpostTestContext _context;

        public PostsController(blogpostTestContext context)
        {
            _context = context;
        }


        // GET: Posts
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Posts.Include(p => p.PostUsr);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Posts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var post = await _context.Posts
                .Include(p => p.PostUsr)
                .FirstOrDefaultAsync(m => m.PostId == id);
            if (post == null)
            {
                return NotFound();
            }

            return View(post);
        }

        // GET: Posts/Create
        public IActionResult Create()
        {
            ViewData["PostUsrId"] = new SelectList(_context.Users, "UsrId", "UsrFirstname");
            IDictionary<string, string> postStatus = new Dictionary<string, string>();
            postStatus.Add("1", "Pending");
            postStatus.Add("2", "Rejected");
            postStatus.Add("3", "Published");
            ViewData["PostStatus"] = new SelectList(postStatus, "key", "value");
            return View();
        }

        // POST: Posts/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PostId,PostUsrId,PostTitle,PostContent,PostSummary,PostCreated,PostPublished,PostUpdated,PostStatus")] Post post)
        {
            if (ModelState.IsValid)
            {
                _context.Add(post);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["PostUsrId"] = new SelectList(_context.Users, "UsrId", "UsrId", post.PostUsrId);
            IDictionary<string, string> postStatus = new Dictionary<string, string>();
            postStatus.Add("1", "Pending");
            postStatus.Add("2", "Rejected");
            postStatus.Add("3", "Published");
            ViewData["PostStatus"] = new SelectList(postStatus, "key", "value");
            return View(post);
        }

        // GET: Posts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var post = await _context.Posts.FindAsync(id);
            if (post == null)
            {
                return NotFound();
            }
            ViewData["PostUsrId"] = new SelectList(_context.Users, "UsrId", "UsrId", post.PostUsrId);
            return View(post);
        }

        // POST: Posts/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PostId,PostUsrId,PostTitle,PostContent,PostSummary,PostCreated,PostPublished,PostUpdated,PostStatus")] Post post)
        {
            if (id != post.PostId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(post);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PostExists(post.PostId))
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
            ViewData["PostUsrId"] = new SelectList(_context.Users, "UsrId", "UsrId", post.PostUsrId);
            return View(post);
        }

        // GET: Posts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var post = await _context.Posts
                .Include(p => p.PostUsr)
                .FirstOrDefaultAsync(m => m.PostId == id);
            if (post == null)
            {
                return NotFound();
            }

            return View(post);
        }

        // POST: Posts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var post = await _context.Posts.FindAsync(id);
            _context.Posts.Remove(post);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PostExists(int id)
        {
            return _context.Posts.Any(e => e.PostId == id);
        }
    }
}
