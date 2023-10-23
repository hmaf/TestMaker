using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestMaker.Application.Dtos.Common;

namespace TestMaker.Application.Dtos.Tag
{
    public class TagDto : BaseDto<int>
    {
        public string Title { get; set; }
        public string EnTitle { get; set; }
        public string Class { get; set; }
        public string Icon { get; set; }
    }
}
