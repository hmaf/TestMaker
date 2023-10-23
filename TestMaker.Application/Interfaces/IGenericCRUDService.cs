using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace TestMaker.Application.Interfaces
{
    public interface IGenericCRUDService<TModel, TDto>
    {
        Task<IEnumerable<TDto>> GetAll(Expression<Func<TModel, bool>>? where = null, params string[] includes);
        Task<TDto?> GetById(Expression<Func<TModel, bool>> predicateToGetId, params string[] includes);
        Task<TDto> Add(TDto dto, params Expression<Func<TModel, object>>[] references);
        Task<TDto> Update(TDto dto, Expression<Func<TModel, bool>>? where = null, params Expression<Func<TModel, object>>[] references);
    }
}
