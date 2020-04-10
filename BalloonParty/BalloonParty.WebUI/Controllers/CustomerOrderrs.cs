using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BalloonParty.DataAccess.SQLData;
using BalloonParty.Core.Models;

namespace BalloonParty.WebUI.Controllers
{
    public class CustomerOrderrs : Controller
    {
        private readonly BalloonPartyContext _context;

        public CustomerOrderrs(BalloonPartyContext context)
        {
            _context = context;
        }

        // GET: CustomerOrderrs
        public async Task<IActionResult> Index()
        {
            var balloonPartyContext = _context.CustomerOrders.Include(c => c.CustomerEmailNavigation);
            return View(await balloonPartyContext.ToListAsync());
        }

        // GET: CustomerOrderrs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customerOrders = await _context.CustomerOrders
                .Include(c => c.CustomerEmailNavigation)
                .FirstOrDefaultAsync(m => m.CustomerOrderId == id);
            if (customerOrders == null)
            {
                return NotFound();
            }

            return View(customerOrders);
        }

        // GET: CustomerOrderrs/Create
        public IActionResult Create()
        {
            ViewData["CustomerEmail"] = new SelectList(_context.Customer, "EmailAddress", "EmailAddress");
            ViewData["ProductName"] = new SelectList(_context.Products, "ProductName", "ProductName");
            return View();
        }

        // POST: CustomerOrderrs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CustomerEmail,OrderDate,FullProductCount,TotalPrice,CustomerOrderId,ProductName")] BalloonParty.DataAccess.SQLData.CustomerOrders customerOrders)
        {
            var prodPrices = _context.Products.ToList();
            if (ModelState.IsValid)
            {
                var cso = new BalloonParty.Core.Models.CustomerOrders
                {
                    CustomerEmail = customerOrders.CustomerEmail,
                    OrderDate = DateTime.Now,
                    FullProductCount = customerOrders.FullProductCount,
                    TotalPrice = customerOrders.FullProductCount * prodPrices.SingleOrDefault(p => p.ProductName == customerOrders.ProductName).ProductPrice,
                    CustomerOrderId = customerOrders.CustomerOrderId,
                    ProductName = customerOrders.ProductName,
                };

                customerOrders = BalloonParty.DataAccess.Mapper.MapCustomerOrderCORE(cso);
                _context.Add(customerOrders);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CustomerEmail"] = new SelectList(_context.Customer, "EmailAddress", "EmailAddress", customerOrders.CustomerEmail);
            ViewData["ProductName"] = new SelectList(_context.Products, "ProductName", "ProductName", customerOrders.ProductName);
            return View(customerOrders);
        }

        // GET: CustomerOrderrs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customerOrders = await _context.CustomerOrders.FindAsync(id);
            if (customerOrders == null)
            {
                return NotFound();
            }
            ViewData["CustomerEmail"] = new SelectList(_context.Customer, "EmailAddress", "EmailAddress", customerOrders.CustomerEmail);
            return View(customerOrders);
        }

        // POST: CustomerOrderrs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CustomerEmail,OrderDate,FullProductCount,TotalPrice,CustomerOrderId,ProductName")] BalloonParty.DataAccess.SQLData.CustomerOrders customerOrders)
        {
            if (id != customerOrders.CustomerOrderId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(customerOrders);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CustomerOrdersExists(customerOrders.CustomerOrderId))
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
            ViewData["CustomerEmail"] = new SelectList(_context.Customer, "EmailAddress", "EmailAddress", customerOrders.CustomerEmail);
            return View(customerOrders);
        }

        // GET: CustomerOrderrs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customerOrders = await _context.CustomerOrders
                .Include(c => c.CustomerEmailNavigation)
                .FirstOrDefaultAsync(m => m.CustomerOrderId == id);
            if (customerOrders == null)
            {
                return NotFound();
            }

            return View(customerOrders);
        }

        // POST: CustomerOrderrs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var customerOrders = await _context.CustomerOrders.FindAsync(id);
            _context.CustomerOrders.Remove(customerOrders);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CustomerOrdersExists(int id)
        {
            return _context.CustomerOrders.Any(e => e.CustomerOrderId == id);
        }
    }
}
