using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestMaker.Application.Dtos.Common;

namespace TestMaker.Application.Dtos.PostCategory
{
    public class PostCategoryDto : BaseDto<int>
    {
        public string Title { get; set; }
        public string EnTitle { get; set; }
        public string Icon { get; set; }
        public int Type { get; set; }
    }
}
