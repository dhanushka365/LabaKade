using LabaKade.Services.CouponAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace LabaKade.Services.CouponAPI.Data
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {
        
        }

        public DbSet<Coupon> Coupons { get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Coupon>().HasData(new Coupon
            {
                CouponId = 1,
                CouponCode = "A001",
                DiscountAmount =10,
                MinAmount =20

            });

            modelBuilder.Entity<Coupon>().HasData(new Coupon
            {
                CouponId = 2,
                CouponCode = "A002",
                DiscountAmount = 20,
                MinAmount = 30

            });
        }
    }
}
