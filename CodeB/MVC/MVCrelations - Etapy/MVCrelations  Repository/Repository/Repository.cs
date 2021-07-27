using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MVCrelations.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity: class
    {
        internal DbContext       _context;
        internal DbSet<TEntity>  _dbSet;
   
        public Repository(DbContext context)
        {
            _context = context;
            _dbSet   = context.Set<TEntity>();
        }
        public virtual async Task<IEnumerable<TEntity>> Select(
                Expression<Func<TEntity, bool>> filter = null,
                Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
                string includes = null
        )
        {
            IQueryable<TEntity> query = _dbSet;
            if (filter != null)
                  query = query.Where(filter);
            //
            if (includes != null) 
                //if (includes.Length > 0)
                {
                    String[] tab = includes.Split(',');
                    foreach (String s in tab)
                        query = query.Include(s.Trim());
                }
            //
            if (orderBy != null)
            {
                var var = await orderBy(query).ToListAsync();
                return var.AsQueryable().AsNoTracking();              
            }
            else
            {
                var var = await query.ToListAsync();
                return var.AsQueryable().AsNoTracking();  
            }
        }
      
        //
        public virtual async Task<TEntity> Find(object id)
        {
            if (id != null)
            {
                TEntity entity =  await _dbSet.FindAsync(id);
                if (entity != null)
                        return entity;
            }
            return null;
        }
        //
        public virtual async Task  Insert(TEntity entity)
        {
          await _dbSet.AddAsync(entity);
          await _context.SaveChangesAsync();
        }
        //
        public virtual async Task<bool> Delete(object id)
        {
            if (id != null)
            {
                TEntity entityToRemove = await _dbSet.FindAsync(id);
                if (entityToRemove == null) return false;
                _dbSet.Remove(entityToRemove);
                 await _context.SaveChangesAsync();
            }
            return true;
        }
        //
        public virtual async Task Update(TEntity entity, byte[] rowVersion)
        {
            _context.Entry(entity).Property("RowVersion").OriginalValue = rowVersion;
            await _context.SaveChangesAsync();
        }
        //
        public void Dispose(bool disposing) => _context.Dispose();
     
    }
}
