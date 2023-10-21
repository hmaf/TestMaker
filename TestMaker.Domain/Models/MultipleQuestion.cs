using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestMaker.Domain.Models.list;

namespace TestMaker.Domain.Models
{
    public class MultipleQuestion : SimpleEntity<int>
    {
        public string Option { get; set; }
        public int Order { get; set; }

        //relateion
        [ForeignKey("Test")]
        public int TestId { get; set; }
        public Test Test { get; set; }
    }
}
