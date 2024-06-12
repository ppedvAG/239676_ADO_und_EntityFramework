using Moq;
using YummyInMyTummy.Model.Contracts;
using YummyInMyTummy.Model.Domain;

namespace YummyInMyTummy.Logic.Tests
{
    public class OrderServiceTests
    {
        [Fact]
        public void GetOpenOrders_is_order_of_3_correct()
        {
            var os = new OrderService(new TestRepo());

            var result = os.GetOpenOrders();

            Assert.Equal("o2", result.ElementAt(0).PaymentAddress.Name1);
            Assert.Equal("o3", result.ElementAt(1).PaymentAddress.Name1);
            Assert.Equal("o1", result.ElementAt(2).PaymentAddress.Name1);
        }

        [Fact]
        public void GetOpenOrders_is_order_of_3_correct_moq()
        {
            var o1 = new Order() { OrderDate = DateTime.Now, PaymentAddress = new Address() };
            var o2 = new Order() { OrderDate = DateTime.Now.AddMinutes(-60), PaymentAddress = new Address() };
            var o3 = new Order() { OrderDate = DateTime.Now.AddMinutes(-30), PaymentAddress = new Address() };

            var mock = new Mock<IRepository>();
            mock.Setup(x => x.GetAll<Order>()).Returns(() => [o1, o2, o3]);

            var os = new OrderService(mock.Object);


            var result = os.GetOpenOrders();


            Assert.Equal(o2, result.ElementAt(0));
            Assert.Equal(o3, result.ElementAt(1));
            Assert.Equal(o1, result.ElementAt(2));
        }
    }

    class TestRepo : IRepository
    {
        public void Add<T>(T entity) where T : Entity
        {
            throw new NotImplementedException();
        }

        public void Delete<T>(T entity) where T : Entity
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll<T>() where T : Entity
        {
            if (typeof(T) == typeof(Order))
            {
                var o1 = new Order() { OrderDate = DateTime.Now, PaymentAddress = new Address() { Name1 = "o1" } };
                var o2 = new Order() { OrderDate = DateTime.Now.AddMinutes(-60), PaymentAddress = new Address() { Name1 = "o2" } };
                var o3 = new Order() { OrderDate = DateTime.Now.AddMinutes(-30), PaymentAddress = new Address() { Name1 = "o3" } };
                return new[] { o1, o2, o3 }.Cast<T>();
            }
            throw new NotImplementedException();
        }

        public T? GetById<T>(int id) where T : Entity
        {
            throw new NotImplementedException();
        }

        public int SaveAll()
        {
            throw new NotImplementedException();
        }

        public void Update<T>(T entity) where T : Entity
        {
            throw new NotImplementedException();
        }
    }
}