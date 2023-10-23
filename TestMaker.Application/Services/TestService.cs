using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestMaker.Application.Dtos.Test;
using TestMaker.Application.Interfaces;
using TestMaker.Domain.Interfaces;
using TestMaker.Domain.Models;

namespace TestMaker.Application.Services
{
    public class TestService : GenericCRUDService<Test, TestDto>, ITestService
    {
        private readonly ITestRepository _testRepository;
        public TestService(IGenericRepository<Test> repo, IMapper mapper, ITestRepository testRepository) : base(repo, mapper)
        {
            _testRepository = testRepository;
        }
    }
}
