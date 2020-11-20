using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using wddn_online_shopping.Models;
using wddn_online_shopping.Models.additional_field;
using wddn_online_shopping.Models.context_class;

namespace wddn_online_shopping.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AppDbContext _context;
        private readonly SignInManager<customer_identity> signinmanager;


        public HomeController(ILogger<HomeController> logger, AppDbContext context)
        {
            _logger = logger;
            _context = context;
            

        }
        
        public async Task<IActionResult> Index()
        {
            return View(await _context.item_Details.ToListAsync());
        }

        public void Add_to_cart(int? id)
        {
            System.Diagnostics.Debug.WriteLine("id"+id);
            //return View("Index");
        }

        public async Task<IActionResult> Buy(int ?id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var model = await _context.item_Details
                .FirstOrDefaultAsync(m => m.product_id == id);
            if (model == null)
            {
                return NotFound();
            }

            return View(model);
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
