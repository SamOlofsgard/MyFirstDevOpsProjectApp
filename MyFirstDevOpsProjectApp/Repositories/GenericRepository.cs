using Microsoft.EntityFrameworkCore;
using MyFirstDevOpsProjectApp.Models;

namespace MyFirstDevOpsProjectApp.Repositories
{
    public abstract class GenericRepository<TEntity> where TEntity : class
    {
        private readonly DataContext _context;

        protected GenericRepository(DataContext context)
        {
            _context = context;
        }

        protected virtual async Task<TEntity> CreateAsync(TEntity entity)
        {
            if(entity != null)
            {
                await _context.AddAsync(entity);
                await _context.SaveChangesAsync();
                return entity;
            }

            return null;
        }

        protected virtual async Task<List<TEntity>> GetAllAsync()
        {
            return await _context.Set<TEntity>().ToListAsync();
        }

        protected virtual async Task<TEntity> GetAllAsync(int id)
        {
            var entity = await _context.Set<TEntity>().FindAsync(id);
            if (entity != null)
                return entity;

            return null;
        }

        protected virtual async Task<TEntity> GetAllAsync(string id)
        {
            var _entity = await _context.Set<TEntity>().FindAsync(id);
            if (_entity != null)
                return _entity;

            return null;
        }

        protected virtual async Task<TEntity> UpdateeAsync(int id, TEntity entity)
        {
            var _entity = await _context.Set<TEntity>().FindAsync(id);
            if (_entity != null)
            {
                _context.Entry(entity).State = EntityState.Modified;
                await _context.SaveChangesAsync();

                return _entity;
            }
                

            return null;
        }

        protected virtual async Task<bool> RemoveAsync(int id)
        {
            var _entity = await _context.Set<TEntity>().FindAsync(id);
            if(_entity != null)
            {
                _context.Remove(_entity);
                await _context.SaveChangesAsync();
                return true;
            }

            return false;
        }

        protected virtual async Task<bool> RemoveAsync(string id)
        {
            var _entity = await _context.Set<TEntity>().FindAsync(id);
            if (_entity != null)
            {
                _context.Remove(_entity);
                await _context.SaveChangesAsync();
                return true;
            }

            return false;
        }

    }
}
