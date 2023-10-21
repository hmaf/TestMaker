using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestMaker.Domain.Models.list;

namespace TestMaker.Domain.Models
{
    public class AcademicBranch : SimpleEntity<int>
    {
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public int Order { get; set; }
        public byte Status { get; set; }

        // relations
        [ForeignKey("AcademicCategory")]
        public int AcademicCategoryId { get; set; }
        public AcademicCategory AcademicCategory { get; set; }
    }
}
