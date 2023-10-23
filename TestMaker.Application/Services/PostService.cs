using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestMaker.Application.Dtos.Post;
using TestMaker.Application.Dtos.Tag;
using TestMaker.Application.Interfaces;
using TestMaker.Domain.Interfaces;
using TestMaker.Domain.Models;

namespace TestMaker.Application.Services
{
    public class PostService : GenericCRUDService<Post, PostDto>, IPostService
    {
        private readonly IPostRepository _postRepository;
        public PostService(IGenericRepository<Post> repo, IMapper mapper, IPostRepository postRepository) : base(repo, mapper)
        {
            _postRepository = postRepository;
        }
    }
}
