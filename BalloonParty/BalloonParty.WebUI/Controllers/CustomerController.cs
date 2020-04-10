using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
//using BalloonParty.DataAccess.SQLData;
using BalloonParty.DataAccess.Repositories;
using BalloonParty.Core.Interfaces;
using BalloonParty.WebUI.Models;

namespace BalloonParty.WebUI.Controllers
{
    public class CustomerController : Controller
    {
        private readonly BalloonParty.Core.Interfaces.ICustomers _repo;
        private readonly BalloonParty.DataAccess.SQLData.BalloonPartyContext _context;
        public CustomerController(BalloonParty.Core.Interfaces.ICustomers repo, BalloonParty.DataAccess.SQLData.BalloonPartyContext context)
        {
            _repo = repo;
            _context = context;
        }


        // GET: Customer
        public ActionResult Index()
        {
            var info = _repo.GetAllCustomers();
            if (info == null)
            {
                return NotFound();
            }
            return View(info);
        }

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

        public ActionResult Create([Bind("FirstName,LastName,EmailAddress,CustomerPw,Address,City,State,ZipCode")] CustomerViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                var newCustomer = new BalloonParty.Core.Models.Customer
                {
                    FirstName = viewModel.FirstName,
                    LastName = viewModel.LastName,
                    EmailAddress = viewModel.EmailAddress,
                    CustomerPw = viewModel.CustomerPw,
                    Address =  viewModel.Address,
                    City = viewModel.City,
                    State = viewModel.State,
                    ZipCode = int.Parse(viewModel.ZipCode),
                };
                _repo.AddNewCustomer(newCustomer);
                return RedirectToAction(nameof(Index));
            }
            return  View(viewModel);
        }

        // GET: Customer/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer = _repo.GetCustomersByID(id);//await _context.Customer.FindAsync(id);
            if (customer == null)
            {
                return NotFound();
            }
            return View(customer);
        }

        // POST: Customer/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(string id, [Bind("FirstName,LastName,EmailAddress,CustomerPw,Address,City,State,ZipCode")] BalloonParty.DataAccess.SQLData.Customer customer)
        {
            if (id != customer.EmailAddress)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _repo.UpdateCustomer(DataAccess.Mapper.MapCORECustomer(customer));
                return RedirectToAction(nameof(Index));
            }
            return View(customer);
        }

        // GET: Customer/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer = await _context.Customer
                .FirstOrDefaultAsync(m => m.EmailAddress == id);
            if (customer == null)
            {
                return NotFound();
            }

            return View(customer);
        }
    }
}
