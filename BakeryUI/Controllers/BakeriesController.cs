using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OnlineBakeryOrderingSystem;

namespace BakeryUI.Controllers
    
{
    [Authorize]
    public class BakeriesController : Controller

    {
        public string UserName { get; set; }
        // GET: Bakeries
        public IActionResult Index()
     
            {
                if (HttpContext != null &&
                    !string.IsNullOrEmpty
                    (HttpContext.User.Identity.Name))
                {
                    UserName = HttpContext.User.Identity.Name;
                }
                return View(BakeryOrder.GetBakeryOrderForUser(UserName));
            }            


        // GET: Bakeries/Details/5
        public IActionResult Details (int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bakery = BakeryOrder.GetBakeryOrderByCustomerNumber(id.Value);
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
        public IActionResult Create ([Bind("BakeryProduct,CustomerName,CustomerEmailAddress,NumberOfOrder")] Bakery bakery)
        {
            if (ModelState.IsValid)
            {
                BakeryOrder.CreateBakery (bakery.BakeryProduct, bakery.CustomerName, bakery.CustomerEmailAddress, bakery.CustomerBankAccountNumber, bakery.NumberOfOrder);
                return RedirectToAction(nameof(Index));
            }
            return View(bakery);
        }  

    public IActionResult Order (int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var account = BakeryOrder.GetBakeryOrderByCustomerNumber(id.Value);
        if (account == null)
        {
            return NotFound();
        }
            string bakery = null;
            return View(bakery);
    }
    [HttpPost]
    public IActionResult Order (IFormCollection controls)
    {
        var accountNumber = Convert.ToInt32(controls["CustomerNumber"]);
        var numberOfOrder = Convert.ToInt32(controls["numberOfOrder"]);
        BakeryOrder.Order(accountNumber, numberOfOrder);
        return RedirectToAction (nameof(Index));
    }

    public IActionResult Transaction (int? id)
    {
        if (id == null)
        {
            return NotFound();
        }
        var transaction = BakeryOrder.GetTransactionsForCustomerNumber(id.Value);
        return View (transaction);
    }

    // GET: Bakeries/Edit/5
    public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bakery = BakeryOrder.GetBakeryOrderByCustomerNumber(id.Value);
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
        public IActionResult Edit (int id, [Bind("CustomerNumber, BakeryProduct,CustomerName,CustomerEmailAddress,NumberOfOrder")] Bakery bakery)
        {
            if (id != bakery.CustomerNumber)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    BakeryOrder.UpdateBakery(bakery);
                }
                catch (DbUpdateConcurrencyException)
                {
                if (BakeryOrder.GetBakeryOrderByCustomerNumber(bakery.CustomerNumber) == null)
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
               
    }
}


