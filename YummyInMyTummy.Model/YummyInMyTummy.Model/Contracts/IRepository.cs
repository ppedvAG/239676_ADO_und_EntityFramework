﻿using YummyInMyTummy.Model.Domain;

namespace YummyInMyTummy.Model.Contracts
{
    public interface IRepository
    {
        IEnumerable<T> GetAll<T>() where T : Entity;
        IQueryable<T> Query<T>() where T : Entity;
        T? GetById<T>(int id) where T : Entity;
        void Add<T>(T entity) where T : Entity;
        void Delete<T>(T entity) where T : Entity;
        void Update<T>(T entity) where T : Entity;
        int SaveAll();

        IEnumerable<Order> GetOrdersFromToday();
    }
}
