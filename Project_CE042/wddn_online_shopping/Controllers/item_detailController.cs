using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using wddn_online_shopping.Models.context_class;
using wddn_online_shopping.Models.model_class;

namespace wddn_online_shopping
{
    public class item_detailController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment hostEnvironment;


        public item_detailController(AppDbContext context
           ,IWebHostEnvironment hostEnvironment )
        {
            _context = context;
            this.hostEnvironment = hostEnvironment;
        }
        public async Task<IActionResult> place_order(int  id)
        {
            var item_detail = await _context.item_Details.FindAsync(id);
            //var customer_id= HttpContext.Session.GetInt32("customer_id");
            int customer_id = Int32.Parse(Request.Cookies["customer_id"].ToString());
            if (item_detail == null)
            {
                return NotFound();
            }
            int quentity = item_detail.product_quantity-1;
            var item = await _context.item_Details.FindAsync(id);
            item.product_quantity = quentity;
           
            customer customer_detail= await _context.customers
                .FirstOrDefaultAsync(m => m.customer_id == customer_id);

            System.Diagnostics.Debug.WriteLine("customer_id"+item.product_quantity);
            //item.buyers_list.Add(customer_detail);


            order order = new order
            {
                customer_id=(int)customer_id,
                seller_id=item_detail.seller_id,
                product_id=item_detail.product_id,
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
            


            return RedirectToActionPermanentPreserveMethod(actionName:"index",controllerName:"home");
        }
        // GET: item_detail
        public async Task<IActionResult> Index()
        {
            return View(await _context.item_Details.ToListAsync());
        }

        // GET: item_detail/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var item_detail = await _context.item_Details
                .FirstOrDefaultAsync(m => m.product_id == id);
            if (item_detail == null)
            {
                return NotFound();
            }

            return View(item_detail);
        }

        // GET: item_detail/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: item_detail/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("product_id,product_name,product_quantity,product_price,product_description,product_image")] view_model.item_view_model item_detail)
        {
            //System.Diagnostics.Debug.WriteLine("seller.seller_image.FileName" + seller.seller_image.FileName);

            if (ModelState.IsValid)
            {
                //int seller_id = (int)HttpContext.Session.GetInt32("seller_id");
                int seller_id = Int32.Parse(Request.Cookies["seller_id"].ToString());
                System.Diagnostics.Debug.WriteLine("seller.seller_image.FileName" + seller_id);

                String uniqefileName = null;
                if(item_detail.product_image!=null)
                {
                    string uplodeFolder = Path.Combine(hostEnvironment.WebRootPath, "product_image");
                    uniqefileName = Guid.NewGuid().ToString() + "_" + item_detail.product_image.FileName;
                    string filepath = Path.Combine(uplodeFolder, uniqefileName);
                    item_detail.product_image.CopyTo(new FileStream(filepath, FileMode.Create));
                }
                item_detail item = new item_detail
                {
                    product_description = item_detail.product_description,
                    product_name=item_detail.product_name,
                    product_price=item_detail.product_price,
                    product_image=uniqefileName,
                    product_quantity=item_detail.product_quantity,
                    seller_id= seller_id,
                };
                _context.item_Details.Add(item);
                await _context.SaveChangesAsync();

                return RedirectToActionPermanentPreserveMethod(actionName: "Homepage", controllerName: "sellers");
            }
            return View(item_detail);
        }

        // GET: item_detail/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var item_detail = await _context.item_Details.FindAsync(id);
            if (item_detail == null)
            {
                return NotFound();
            }
            return View(item_detail);
        }

        // POST: item_detail/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("product_id,seller_id,product_name,product_quantity,product_price,product_description,product_image")] item_detail item_detail)
        {
            if (id != item_detail.product_id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(item_detail);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!item_detailExists(item_detail.product_id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToActionPermanentPreserveMethod(actionName: "Homepage", controllerName: "sellers");
            }
            return View(item_detail);
        }

        // GET: item_detail/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var item_detail = await _context.item_Details
                .FirstOrDefaultAsync(m => m.product_id == id);
            if (item_detail == null)
            {
                return NotFound();
            }

            return View(item_detail);
        }

        // POST: item_detail/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var item_detail = await _context.item_Details.FindAsync(id);
            _context.item_Details.Remove(item_detail);
            await _context.SaveChangesAsync();
            return RedirectToActionPermanentPreserveMethod(actionName: "Homepage", controllerName: "sellers");

        }

        private bool item_detailExists(int id)
        {
            return _context.item_Details.Any(e => e.product_id == id);
        }
    }
}
