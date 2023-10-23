using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestMaker.Domain.Models.list;

namespace TestMaker.Domain.Models
{
    public class AcademicCategory : BaseDomainEntity<int>
    {
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public byte Status { get; set; }

        // relations
        public ICollection<AcademicBranch> AcademicBranches { get; set; }
    }
}
