using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestMaker.Application.Dtos.Common;

namespace TestMaker.Application.Dtos.MultipleQuestion
{
    public class MultipleQuestionDto : BaseDto<int>
    {
        public string Option { get; set; }
        public int Order { get; set; }
        public int TestId { get; set; }
    }
}
