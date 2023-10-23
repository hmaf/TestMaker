using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestMaker.Application.Dtos.Post;
using TestMaker.Application.Dtos.PostCategory;
using TestMaker.Domain.Models;

namespace TestMaker.Application.Interfaces
{
    public interface IPostCategoryService : IGenericCRUDService<PostCategory, PostCategoryDto>
    {
    }
}
