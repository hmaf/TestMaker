using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestMaker.Application.Dtos.AcademicCategory;
using TestMaker.Application.Interfaces;
using TestMaker.Domain.Interfaces;
using TestMaker.Domain.Models;

namespace TestMaker.Application.Services
{
    public class AcademicCategoryService : GenericCRUDService<AcademicCategory, AcademicCategoryDto>, IAcademicCategoryService
    {
        private readonly IAcademicCategoryRepository _academicCategoryRepository;
        public AcademicCategoryService(IGenericRepository<AcademicCategory> repo, IMapper mapper, IAcademicCategoryRepository academicCategoryRepository) : base(repo, mapper)
        {
            _academicCategoryRepository = academicCategoryRepository;
        }
    }
}
