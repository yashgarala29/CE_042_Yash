using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using wddn_online_shopping.Models.additional_field;
using wddn_online_shopping.Models.context_class;
using wddn_online_shopping.Models.model_class;
using wddn_online_shopping.view_model;

namespace wddn_online_shopping
{
    public class sellersController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<customer_identity> userManager;
        private readonly SignInManager<customer_identity> signInManager;
        private readonly IWebHostEnvironment hostingEnvironment;


        public sellersController( IWebHostEnvironment webHostEnvironment,UserManager<customer_identity> userManager,
            SignInManager<customer_identity> signInManager, AppDbContext context)
        {
            _context = context;
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.hostingEnvironment = webHostEnvironment;
        }
        //HomePage
        public IActionResult HomePage()
        {
            var seller_id = HttpContext.Session.GetInt32("seller_id");

            var Model = _context.item_Details.Where(m => m.seller_id == seller_id).ToList();

            return View(Model);
        }
        public IActionResult order_detail()
        {
            var seller_id = HttpContext.Session.GetInt32("seller_id");

            var Model = _context.order.Where(m => m.seller_id == seller_id).ToList();

            return View(Model);
        }
        public IActionResult order_full_detail(int id)
        {
            var seller_id = HttpContext.Session.GetInt32("seller_id");
            var Model =  _context.order.Where(m => m.order_id == id).FirstOrDefault();
            System.Diagnostics.Debug.WriteLine("Model.seller_id" + Model.seller_id);  
            ViewBag.seller_detail= _context.sellers.Where(m => m.seller_id==Model.seller_id).FirstOrDefault();
            ViewBag.buyers_detail = _context.customers.Where(m => m.customer_id == Model.customer_id).FirstOrDefault();
            ViewBag.order_detail = Model;
            ViewBag.item_detail = _context.item_Details.Where(m => m.product_id == Model.product_id).FirstOrDefault();    
            return View();
        }

        //---------------------------------------------
        // GET: customers/Create
        public IActionResult login_seller()
        {
            return View();
        }

        // POST: customers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]

        public async Task<IActionResult> login_seller(login_seller model)
        {
            if (ModelState.IsValid)
            {
                
                var result = await signInManager.PasswordSignInAsync(
                    model.seller_email, model.seller_password, model.RememberMe, false);

                if (result.Succeeded)
                {
                    int id = await getuserAsync(model.seller_email);
                    HttpContext.Session.SetInt32("seller_id", id);

                    return RedirectToAction("Homepage", "sellers");
                }
                ModelState.AddModelError(string.Empty, "Invalid Login Attempt");
            }
            return View(model);

        }
        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Homepage", "sellers");
        }

        //------------------------------------

        // GET: sellers
        public async Task<IActionResult> Index()
        {
            return View(await _context.sellers.ToListAsync());
        }

        // GET: sellers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var seller = await _context.sellers
                .FirstOrDefaultAsync(m => m.seller_id == id);
            if (seller == null)
            {
                return NotFound();
            }

            return View(seller);
        }

        // GET: sellers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: sellers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("seller_id,seller_name,seller_email,seller_password,seller_confirm_password,seller_mobile_no,seller_shop_address,seller_image")] seller_view_model seller)
        {
           
            if (ModelState.IsValid)
            {

                string uniqe_filename = null;
                if(seller.seller_image!= null)
                {
                    string uplodefolder = Path.Combine(hostingEnvironment.WebRootPath, "seller_image");
                    uniqe_filename = Guid.NewGuid().ToString() + "_" + seller.seller_image.FileName;
                    String filePath = Path.Combine(uplodefolder, uniqe_filename);
                    
                    seller.seller_image.CopyTo(new FileStream(filePath, FileMode.Create));

                };
                var user = new customer_identity
                {
                    seller_email = seller.seller_email,
                    seller_name = seller.seller_name,
                    seller_shop_address = seller.seller_shop_address,
                    seller_mobile_no = seller.seller_mobile_no,
                    UserName = seller.seller_email,
                    account_type = "seller",

                };
                seller new_seller = new seller
                {
                    seller_email = seller.seller_email,
                    seller_name = seller.seller_name,
                    seller_shop_address = seller.seller_shop_address,
                    seller_mobile_no = seller.seller_mobile_no,
                    seller_password=seller.seller_password,
                    seller_image=uniqe_filename,
                    seller_confirm_password=seller.seller_confirm_password,

                };
                var result = await userManager.CreateAsync(user, seller.seller_password);
                if (result.Succeeded)
                {
                    _context.Add(new_seller);
                    await _context.SaveChangesAsync();
                    await signInManager.SignInAsync(user, isPersistent: false);
                    int id = await getuserAsync(seller.seller_email);
                    HttpContext.Session.SetInt32("seller_id", id);

                    return RedirectToAction("Homepage", "sellers");

                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }

            }
            return View(seller);
        }

        // GET: sellers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var seller = await _context.sellers.FindAsync(id);
            if (seller == null)
            {
                return NotFound();
            }
            return View(seller);
        }
        public async Task<int> getuserAsync(string username)
        {
            var seller = await _context.sellers
               .FirstOrDefaultAsync(m => m.seller_email == username);
            return seller.seller_id;
        }
        // POST: sellers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("seller_id,seller_name,seller_email,seller_password,seller_confirm_password,seller_mobile_no,seller_shop_address,seller_image")] seller seller)
        {
            if (id != seller.seller_id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(seller);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!sellerExists(seller.seller_id))
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
            return View(seller);
        }

        // GET: sellers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var seller = await _context.sellers
                .FirstOrDefaultAsync(m => m.seller_id == id);
            if (seller == null)
            {
                return NotFound();
            }

            return View(seller);
        }

        // POST: sellers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var seller = await _context.sellers.FindAsync(id);
            _context.sellers.Remove(seller);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool sellerExists(int id)
        {
            return _context.sellers.Any(e => e.seller_id == id);
        }
    }
}
