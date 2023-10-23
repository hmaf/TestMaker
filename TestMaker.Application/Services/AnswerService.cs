using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestMaker.Application.Dtos.Answer;
using TestMaker.Application.Interfaces;
using TestMaker.Domain.Interfaces;
using TestMaker.Domain.Models;

namespace TestMaker.Application.Services
{
    public class AnswerService : GenericCRUDService<Answer, AnswerDto>, IAnswerService
    {
        private readonly IAnswerRepository _answerRepository;
        public AnswerService(IGenericRepository<Answer> repo, IMapper mapper, IAnswerRepository answerRepository) : base(repo, mapper)
        {
            _answerRepository = answerRepository;
        }
    }
}
