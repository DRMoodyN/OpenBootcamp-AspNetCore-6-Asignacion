using System;

namespace Repository.RepositoryGeneric
{
    public class RepositoryGeneric<T> : IRepositoryGeneric<T> where T : class
    {
        private readonly UnivercityContext _context;
        private readonly DbSet<T> _dbSet;

        public RepositoryGeneric(UnivercityContext repository)
        {
            _context = repository;
            _dbSet = _context.Set<T>();
        }

        public async Task AddAsync(T entity) => await _dbSet.AddAsync(entity);

        public async Task<bool> AnyEntityAsync(Expression<Func<T, bool>> predicate)
        {
            return await _dbSet.AnyAsync(predicate);
        }

        public async Task ExecProcedure(string query)
        {
            await _context.Database.ExecuteSqlRawAsync(query);
        }

        public IQueryable<T> GetAllIncludeAsync<K>(Expression<Func<T, bool>> predicate = null, Expression<Func<T, K>> keySelector = null, string includeProperty = "")
        {
            IQueryable<T> query = _dbSet;
            query = query.Where(predicate).OrderBy(keySelector).AsNoTracking();

            foreach (var include in includeProperty.Split
               (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(include);
            }
            return query;
        }

        public void Update(T entity)
        {
            // Modificar solo algunos atributos
            _context.Entry(entity).State = EntityState.Detached;
            _context.Entry(entity).State = EntityState.Modified;
        }
    }
}
