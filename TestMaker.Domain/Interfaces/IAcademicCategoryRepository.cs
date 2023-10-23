using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestMaker.Domain.Models;

namespace TestMaker.Domain.Interfaces
{
    public interface IAcademicCategoryRepository : IGenericRepository<AcademicCategory>
    {
        Task Delete(int id);
    }
}
