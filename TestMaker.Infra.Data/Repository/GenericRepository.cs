using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public async Task<bool> Exist(int id)
        {
            var entity = await Get(id);
            return entity != null;
        }

        public async Task<T> Get(int id)
        {
            return await _db.Set<T>().FindAsync(id);
        }

        public async Task<IReadOnlyList<T>> GetAll()
        {
            return await _db.Set<T>().ToListAsync();
        }

        public async Task Update(T entity)
        {
            _db.Entry(entity).State = EntityState.Modified;
            await _db.SaveChangesAsync();
        }
    }
}
