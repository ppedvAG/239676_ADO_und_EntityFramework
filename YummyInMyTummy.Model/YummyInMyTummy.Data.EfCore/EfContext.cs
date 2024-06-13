using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using YummyInMyTummy.Model.Domain;

namespace YummyInMyTummy.Data.EfCore
{
    public class EfContext : DbContext
    {
        public EfContext(DbContextOptions<EfContext> options) : base(options)
        {
            Database.Migrate();
        }

#if DEBUG
        public EfContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string conString = "Server=(localdb)\\mssqllocaldb;Database=YummyInMyTummy_TestDb;Trusted_Connection=true;TrustServerCertificate=true;";
            optionsBuilder.UseSqlServer(conString);
        }
#endif


        public DbSet<Address> Addresses { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Food> Foods { get; set; }
        public DbSet<Pizza> Pizzas { get; set; }
        public DbSet<Topping> Toppings { get; set; }


        public IEnumerable<Order> GetOrdersFromTodayBySP()
        {
            return Orders.FromSql($"EXECUTE[dbo].[GetTodayOrders]");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>().HasOne(x => x.PaymentAddress).WithMany(x => x.AsPayment);
            modelBuilder.Entity<Order>().HasOne(x => x.DeliveryAddress).WithMany(x => x.AsDelivery);

            modelBuilder.Entity<Food>().UseTptMappingStrategy();
        }
    }
}
