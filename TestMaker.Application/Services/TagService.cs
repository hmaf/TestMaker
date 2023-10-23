using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestMaker.Application.Dtos.Tag;
using TestMaker.Application.Interfaces;
using TestMaker.Domain.Interfaces;
using TestMaker.Domain.Models;

namespace TestMaker.Application.Services
{
    public class TagService : GenericCRUDService<Tag, TagDto>, ITagService
    {
        private readonly ITagRepository _tagRepository;
        public TagService(IGenericRepository<Tag> repo, IMapper mapper, ITagRepository tagRepository) : base(repo, mapper)
        {
            _tagRepository = tagRepository;
        }
    }
}
