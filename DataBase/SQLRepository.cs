using Microsoft.EntityFrameworkCore;
using PRA_WebAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;


namespace PRA_WebAPI.DataBase
{
    public class SQLRepository<TEntity> : IRepository<TEntity>
         where TEntity : class, IEntity
    {
        private readonly PRADBContext _context;
        public SQLRepository(PRADBContext context)
        {
            _context = context;
        }
        public async Task<TEntity> Add(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<TEntity> Delete(int id)
        {
            var entity = await _context.Set<TEntity>().FindAsync(id);
       
            _context.Set<TEntity>().Remove(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<List<TEntity>> Filter(Expression<Func<TEntity, bool>> where)
        {

            return await _context.Set<TEntity>().Where(where).ToListAsync();
        }

        public async Task<TEntity> Get(int id)
        {
            return await _context.Set<TEntity>().FindAsync(id);
        }

        public async Task<List<TEntity>> GetAll()
        {
            return await _context.Set<TEntity>().ToListAsync();
        }

        public async Task<TEntity> Update(TEntity Entity)
        {

            _context.Entry(Entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            await _context.SaveChangesAsync();
            return Entity;
        }
    }
}
