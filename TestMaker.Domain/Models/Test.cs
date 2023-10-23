using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestMaker.Domain.Models.list;

namespace TestMaker.Domain.Models
{
    public class Test : BaseDomainEntity<int>
    {
        public string Title { get; set; }
        public string Icon { get; set; }
        public int AcademicBranchId { get; set; }
        public int AcademicCategory { get; set; }

        // relations
        public ICollection<MultipleQuestion> MultipleQuestion { get; set; }
        public ICollection<Answer> Answers { get; set; }
    }
}
