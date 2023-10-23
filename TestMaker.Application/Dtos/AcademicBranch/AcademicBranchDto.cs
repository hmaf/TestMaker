using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestMaker.Application.Dtos.Common;

namespace TestMaker.Application.Dtos.AcademicBranch
{
    public class AcademicBranchDto : BaseDto<int>
    {
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public int Order { get; set; }
        public byte Status { get; set; }
        public int AcademicCategoryId { get; set; }
    }
}
