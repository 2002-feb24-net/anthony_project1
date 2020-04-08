using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BalloonParty.DataAccess.SQLData;
using BalloonParty.DataAccess.Repositories;
using BalloonParty.Core.Interfaces;

namespace BalloonParty.WebUI.Controllers
{
    public class CustomerController : Controller
    {
        private readonly BalloonParty.Core.Interfaces.ICustomers _repo;
        public CustomerController(BalloonParty.Core.Interfaces.ICustomers repo)
        {
            _repo = repo;
        }
        //

        // GET: Customer
        // public async Task<IActionResult> Index()
        // {
        //     return View(await _context.Customer.ToListAsync());
        // }

        public ActionResult Index()
        {
            var info = _repo.GetAllCustomers();
            if (info == null)
            {
                return NotFound();
            }
            return Index();
        }

        // GET: Customer/Details/5
        // public async Task<IActionResult> Details(string id)
        // {
        //     if (id == null)
        //     {
        //         return NotFound();
        //     }
        //     var allCustomers = new BalloonParty.DataAccess.Repositories.CustomerRepo.GetCustomers();
        //     var customer = await allCustomers
        //         .FirstOrDefaultAsync(m => m.EmailAddress == id);
        //     if (customer == null)
        //     {
        //         return NotFound();
        //     }

        //     return View(customer);
        // }

        public ActionResult Details(string id)
        {
            var info = _repo.GetCustomersByID(id);
            if (info == null)
            {
                return NotFound();
            }

            return View(info);
        }

        // GET: Customer/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Customer/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        // [HttpPost]
        // [ValidateAntiForgeryToken]
        // public async Task<IActionResult> Create([Bind("FirstName,LastName,EmailAddress,CustomerPw,Address,City,State,ZipCode")] Customer customer)
        // {
        //     if (ModelState.IsValid)
        //     {
        //         _context.Add(customer);
        //         await _context.SaveChangesAsync();
        //         return RedirectToAction(nameof(Index));
        //     }
        //     return View(customer);
        // }

        // // GET: Customer/Edit/5
        // public async Task<IActionResult> Edit(string id)
        // {
        //     if (id == null)
        //     {
        //         return NotFound();
        //     }

        //     var customer = await _context.Customer.FindAsync(id);
        //     if (customer == null)
        //     {
        //         return NotFound();
        //     }
        //     return View(customer);
        // }

        // // POST: Customer/Edit/5
        // // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        // [HttpPost]
        // [ValidateAntiForgeryToken]
        // public async Task<IActionResult> Edit(string id, [Bind("FirstName,LastName,EmailAddress,CustomerPw,Address,City,State,ZipCode")] Customer customer)
        // {
        //     if (id != customer.EmailAddress)
        //     {
        //         return NotFound();
        //     }

        //     if (ModelState.IsValid)
        //     {
        //         try
        //         {
        //             _context.Update(customer);
        //             await _context.SaveChangesAsync();
        //         }
        //         catch (DbUpdateConcurrencyException)
        //         {
        //             if (!CustomerExists(customer.EmailAddress))
        //             {
        //                 return NotFound();
        //             }
        //             else
        //             {
        //                 throw;
        //             }
        //         }
        //         return RedirectToAction(nameof(Index));
        //     }
        //     return View(customer);
        // }

        // // GET: Customer/Delete/5
        // public async Task<IActionResult> Delete(string id)
        // {
        //     if (id == null)
        //     {
        //         return NotFound();
        //     }

        //     var customer = await _context.Customer
        //         .FirstOrDefaultAsync(m => m.EmailAddress == id);
        //     if (customer == null)
        //     {
        //         return NotFound();
        //     }

        //     return View(customer);
        // }

        // // POST: Customer/Delete/5
        // [HttpPost, ActionName("Delete")]
        // [ValidateAntiForgeryToken]
        // public async Task<IActionResult> DeleteConfirmed(string id)
        // {
        //     var customer = await _context.Customer.FindAsync(id);
        //     _context.Customer.Remove(customer);
        //     await _context.SaveChangesAsync();
        //     return RedirectToAction(nameof(Index));
        // }

        // private bool CustomerExists(string id)
        // {
        //     return _context.Customer.Any(e => e.EmailAddress == id);
        // }
    }
}
