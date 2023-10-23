using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestMaker.Application.Dtos.MultipleQuestion;
using TestMaker.Application.Interfaces;
using TestMaker.Domain.Interfaces;
using TestMaker.Domain.Models;

namespace TestMaker.Application.Services
{
    public class MultipleQuestionService : GenericCRUDService<MultipleQuestion, MultipleQuestionDto>, IMultipleQuestionService
    {
        private readonly IMultipleQuestionRepository _multipleQuestionRepository;
        public MultipleQuestionService(IGenericRepository<MultipleQuestion> repo, IMapper mapper, IMultipleQuestionRepository multipleQuestionRepository) : base(repo, mapper)
        {
            _multipleQuestionRepository = multipleQuestionRepository;
        }
    }
}
