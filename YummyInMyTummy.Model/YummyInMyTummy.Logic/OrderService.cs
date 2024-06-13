using YummyInMyTummy.Model.Contracts;
using YummyInMyTummy.Model.Domain;

namespace YummyInMyTummy.Logic
{
    public class OrderService : IOrderService
    {
        private IUnitOfWork repo;

        public OrderService(IUnitOfWork repo)
        {
            this.repo = repo;
        }

        public Order PlaceOrder(Order order)
        {
            //todo validtae order

            order.Status = OrderStatus.Accepted;
            repo.OrderRepo.Add(order);
            repo.SaveAll();

            return order;
        }

        public IEnumerable<Order> GetOpenOrders()
        {
            return repo.OrderRepo.GetAll().Where(x => x.Status >= 0).OrderBy(x => x.OrderDate).ToList();
        }
    }
}
