using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestMaker.Application.Dtos.Common;

namespace TestMaker.Application.Dtos.AcademicCategory
{
    public class AcademicCategoryDto : BaseDto<int>
    {
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public byte Status { get; set; }
    }
}
