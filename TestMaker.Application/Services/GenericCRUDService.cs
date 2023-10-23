using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TestMaker.Application.Interfaces;
using TestMaker.Domain.Interfaces;

namespace TestMaker.Application.Services
{
    public class GenericCRUDService<TModel, TDto> : IGenericCRUDService<TModel, TDto> where TModel : class where TDto : class
    {
        private readonly IGenericRepository<TModel> _repo;
        private readonly IMapper _mapper;

        public GenericCRUDService(IGenericRepository<TModel> repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task<IEnumerable<TDto>> GetAll(Expression<Func<TModel, bool>>? where = null, params string[] includes)
        {
            var entities = await _repo.GetAll(where, includes);
            var dtos = _mapper.Map<IEnumerable<TDto>>(entities);
            return dtos;
        }

        public async Task<TDto?> GetById(Expression<Func<TModel, bool>> predicateToGetId, params string[] includes)
        {
            var entity = await _repo.GetById(predicateToGetId, includes);
            if (entity == null)
            {
                return null;
            }
            var dto = _mapper.Map<TDto>(entity);
            return dto;
        }

        public async Task<TDto> Add(TDto dto, params Expression<Func<TModel, object>>[] references)
        {
            var entity = _mapper.Map<TModel>(dto);
            if (references.Length > 0)
            {
                await LoadReferences(entity, references);
            }
            await _repo.Add(entity);
            return dto;
        }

        public async Task<TDto> Update(TDto dto, Expression<Func<TModel, bool>>? where = null, params Expression<Func<TModel, object>>[] references)
        {
            var entity = _mapper.Map<TModel>(dto);
            if (references.Length > 0)
            {
                await LoadReferences(entity, references);
            }
            await _repo.Update(entity, where);
            return dto;
        }


        private async Task LoadReferences(TModel entity, params Expression<Func<TModel, object>>[] references)
        {
            foreach (var reference in references)
            {
                _repo.LoadReference(entity, reference);
            }
        }
    }
}
