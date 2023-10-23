using AutoMapper;
using TestMaker.Application.Dtos.PostCategory;
using TestMaker.Application.Interfaces;
using TestMaker.Domain.Interfaces;
using TestMaker.Domain.Models;

namespace TestMaker.Application.Services
{
    public class PostCategoryService : GenericCRUDService<PostCategory, PostCategoryDto> , IPostCategoryService
    {
        private readonly IPostCategoryRepository _postCategoryRepository;

        public PostCategoryService(IGenericRepository<PostCategory> repo, IMapper mapper, IPostCategoryRepository postCategoryRepository) : base(repo, mapper)
        {
            _postCategoryRepository = postCategoryRepository;
        }
    }
}
