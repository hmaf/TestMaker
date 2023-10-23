using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestMaker.Domain.Models;

namespace TestMaker.Domain.Interfaces
{
    public interface ITestRepository : IGenericRepository<Test>
    {
        Task Delete(int id);
    }
}
