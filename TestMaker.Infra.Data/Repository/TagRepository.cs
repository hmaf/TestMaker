using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestMaker.Domain.Interfaces;
using TestMaker.Domain.Models;

namespace TestMaker.Infra.Data.Repository
{
    public class TagRepository : GenericRepository<Tag>, ITagRepository
    {
        private readonly TestMakerDbContext _db;

        public TagRepository(TestMakerDbContext db):base(db)
        {
            _db = db;
        }
    }
}
