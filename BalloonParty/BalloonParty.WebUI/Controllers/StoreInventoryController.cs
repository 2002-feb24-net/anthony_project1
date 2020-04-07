using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BalloonParty.DataAccess.SQLData;

namespace BalloonParty.WebUI.Controllers
{
    public class StoreInventoryController : Controller
    {
        private readonly BalloonPartyContext _context;

        public StoreInventoryController(BalloonPartyContext context)
        {
            _context = context;
        }

        // GET: StoreInventory
        public async Task<IActionResult> Index()
        {
            var balloonPartyContext = _context.StoreInventory.Include(s => s.Product).Include(s => s.Store);
            return View(await balloonPartyContext.ToListAsync());

        }

        // GET: StoreInventory/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var storeInventory = await _context.StoreInventory
                .Include(s => s.Product)
                .Include(s => s.Store)
                .FirstOrDefaultAsync(m => m.SinventoryId == id);
            if (storeInventory == null)
            {
                return NotFound();
            }

            return View(storeInventory);
        }

        // GET: StoreInventory/Create
        public IActionResult Create()
        {
            ViewData["ProductId"] = new SelectList(_context.Products, "ProductId", "ProductId");
            ViewData["StoreId"] = new SelectList(_context.Store, "StoreId", "StoreId");
            return View();
        }

        // POST: StoreInventory/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("StoreId,ProductId,ProductName,ProductCount,SinventoryId")] StoreInventory storeInventory)
        {
            if (ModelState.IsValid)
            {
                _context.Add(storeInventory);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ProductId"] = new SelectList(_context.Products, "ProductId", "ProductId", storeInventory.ProductId);
            ViewData["StoreId"] = new SelectList(_context.Store, "StoreId", "StoreId", storeInventory.StoreId);
            return View(storeInventory);
        }

        // GET: StoreInventory/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var storeInventory = await _context.StoreInventory.FindAsync(id);
            if (storeInventory == null)
            {
                return NotFound();
            }
            ViewData["ProductId"] = new SelectList(_context.Products, "ProductId", "ProductId", storeInventory.ProductId);
            ViewData["StoreId"] = new SelectList(_context.Store, "StoreId", "StoreId", storeInventory.StoreId);
            return View(storeInventory);
        }

        // POST: StoreInventory/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("StoreId,ProductId,ProductName,ProductCount,SinventoryId")] StoreInventory storeInventory)
        {
            if (id != storeInventory.SinventoryId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(storeInventory);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StoreInventoryExists(storeInventory.SinventoryId))
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
            ViewData["ProductId"] = new SelectList(_context.Products, "ProductId", "ProductId", storeInventory.ProductId);
            ViewData["StoreId"] = new SelectList(_context.Store, "StoreId", "StoreId", storeInventory.StoreId);
            return View(storeInventory);
        }

        // GET: StoreInventory/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var storeInventory = await _context.StoreInventory
                .Include(s => s.Product)
                .Include(s => s.Store)
                .FirstOrDefaultAsync(m => m.SinventoryId == id);
            if (storeInventory == null)
            {
                return NotFound();
            }

            return View(storeInventory);
        }

        // POST: StoreInventory/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var storeInventory = await _context.StoreInventory.FindAsync(id);
            _context.StoreInventory.Remove(storeInventory);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StoreInventoryExists(int id)
        {
            return _context.StoreInventory.Any(e => e.SinventoryId == id);
        }

        public async Task<IActionResult> MyStoreInventory([Bind("StoreId,ProductId,ProductName,ProductCount,SinventoryId")] StoreInventory storeInventory)
        {


            var MystoreInventory = await _context.StoreInventory
                .Include(s => s.Product)
                .Include(s => s.Store)
                .FirstOrDefaultAsync(m => m.SinventoryId == 1);
            if (MystoreInventory == null)
            {
                return NotFound();
            }

            return View(storeInventory);
        }
    }
}
