using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
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
            //int customer_id= (int)HttpContext.Session.GetInt32("customer_id");
            //int customer_id = Int32.Parse(Request.Cookies["customer_id"].ToString());
            int customer_id = -1;
            //var seller_id = HttpContext.Session.GetInt32("seller_id");

            string co = Request.Cookies["customer_id"];
            if (co == null)
            {
                co = "-1";
            }
            customer_id = Int32.Parse(co);

            var cart_item = _context.cart_Items.Where(c => c.customer_cart_id == customer_id).ToList();
            int total_price = 0;
            List<item_detail> produc_in_cart=new List<item_detail>();
            foreach (var c in cart_item)
            {
                var temp = _context.item_Details.Where(p => p.product_id == c.product_cart_id).FirstOrDefault();
                total_price = total_price + temp.product_price;
                produc_in_cart.Add(temp);
            }
            ViewBag.total_price = total_price;
            System.Diagnostics.Debug.WriteLine("cart_item.LongCount()" + produc_in_cart.LongCount());

            ViewBag.produc_in_cart = produc_in_cart;
            return View(produc_in_cart);
        }
        
        public async Task<IActionResult> placer_order()
        {
            //int customer_id = (int)HttpContext.Session.GetInt32("customer_id");
            int customer_id = Int32.Parse(Request.Cookies["customer_id"].ToString());
            var cart_item = _context.cart_Items.Where(c => c.customer_cart_id == customer_id).ToList();
            foreach (var c in cart_item)
            {
                var temp = _context.item_Details.Where(p => p.product_id == c.product_cart_id).FirstOrDefault();
                await this.Update_order_detail(temp.product_id);
            }
             _context.cart_Items.RemoveRange(_context.cart_Items.Where(x => x.customer_cart_id == customer_id));
            _context.SaveChanges();

            string redirect_url = "https://localhost:44326/";
            return Redirect(redirect_url);

        }


        public async Task Update_order_detail(int id)
        {
            var item_detail = await _context.item_Details.FindAsync(id);
            //var customer_id = HttpContext.Session.GetInt32("customer_id");
            int customer_id = Int32.Parse(Request.Cookies["customer_id"].ToString());

            int quentity = item_detail.product_quantity - 1;
            var item = await _context.item_Details.FindAsync(id);
            item.product_quantity = quentity;

            customer customer_detail = await _context.customers
                .FirstOrDefaultAsync(m => m.customer_id == customer_id);

            System.Diagnostics.Debug.WriteLine("customer_id" + item.product_quantity);
            //item.buyers_list.Add(customer_detail);


            order order = new order
            {
                customer_id = (int)customer_id,
                seller_id = item_detail.seller_id,
                product_id = item_detail.product_id,
                order_date = DateTime.Now,
                delivery_date = DateTime.Now.AddDays(5),
                order_status = "success",
                total_pricer = item_detail.product_price,

            };
            _context.order.Add(order);
            _context.SaveChanges();

            //_context.item_Details.Attach(item);
            //_context.Entry(item).Property(x => x.product_quantity);
            _context.item_Details.Update(item);
            _context.SaveChanges();


           
        }



        public async Task<IActionResult> remove_fro_cart(int id)
        {
            var customer_cart_item = await _context.cart_Items
                .FirstOrDefaultAsync(m => m.product_cart_id == id);

            var customer_cart_item_1 = await _context.cart_Items.FindAsync(customer_cart_item.id);
            _context.cart_Items.Remove(customer_cart_item);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

            return View();
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
