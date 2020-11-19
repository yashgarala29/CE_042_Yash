using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using wddn_online_shopping.Models.context_class;
using wddn_online_shopping.Models.model_class;

namespace wddn_online_shopping
{
    public class customer_cart_itemController : Controller
    {
        private readonly AppDbContext _context;

        public customer_cart_itemController(AppDbContext context)
        {
            _context = context;
        }

        // GET: customer_cart_item
        public async Task<IActionResult> Index()
        {
            return View(await _context.cart_Items.ToListAsync());
        }

        // GET: customer_cart_item/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer_cart_item = await _context.cart_Items
                .FirstOrDefaultAsync(m => m.id == id);
            if (customer_cart_item == null)
            {
                return NotFound();
            }

            return View(customer_cart_item);
        }

        // GET: customer_cart_item/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: customer_cart_item/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id")] customer_cart_item customer_cart_item)
        {
            if (ModelState.IsValid)
            {
                _context.Add(customer_cart_item);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(customer_cart_item);
        }

        // GET: customer_cart_item/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer_cart_item = await _context.cart_Items.FindAsync(id);
            if (customer_cart_item == null)
            {
                return NotFound();
            }
            return View(customer_cart_item);
        }

        // POST: customer_cart_item/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id")] customer_cart_item customer_cart_item)
        {
            if (id != customer_cart_item.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(customer_cart_item);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!customer_cart_itemExists(customer_cart_item.id))
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
            return View(customer_cart_item);
        }

        // GET: customer_cart_item/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer_cart_item = await _context.cart_Items
                .FirstOrDefaultAsync(m => m.id == id);
            if (customer_cart_item == null)
            {
                return NotFound();
            }

            return View(customer_cart_item);
        }

        // POST: customer_cart_item/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var customer_cart_item = await _context.cart_Items.FindAsync(id);
            _context.cart_Items.Remove(customer_cart_item);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool customer_cart_itemExists(int id)
        {
            return _context.cart_Items.Any(e => e.id == id);
        }
    }
}
