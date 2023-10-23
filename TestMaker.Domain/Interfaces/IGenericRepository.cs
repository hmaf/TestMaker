using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace TestMaker.Domain.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> Add(T entity);
        //Task<bool> Exists(int id);
        public Task<T> GetById(Expression<Func<T, bool>> predicate, params string[] includes);
        Task<IReadOnlyList<T>> GetAll(Expression<Func<T, bool>>? where = null, params string[] includes);
        Task Update(T entity, Expression<Func<T, bool>>? where = null);
        Task LoadReference(T entity, Expression<Func<T, object>> reference);
    }
}
