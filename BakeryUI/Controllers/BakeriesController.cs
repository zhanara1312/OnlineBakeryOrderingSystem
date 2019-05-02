﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OnlineBakeryOrderingSystem;

namespace BakeryUI.Controllers
{
    public class BakeriesController : Controller
    {
        private readonly BakeryContext _context;

        public BakeriesController(BakeryContext context)
        {
            _context = context;
        }

        // GET: Bakeries
        public async Task<IActionResult> Index()
        {
            return View(BakeryOrder.GetBakeryOrderForUser("jen@gmail.com"));
        }

        // GET: Bakeries/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bakery = await _context.Bakeries
                .FirstOrDefaultAsync(m => m.CustomerNumber == id);
            if (bakery == null)
            {
                return NotFound();
            }

            return View(bakery);
        }

        // GET: Bakeries/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Bakeries/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("BakeryProduct,ItemPrice,CustomerNumber,CustomerName,CustomerAddress,CustomerEmailAddress,CustomerBankAccountNumber,NumberOfOrder,Date")] Bakery bakery)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bakery);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(bakery);
        }

        // GET: Bakeries/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bakery = await _context.Bakeries.FindAsync(id);
            if (bakery == null)
            {
                return NotFound();
            }
            return View(bakery);
        }

        // POST: Bakeries/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("BakeryProduct,ItemPrice,CustomerNumber,CustomerName,CustomerAddress,CustomerEmailAddress,CustomerBankAccountNumber,NumberOfOrder,Date")] Bakery bakery)
        {
            if (id != bakery.CustomerNumber)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bakery);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BakeryExists(bakery.CustomerNumber))
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
            return View(bakery);
        }

        // GET: Bakeries/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bakery = await _context.Bakeries
                .FirstOrDefaultAsync(m => m.CustomerNumber == id);
            if (bakery == null)
            {
                return NotFound();
            }

            return View(bakery);
        }

        // POST: Bakeries/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var bakery = await _context.Bakeries.FindAsync(id);
            _context.Bakeries.Remove(bakery);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BakeryExists(int id)
        {
            return _context.Bakeries.Any(e => e.CustomerNumber == id);
        }
    }
}
