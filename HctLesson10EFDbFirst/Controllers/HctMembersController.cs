using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HctLesson10EFDbFirst.Models;

namespace HctLesson10EFDbFirst.Controllers
{
    public class HctMembersController : Controller
    {
        private readonly HctLesson10EfdbContext _context;

        public HctMembersController(HctLesson10EfdbContext context)
        {
            _context = context;
        }

        // GET: HctMembers
        public async Task<IActionResult> Index()
        {
            return View(await _context.HctMembers.ToListAsync());
        }

        // GET: HctMembers/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hctMember = await _context.HctMembers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (hctMember == null)
            {
                return NotFound();
            }

            return View(hctMember);
        }

        // GET: HctMembers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: HctMembers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,HctUserName,HctPassword,HctFullName,HctEmail,HctPhone,HctStatus")] HctMember hctMember)
        {
            if (ModelState.IsValid)
            {
                _context.Add(hctMember);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(hctMember);
        }

        // GET: HctMembers/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hctMember = await _context.HctMembers.FindAsync(id);
            if (hctMember == null)
            {
                return NotFound();
            }
            return View(hctMember);
        }

        // POST: HctMembers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,HctUserName,HctPassword,HctFullName,HctEmail,HctPhone,HctStatus")] HctMember hctMember)
        {
            if (id != hctMember.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(hctMember);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HctMemberExists(hctMember.Id))
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
            return View(hctMember);
        }

        // GET: HctMembers/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hctMember = await _context.HctMembers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (hctMember == null)
            {
                return NotFound();
            }

            return View(hctMember);
        }

        // POST: HctMembers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var hctMember = await _context.HctMembers.FindAsync(id);
            if (hctMember != null)
            {
                _context.HctMembers.Remove(hctMember);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HctMemberExists(long id)
        {
            return _context.HctMembers.Any(e => e.Id == id);
        }
    }
}
