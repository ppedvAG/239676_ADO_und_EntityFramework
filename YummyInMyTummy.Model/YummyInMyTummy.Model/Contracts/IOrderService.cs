using YummyInMyTummy.Model.Domain;

namespace YummyInMyTummy.Logic
{
    public interface IOrderService
    {
        IEnumerable<Order> GetOpenOrders();
        Order PlaceOrder(Order order);
    }
}