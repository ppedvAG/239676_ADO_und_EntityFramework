using YummyInMyTummy.Model.Domain;

namespace YummyInMyTummy.Model.Contracts
{
    public interface IRepository<T> where T : Entity
    {
        IEnumerable<T> GetAll();
        IQueryable<T> Query();
        T? GetById(int id);
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
    }

    public interface IOrderRepo : IRepository<Order>
    {
        IEnumerable<Order> GetOrdersFromToday();
    }

    public interface IUnitOfWork
    {
        public IOrderRepo OrderRepo { get; }
        public IRepository<Address> AdressRepo { get; }
        public IRepository<Food> FoodRepo { get; }

        int SaveAll();

    }
}
