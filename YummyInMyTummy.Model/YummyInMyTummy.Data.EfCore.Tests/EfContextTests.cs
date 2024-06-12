using AutoFixture;
using AutoFixture.Kernel;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using YummyInMyTummy.Model.Domain;
using FluentAssertions;

namespace YummyInMyTummy.Data.EfCore.Tests
{
    public class EfContextTests
    {
        public EfContext CreateContext()
        {
            string conString = "Server=(localdb)\\mssqllocaldb;Database=YummyInMyTummy_TestDb;Trusted_Connection=true;TrustServerCertificate=true;";
            var optionsBuilder = new DbContextOptionsBuilder<EfContext>();
            optionsBuilder.UseSqlServer(conString);
            optionsBuilder.UseLazyLoadingProxies();

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
            var pizza = new Pizza() { Name = $"Testpizza #3 {Guid.NewGuid()}" };
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
                Assert.Equal(pizza.Name, loaded.Name);
                Assert.Contains(PizzaSize.r33cm, pizza.OfferedSizes);
                Assert.Contains(PizzaSize.r40cm, pizza.OfferedSizes);
                Assert.DoesNotContain(PizzaSize.r28cm, pizza.OfferedSizes);
                Assert.DoesNotContain(PizzaSize.s33x46cm, pizza.OfferedSizes);
                Assert.DoesNotContain(PizzaSize.s60x40cm, pizza.OfferedSizes);
            }
        }

        [Fact]
        public void Can_update_Pizza()
        {
            var pizza = new Pizza() { Name = $"Testpizza #4 {Guid.NewGuid()}" };
            var newName = $"Updatepizza #4 {Guid.NewGuid()}";

            using (var con = CreateContext())
            {
                con.Database.EnsureCreated();
                con.Add(pizza);
                con.SaveChanges();
            }

            using (var con = CreateContext())
            {
                var loaded = con.Find<Pizza>(pizza.Id);
                loaded.Name = newName;
                var rows = con.SaveChanges();
                Assert.Equal(1, rows);
            }

            using (var con = CreateContext())
            {
                var loaded = con.Find<Pizza>(pizza.Id);
                Assert.Equal(newName, loaded.Name);
            }
        }

        [Fact]
        public void Can_delete_Pizza()
        {
            var pizza = new Pizza() { Name = $"Testpizza #5 {Guid.NewGuid()}" };

            using (var con = CreateContext())
            {
                con.Database.EnsureCreated();
                con.Add(pizza);
                con.SaveChanges();
            }

            using (var con = CreateContext())
            {
                var loaded = con.Find<Pizza>(pizza.Id);
                con.Remove(loaded);
                var rows = con.SaveChanges();
                Assert.Equal(2, rows);
            }

            using (var con = CreateContext())
            {
                var loaded = con.Find<Pizza>(pizza.Id);
                Assert.Null(loaded);
            }
        }


        [Fact]
        public void Can_create_and_read_Pizza_with_AutoFixture()
        {
            var fix = new Fixture();
            fix.Behaviors.Add(new OmitOnRecursionBehavior());
            fix.Customizations.Add(new PropertyNameOmitter(nameof(Entity.Id)));
            var pizza = fix.Create<Pizza>();

            using (var con = CreateContext())
            {
                con.Database.EnsureCreated();
                con.Add(pizza);
                con.SaveChanges();
            }

            using (var con = CreateContext())
            {
                //eager loading 
                //var loaded = con.Pizzas.Include(x => x.Toppings).ThenInclude(x => x.OrderItems).ThenInclude(x => x.Order).ThenInclude(x => x.DeliveryAddress)
                //                       .Include(x => x.Toppings).ThenInclude(x => x.OrderItems).ThenInclude(x => x.Order).ThenInclude(x => x.PaymentAddress)
                //                       .Include(x => x.OrderItems).ThenInclude(x => x.Order).ThenInclude(x => x.DeliveryAddress)
                //                       .Include(x => x.OrderItems).ThenInclude(x => x.Order).ThenInclude(x => x.PaymentAddress)
                //                       .Where(x => x.Id == pizza.Id)
                //                       .FirstOrDefault();


                //lazy loading 
                var loaded = con.Pizzas.Find(pizza.Id);

                loaded.Should().NotBeNull();
                loaded.Should().BeEquivalentTo(pizza, x => x.IgnoringCyclicReferences());
            }
        }
    }

    internal class PropertyNameOmitter : ISpecimenBuilder
    {
        private readonly IEnumerable<string> names;

        internal PropertyNameOmitter(params string[] names)
        {
            this.names = names;
        }

        public object Create(object request, ISpecimenContext context)
        {
            var propInfo = request as PropertyInfo;
            if (propInfo != null && names.Contains(propInfo.Name))
                return new OmitSpecimen();

            return new NoSpecimen();
        }
    }
}