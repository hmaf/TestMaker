using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestMaker.Domain.Models.list;

namespace TestMaker.Domain.Models
{
    public class Answer : BaseDomainEntity<int>
    {
        public string Description { get; set; }
        public int Order { get; set; }

        //relateion
        [ForeignKey("Test")]
        public int TestId { get; set; }
        public Test Test { get; set; }
    }
}
