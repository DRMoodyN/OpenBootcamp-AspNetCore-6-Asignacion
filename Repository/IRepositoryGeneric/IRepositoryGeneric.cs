using System;

namespace Repository.IRepositoryGeneric
{
    public interface IRepositoryGeneric<T> where T : class
    {
        IQueryable<T> GetAllIncludeAsync<K>(Expression<Func<T, bool>> predicate = null,
                Expression<Func<T, K>> keySelector = null, string includeProperty = "");
        Task AddAsync(T entity);
        void Update(T entity);
        Task<bool> AnyEntityAsync(Expression<Func<T, bool>> predicate);
        Task ExecProcedure(string query);
    }
}
