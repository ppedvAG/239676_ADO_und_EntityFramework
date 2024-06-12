using Microsoft.EntityFrameworkCore;
using YummyInMyTummy.Model.Domain;

namespace YummyInMyTummy.Data.EfCore
{
    public class EfContext : DbContext
    {
        public EfContext(DbContextOptions<EfContext> options) : base(options)
        {
        }

        public DbSet<Address> Addresses { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Food> Foods { get; set; }
        public DbSet<Pizza> Pizzas { get; set; }
        public DbSet<Topping> Toppings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>().HasOne(x => x.PaymentAddress).WithMany(x => x.AsPayment);
            modelBuilder.Entity<Order>().HasOne(x => x.DeliveryAddress).WithMany(x => x.AsDelivery);

            modelBuilder.Entity<Food>().UseTptMappingStrategy();
        }
    }
}
