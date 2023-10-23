using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestMaker.Domain.Interfaces;
using TestMaker.Domain.Models;

namespace TestMaker.Infra.Data.Repository
{
    public class AcademicCategoryRepository : GenericRepository<AcademicCategory>, IAcademicCategoryRepository
    {
        private readonly TestMakerDbContext _db;

        public AcademicCategoryRepository(TestMakerDbContext db) : base(db) 
        {
            _db = db;
        }

        public async Task Delete(int id)
        {
            var data = await _db.AcademicCategory.FirstOrDefaultAsync(obj => obj.Equals(id));

            if (data != null)
                throw new Exception($"{id} in AcademicCategory Table not found");

            data.IsDelete = false;
            _db.Update(data);
            await _db.SaveChangesAsync();
        }
    }
}
