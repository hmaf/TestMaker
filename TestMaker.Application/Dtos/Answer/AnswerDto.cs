using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestMaker.Application.Dtos.Common;

namespace TestMaker.Application.Dtos.Answer
{
    public class AnswerDto : BaseDto<int>
    {
        public string Description { get; set; }
        public int Order { get; set; }
        public int TestId { get; set; }
    }
}
