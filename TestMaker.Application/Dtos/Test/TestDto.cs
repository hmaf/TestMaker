using System.Collections.Generic;
using TestMaker.Application.Dtos.Answer;
using TestMaker.Application.Dtos.Common;
using TestMaker.Application.Dtos.MultipleQuestion;

namespace TestMaker.Application.Dtos.Test
{
    public class TestDto : BaseDto<int>
    {
        public string Title { get; set; }
        public string Icon { get; set; }
        public int AcademicBranchId { get; set; }
        public int AcademicCategory { get; set; }
        public List<MultipleQuestionDto> MultipleQuestion { get; set; }
        public List<AnswerDto> Answers { get; set; }
    }
}
