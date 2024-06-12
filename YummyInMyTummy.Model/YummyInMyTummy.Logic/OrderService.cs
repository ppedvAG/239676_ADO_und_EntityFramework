using YummyInMyTummy.Model.Contracts;
using YummyInMyTummy.Model.Domain;

namespace YummyInMyTummy.Logic
{
    public class OrderService
    {
        private IRepository repo;

        public OrderService(IRepository repo)
        {
            this.repo = repo;
        }

        public IEnumerable<Order> GetOpenOrders()
        {
            return repo.GetAll<Order>().Where(x => x.Status >= 0).OrderBy(x => x.OrderDate).ToList();
        }
    }
}
