using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HoangCongTien2410900073_exam.Models;

namespace HoangCongTien2410900073_exam.Controllers
{
    public class HctStudentsController : Controller
    {
        private readonly HctDbContext _context;
        public HctStudentsController(HctDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _context.HctStudents.ToListAsync());

        }
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var hctStudent = await _context.HctStudents
                .FirstOrDefaultAsync(m => m.Id == id);
            if (hctStudent == null)
            {
                return NotFound();
            }
            return View(hctStudent);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,HctName,HctGender,HctBirthDay,HctEmail,HctPhone,HctActive")] HctStudent hctStudent)
        {
            if (ModelState.IsValid)
            {
                _context.Add(hctStudent);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(hctStudent);
        }
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var hctStudent = await _context.HctStudents.FindAsync(id);
            if (hctStudent == null)
            {
                return NotFound();
            }
            return View(hctStudent);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,HctName,HctGender,HctBirthDay,HctEmail,HctPhone,HctActive")] HctStudent hctStudent)
        {
            if (id != hctStudent.Id)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(hctStudent);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HctStudentExists(hctStudent.Id))
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
            return View(hctStudent);
        }
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var hctStudent = await _context.HctStudents
                .FirstOrDefaultAsync(m => m.Id == id);
            if (hctStudent == null)
            {
                return NotFound();
            }
            return View(hctStudent);
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var hctStudent = await _context.HctStudents.FindAsync(id);
            if(hctStudent != null)
            {
                _context.HctStudents.Remove(hctStudent);
            }
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        private bool HctStudentExists(long id)
        {
            return _context.HctStudents.Any(e => e.Id == id);
        }
    }
}
