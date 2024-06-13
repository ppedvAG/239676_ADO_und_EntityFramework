using YummyInMyTummy.Model.Contracts;
using YummyInMyTummy.Model.Domain;

namespace YummyInMyTummy.Logic
{
    public class OrderService : IOrderService
    {
        private IRepository repo;

        public OrderService(IRepository repo)
        {
            this.repo = repo;
        }

        public Order PlaceOrder(Order order)
        {
            //todo validtae order

            order.Status = OrderStatus.Accepted;
            repo.Add(order);
            repo.SaveAll();

            return order;
        }

        public IEnumerable<Order> GetOpenOrders()
        {
            return repo.GetAll<Order>().Where(x => x.Status >= 0).OrderBy(x => x.OrderDate).ToList();
        }
    }
}
