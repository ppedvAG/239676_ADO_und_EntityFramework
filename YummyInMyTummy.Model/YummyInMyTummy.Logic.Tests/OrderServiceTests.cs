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

        [Fact]
        public void GetOpenOrders_is_order_of_3_with_same_time_correct_moq()
        {
            var dt = DateTime.Now;
            var o1 = new Order() { Status = OrderStatus.New, OrderDate = dt, PaymentAddress = new Address() };
            var o2 = new Order() { Status = OrderStatus.Accepted, OrderDate = dt, PaymentAddress = new Address() };
            var o3 = new Order() { Status = OrderStatus.Preparing, OrderDate = dt, PaymentAddress = new Address() };
            var o4 = new Order() { Status = OrderStatus.Delivering, OrderDate = dt, PaymentAddress = new Address() };
            var o5 = new Order() { Status = OrderStatus.Delivered, OrderDate = dt, PaymentAddress = new Address() };
            var o6 = new Order() { Status = OrderStatus.Aborted, OrderDate = dt, PaymentAddress = new Address() };
            var o7 = new Order() { Status = OrderStatus.Declined, OrderDate = dt, PaymentAddress = new Address() };
            var o8 = new Order() { Status = OrderStatus.Lost, OrderDate = dt, PaymentAddress = new Address() };

            var mock = new Mock<IRepository>();
            mock.Setup(x => x.GetAll<Order>()).Returns(() => [o1, o2, o3, o4, o5, o6, o7, o8]);

            var os = new OrderService(mock.Object);


            var result = os.GetOpenOrders();

            Assert.Equal(4, result.Count());
        }


        [Fact]
        public void GetOpenOrders_NoOrders_ReturnsEmptyList()
        {
            var mock = new Mock<IRepository>();
            mock.Setup(x => x.GetAll<Order>()).Returns(() => new List<Order>());

            var os = new OrderService(mock.Object);

            var result = os.GetOpenOrders();

            Assert.Empty(result);
        }

        [Fact]
        public void GetOpenOrders_AllOrdersClosed_ReturnsEmptyList()
        {
            var o1 = new Order() { Status = OrderStatus.Delivered, OrderDate = DateTime.Now, PaymentAddress = new Address() };
            var o2 = new Order() { Status = OrderStatus.Aborted, OrderDate = DateTime.Now.AddMinutes(-60), PaymentAddress = new Address() };

            var mock = new Mock<IRepository>();
            mock.Setup(x => x.GetAll<Order>()).Returns(() => new List<Order> { o1, o2 });

            var os = new OrderService(mock.Object);

            var result = os.GetOpenOrders();

            Assert.Empty(result);
        }

        [Fact]
        public void GetOpenOrders_MixedOrderStatuses_ReturnsOnlyOpenOrders()
        {
            var o1 = new Order() { Status = OrderStatus.New, OrderDate = DateTime.Now, PaymentAddress = new Address() };
            var o2 = new Order() { Status = OrderStatus.Accepted, OrderDate = DateTime.Now.AddMinutes(-60), PaymentAddress = new Address() };
            var o3 = new Order() { Status = OrderStatus.Delivered, OrderDate = DateTime.Now.AddMinutes(-30), PaymentAddress = new Address() };

            var mock = new Mock<IRepository>();
            mock.Setup(x => x.GetAll<Order>()).Returns(() => new List<Order> { o1, o2, o3 });

            var os = new OrderService(mock.Object);

            var result = os.GetOpenOrders();

            Assert.Equal(2, result.Count());
            Assert.Contains(o1, result);
            Assert.Contains(o2, result);
        }

        [Fact]
        public void GetOpenOrders_OrdersSortedByDate_ReturnsSortedOrders()
        {
            var o1 = new Order() { Status = OrderStatus.New, OrderDate = DateTime.Now, PaymentAddress = new Address() };
            var o2 = new Order() { Status = OrderStatus.New, OrderDate = DateTime.Now.AddMinutes(-60), PaymentAddress = new Address() };
            var o3 = new Order() { Status = OrderStatus.New, OrderDate = DateTime.Now.AddMinutes(-30), PaymentAddress = new Address() };

            var mock = new Mock<IRepository>();
            mock.Setup(x => x.GetAll<Order>()).Returns(() => new List<Order> { o1, o2, o3 });

            var os = new OrderService(mock.Object);

            var result = os.GetOpenOrders();

            Assert.Equal(3, result.Count());
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

        public IEnumerable<Order> GetOrdersFromToday()
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> Query<T>() where T : Entity
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