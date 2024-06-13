using Microsoft.EntityFrameworkCore;
using YummyInMyTummy.Model.Contracts;
using YummyInMyTummy.Model.Domain;

namespace YummyInMyTummy.Data.EfCore
{
    public class EfUnitOfWork : IUnitOfWork
    {
        EfContext _context;
        public EfUnitOfWork(DbContextOptions<EfContext> options)
        {
            _context = new EfContext(options);
        }
        public IOrderRepo OrderRepo { get => new EfOrderRepo(_context); }
        public IRepository<Address> AdressRepo { get => new EfRepository<Address>(_context); }
        public IRepository<Food> FoodRepo { get => new EfRepository<Food>(_context); }


        public int SaveAll()
        {
            return _context.SaveChanges();
        }

    }

    public class EfOrderRepo : EfRepository<Order>, IOrderRepo
    {
        public EfOrderRepo(EfContext context) : base(context)
        { }

        public IEnumerable<Order> GetOrdersFromToday()
        {
            return _context.GetOrdersFromTodayBySP();
        }
    }

    public class EfRepository<T> : IRepository<T> where T : Entity
    {
        protected readonly EfContext _context;

        public EfRepository(EfContext context)
        {
            this._context = context;
        }

        public void Add(T entity)
        {
            _context.Add(entity);
        }

        public void Delete(T entity)
        {
            _context.Remove(entity);
        }

        public IEnumerable<T> GetAll()
        {
            return _context.Set<T>();
        }

        public T? GetById(int id)
        {
            return _context.Find<T>(id);
        }


        public IQueryable<T> Query()
        {
            return _context.Set<T>();
        }

        public void Update(T entity)
        {
            _context.Update(entity);
        }
    }
}
