using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using wddn_online_shopping.Models.additional_field;
using wddn_online_shopping.Models.context_class;
using wddn_online_shopping.Models.model_class;
using wddn_online_shopping.view_model;

namespace wddn_online_shopping
{
    public class customersController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<customer_identity> userManager;
        private readonly SignInManager<customer_identity> signInManager;
        private readonly IWebHostEnvironment hostingEnvironment;

        public customersController(IWebHostEnvironment webHostEnvironment, UserManager<customer_identity> userManager,
            SignInManager<customer_identity> signInManager, AppDbContext context)
        {
            _context = context;
            this.userManager = userManager;
            this.signInManager=signInManager;
            this.hostingEnvironment = webHostEnvironment;
        }

        public IActionResult item_detail(int id)
        {
            var model=_context.item_Details.Where(m => m.product_id == id).FirstOrDefault();
            return View(model);
        }

        // GET: customers
        public async Task<IActionResult> Index()
        {
            return View(await _context.customers.ToListAsync());
        }
        //https://localhost:44326/customers/login_customer---------------------------------------------
        // GET: customers/Create
        public IActionResult login_customer()
        {
            return View();
        }
        
        public async Task<RedirectResult> add_to_cart(int id)
        {
            int customer_id = (int)HttpContext.Session.GetInt32("customer_id");
            customer_cart_item customer_Cart_Item = new customer_cart_item
            {
                customer_cart_id = customer_id,
                product_cart_id = id
            };
            _context.cart_Items.Add(customer_Cart_Item);
            
            await _context.SaveChangesAsync();


            string redirect_url = "https://localhost:44326/customers/item_detail/" + id;
            return Redirect(redirect_url);

            //return View(Response.Redirect(Request.RawUrl));
        }
        // POST: customers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]

        public async Task<IActionResult> login_customer( login_customer model)
        {
            if (ModelState.IsValid)
            {
                var result = await signInManager.PasswordSignInAsync(
                    model.customer_email, model.customer_password, model.RememberMe, false);
                
                if (result.Succeeded)
                {
                    int id = await getuserAsync(model.customer_email);
                    HttpContext.Session.SetInt32("customer_id", id);

                    return RedirectToAction("index", "home");
                }
                ModelState.AddModelError(string.Empty, "Invalid Login Attempt");
            }
            return View(model);

        }
        public async Task<int> getuserAsync(string username)
        {
            var seller = await _context.customers
               .FirstOrDefaultAsync(m => m.customer_email == username);
            return seller.customer_id;
        }
        public IActionResult order_detail()
        {
            var customer_id = HttpContext.Session.GetInt32("customer_id");

            var Model = _context.order.Where(m => m.customer_id == customer_id).ToList();

            return View(Model);
        }
        public IActionResult order_full_detail(int id)
        {
            var seller_id = HttpContext.Session.GetInt32("customer_id");
            var Model = _context.order.Where(m => m.order_id == id).FirstOrDefault();
            System.Diagnostics.Debug.WriteLine("Model.seller_id" + Model.seller_id);
            ViewBag.seller_detail = _context.sellers.Where(m => m.seller_id == Model.seller_id).FirstOrDefault();
            ViewBag.buyers_detail = _context.customers.Where(m => m.customer_id == Model.customer_id).FirstOrDefault();
            ViewBag.order_detail = Model;
            ViewBag.item_detail = _context.item_Details.Where(m => m.product_id == Model.product_id).FirstOrDefault();
            return View();
        }
        //------------------------------------

        // GET: customers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer = await _context.customers
                .FirstOrDefaultAsync(m => m.customer_id == id);
            if (customer == null)
            {
                return NotFound();
            }

            return View(customer);
        }

        // GET: customers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: customers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]

        public async Task<IActionResult> Create([Bind("customer_id,customer_name,customer_email,customer_password,customer_confirm_password,customer_mobile_no,customer_address,customer_image")] customer_view_model customer)
        {
            String uniqe_filename = null;
            if (ModelState.IsValid)
            {
                if (customer.customer_image != null)
                {
                    string uplodefolder = Path.Combine(hostingEnvironment.WebRootPath, "customer_image");
                    uniqe_filename = Guid.NewGuid().ToString() + "_" + customer.customer_image.FileName;
                    String filePath = Path.Combine(uplodefolder, uniqe_filename);

                    customer.customer_image.CopyTo(new FileStream(filePath, FileMode.Create));

                };
                var user = new customer_identity
                {
                    customer_email = customer.customer_email,
                    customer_name = customer.customer_name,
                    customer_address = customer.customer_address,
                    customer_mobile_no = customer.customer_mobile_no,
                    account_type="customer",
                    UserName= customer.customer_email,
                    
                };
                customer new_customer = new customer
                {
                    customer_email = customer.customer_email,
                    customer_name = customer.customer_name,
                    customer_address = customer.customer_address,
                    customer_mobile_no = customer.customer_mobile_no,
                    customer_password = customer.customer_password,
                    customer_image = uniqe_filename,
                    customer_confirm_password = customer.customer_confirm_password,

                };
                var result = await userManager.CreateAsync(user, customer.customer_password);
                if(result.Succeeded)
                {
                    _context.Add(new_customer);
                    await _context.SaveChangesAsync();

                    int id = await getuserAsync(customer.customer_email);
                    HttpContext.Session.SetInt32("customer_id", id);



                    await signInManager.SignInAsync(user, isPersistent: false);
                    return RedirectToAction("index", "home");

                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }

            }
            return View(customer);
        }
        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("index", "home");
        }

        //--------------------------------------

        // GET: customers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer = await _context.customers.FindAsync(id);
            if (customer == null)
            {
                return NotFound();
            }
            return View(customer);
        }

        // POST: customers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("customer_id,customer_name,customer_email,customer_password,customer_confirm_password,customer_mobile_no,customer_address,customer_image")] customer customer)
        {
            if (id != customer.customer_id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(customer);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!customerExists(customer.customer_id))
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
            return View(customer);
        }

        // GET: customers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer = await _context.customers
                .FirstOrDefaultAsync(m => m.customer_id == id);
            if (customer == null)
            {
                return NotFound();
            }

            return View(customer);
        }

        // POST: customers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var customer = await _context.customers.FindAsync(id);
            _context.customers.Remove(customer);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool customerExists(int id)
        {
            return _context.customers.Any(e => e.customer_id == id);
        }
    }
}
