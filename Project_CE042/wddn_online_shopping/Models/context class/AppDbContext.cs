
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using wddn_online_shopping.Models.additional_field;
using wddn_online_shopping.Models.model_class;

namespace wddn_online_shopping.Models.context_class
{
    public class AppDbContext : IdentityDbContext<customer_identity>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            :base(options)
        {

        }
        public DbSet<customer> customers { get; set;}
        public DbSet<item_detail> item_Details { get; set; }
        public DbSet<seller> sellers { get; set; }
        public DbSet<customer_cart_item> cart_Items { get; set; }
        public DbSet<order> order { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //modelBuilder.Seed();
        }
    }
}
