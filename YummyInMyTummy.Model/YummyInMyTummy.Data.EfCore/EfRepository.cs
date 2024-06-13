using Microsoft.EntityFrameworkCore;
using YummyInMyTummy.Model.Contracts;
using YummyInMyTummy.Model.Domain;

namespace YummyInMyTummy.Data.EfCore
{
    public class EfRepository : IRepository
    {
        EfContext _context;
        public EfRepository(DbContextOptions<EfContext> options)
        {
            _context = new EfContext(options);
        }

        public void Add<T>(T entity) where T : Entity
        {
            _context.Add(entity);
        }

        public void Delete<T>(T entity) where T : Entity
        {
            _context.Remove(entity);
        }

        public IEnumerable<T> GetAll<T>() where T : Entity
        {
            return _context.Set<T>();
        }

        public T? GetById<T>(int id) where T : Entity
        {
            return _context.Find<T>();
        }

        public IQueryable<T> Query<T>() where T : Entity
        {
            return _context.Set<T>();
        }

        public int SaveAll()
        {
            return _context.SaveChanges();
        }

        public void Update<T>(T entity) where T : Entity
        {
            _context.Update(entity);
        }
    }
}
