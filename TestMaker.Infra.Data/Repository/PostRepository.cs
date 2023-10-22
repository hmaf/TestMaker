using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestMaker.Domain.Interfaces;
using TestMaker.Domain.Models;

namespace TestMaker.Infra.Data.Repository
{
    public class PostRepository : GenericRepository<Post>, IPostRepository
    {
        private readonly TestMakerDbContext _db;

        public PostRepository(TestMakerDbContext db): base(db) 
        {
            _db = db;
        }
    }
}
