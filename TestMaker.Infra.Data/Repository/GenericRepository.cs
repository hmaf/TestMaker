using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TestMaker.Domain.Interfaces;

namespace TestMaker.Infra.Data.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly TestMakerDbContext _db;

        public GenericRepository(TestMakerDbContext db)
        {
            _db = db;
        }

        public async Task<T> Add(T entity)
        {
            await _db.AddAsync(entity);
            await _db.SaveChangesAsync();
            return entity;
        }

        //public async Task<bool> Exists(int id) => await GetById(id) != null;

        public async Task<T> GetById(Expression<Func<T, bool>> predicate, params string[] includes)
        {
            var query = _db.Set<T>().AsQueryable();

            if (includes != null)
            {
                foreach (var include in includes)
                {
                    query = query.Include(include);
                }
            }

            return await query.SingleOrDefaultAsync(predicate);
        }

        public async Task<IReadOnlyList<T>> GetAll(Expression<Func<T, bool>>? where = null, params string[] includes)
        {
            var query = _db.Set<T>().AsQueryable();

            if (where != null)
            {
                query = query.Where(where);
            }

            if (includes != null)
            {
                foreach (var include in includes)
                {
                    query = query.Include(include);
                }
            }

            return await query.ToListAsync();
        }

        public async Task Update(T entity, Expression<Func<T, bool>>? where = null)
        {
            if (where != null)
            {
                var existingEntity = await _db.Set<T>().SingleOrDefaultAsync(where);
                if (existingEntity == null)
                {
                    // Handle not found
                    return;
                }
                _db.Entry(existingEntity).CurrentValues.SetValues(entity);
            }
            else
            {
                _db.Entry(entity).State = EntityState.Modified;
            }

            await _db.SaveChangesAsync();
        }


        public async Task LoadReference(T entity, Expression<Func<T, object>> reference)
        {
            _db.Entry(entity).Reference(reference).Load();
        }
    }
}
