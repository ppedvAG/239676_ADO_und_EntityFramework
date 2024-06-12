using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Contracts;
using YummyInMyTummy.Model.Domain;

namespace YummyInMyTummy.Data.EfCore.Tests
{
    public class EfContextTests
    {
        public EfContext CreateContext()
        {
            string conString = "Server=(localdb)\\mssqllocaldb;Database=YummyInMyTummy_TestDb;Trusted_Connection=true;TrustServerCertificate=true;";
            var optionsBuilder = new DbContextOptionsBuilder<EfContext>();
            optionsBuilder.UseSqlServer(conString);

            return new EfContext(optionsBuilder.Options);
        }

        [Fact]
        public void Can_create_Db()
        {
            var con = CreateContext();
            con.Database.EnsureDeleted();

            var result = con.Database.EnsureCreated();

            Assert.True(result);
        }

        [Fact]
        public void Can_add_Pizza()
        {
            var con = CreateContext();
            con.Database.EnsureCreated();

            var pizza = new Pizza() { Name = "Testpizza #1" };
            con.Add(pizza);
            var rows = con.SaveChanges();

            Assert.Equal(2, rows);
        }

        [Fact]
        public void Can_add_Pizza_with_Sizes()
        {
            var con = CreateContext();
            con.Database.EnsureCreated();

            var pizza = new Pizza() { Name = "Testpizza #2" };
            pizza.OfferedSizes.Add(PizzaSize.r33cm);
            pizza.OfferedSizes.Add(PizzaSize.r40cm);
            con.Add(pizza);
            var rows = con.SaveChanges();

            Assert.Equal(2, rows);
        }

        [Fact]
        public void Can_read_Pizza_with_Sizes()
        {
            var pizza = new Pizza() { Name = "Testpizza #3" };
            pizza.OfferedSizes.Add(PizzaSize.r33cm);
            pizza.OfferedSizes.Add(PizzaSize.r40cm);

            using (var con = CreateContext())
            {
                con.Database.EnsureCreated();
                con.Add(pizza);
                con.SaveChanges();
            }

            using (var con = CreateContext())
            {
                var loaded = con.Find<Pizza>(pizza.Id);
                Assert.NotNull(loaded);
                Assert.Contains(PizzaSize.r33cm, pizza.OfferedSizes);
                Assert.Contains(PizzaSize.r40cm, pizza.OfferedSizes);
                Assert.DoesNotContain(PizzaSize.r28cm, pizza.OfferedSizes);
                Assert.DoesNotContain(PizzaSize.s33x46cm, pizza.OfferedSizes);
                Assert.DoesNotContain(PizzaSize.s60x40cm, pizza.OfferedSizes);
           }
        }
    }
}