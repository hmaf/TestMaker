using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestMaker.Application.Dtos.Post;
using TestMaker.Domain.Models;

namespace TestMaker.Application.Interfaces
{
    public interface IPostService : IGenericCRUDService<Post, PostDto>
    {
    }
}
