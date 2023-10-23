using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestMaker.Application.Dtos.AcademicBranch;
using TestMaker.Application.Interfaces;
using TestMaker.Domain.Interfaces;
using TestMaker.Domain.Models;

namespace TestMaker.Application.Services
{
    public class AcademicBranchService : GenericCRUDService<AcademicBranch, AcademicBranchDto>, IAcademicBranchService
    {
        private readonly IAcademicBranchRepository _academicBranchRepository;
        public AcademicBranchService(IGenericRepository<AcademicBranch> repo, IMapper mapper, IAcademicBranchRepository academicBranchRepository) : base(repo, mapper)
        {
            _academicBranchRepository = academicBranchRepository;
        }
    }
}
