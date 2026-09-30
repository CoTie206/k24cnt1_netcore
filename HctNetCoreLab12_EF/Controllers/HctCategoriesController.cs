
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HctNetCoreLab12_EF.Models;
using HctNetCoreLab12_EF.HctEntities;

public class HctCategoriesController : Controller
{
    private readonly HctAppDBContext _context;

    public HctCategoriesController(HctAppDBContext context)
    {
        _context = context;
    }

    // GET: HCTCATEGORYS
    public async Task<IActionResult> Index()    
    {
        return View(await _context.HctCategories.ToListAsync());
    }

    // GET: HCTCATEGORYS/Details/5
    public async Task<IActionResult> Details(int? hctid)
    {
        if (hctid == null)
        {
            return NotFound();
        }

        var hctcategory = await _context.HctCategories
            .FirstOrDefaultAsync(m => m.HctID == hctid);
        if (hctcategory == null)
        {
            return NotFound();
        }

        return View(hctcategory);
    }

    // GET: HCTCATEGORYS/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: HCTCATEGORYS/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("HctID,HctName,HctStatus,HctCreatedDate")] HctCategory hctcategory)
    {
        if (ModelState.IsValid)
        {
            hctcategory.HctCreatedDate = DateTime.Now; // Set the created date to the current date and time
            _context.Add(hctcategory);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(hctcategory);
    }

    // GET: HCTCATEGORYS/Edit/5
    public async Task<IActionResult> Edit(int hctid, [Bind("HctID,HctName,HctStatus,HctCreatedDate")] HctCategory hctcategory)
    {
        if (hctid != hctcategory.HctID)
        {
            return NotFound();
        }
        if(ModelState.IsValid)
        {
            try
            {
                hctcategory.HctCreatedDate = DateTime.Now; // Update the created date to the current date and time
                _context.Update(hctcategory);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HctCategoryExists(hctcategory.HctID))
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

        return View(hctcategory);
    }

    // POST: HCTCATEGORYS/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int? hctid, [Bind("HctID,HctName,HctStatus,HctCreatedDate,HctProducts")] HctCategory hctcategory)
    {
        if (hctid != hctcategory.HctID)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(hctcategory);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HctCategoryExists(hctcategory.HctID))
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
        return View(hctcategory);
    }

    // GET: HCTCATEGORYS/Delete/5
    public async Task<IActionResult> Delete(int? hctid)
    {
        if (hctid == null)
        {
            return NotFound();
        }

        var hctcategory = await _context.HctCategories
            .FirstOrDefaultAsync(m => m.HctID == hctid);
        if (hctcategory == null)
        {
            return NotFound();
        }

        return View(hctcategory);
    }

    // POST: HCTCATEGORYS/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int? hctid)
    {
        var hctcategory = await _context.HctCategories.FindAsync(hctid);
        if (hctcategory != null)
        {
            _context.HctCategories.Remove(hctcategory);
        }

        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool HctCategoryExists(int? hctid)
    {
        return _context.HctCategories.Any(e => e.HctID == hctid);
    }
}
