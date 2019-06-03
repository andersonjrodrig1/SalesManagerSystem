using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagerSystem.Repositories.Connection
{
    public class Connection<TEntity> : IDisposable where TEntity : class
    {
        protected readonly DbContext _dbContext;

        public Connection(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<TEntity>> GetAll()
        {
            IEnumerable<TEntity> entities = await _dbContext.Set<TEntity>().ToListAsync();

            return entities;
        }
        
        public TEntity Save(TEntity entity)
        {
            TEntity _entity = _dbContext.Set<TEntity>().Add(entity);
            _dbContext.SaveChanges();

            return _entity;
        }

        public TEntity Update(TEntity entity)
        {
            _dbContext.Entry<TEntity>(entity).State = EntityState.Modified;
            _dbContext.SaveChanges();

            return entity;
        }

        public void Remove(TEntity entity)
        {
            _dbContext.Set<TEntity>().Remove(entity);
            _dbContext.SaveChanges();
        }

        public void Dispose()
        {
            _dbContext.Dispose();
        }
    }
}
