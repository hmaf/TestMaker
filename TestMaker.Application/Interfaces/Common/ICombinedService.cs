using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMaker.Application.Interfaces.Common
{
    public interface ICombinedService
    {
        ITagService TagService { get; }
        ITestService TestService { get; }
        IPostService PostService { get; }
        IAnswerService AnswerService { get; }
        IPostCategoryService PostCategoryService { get; }
        IAcademicBranchService AcademicBranchService { get; }
        IMultipleQuestionService MultipleQuestionService { get; }
        IAcademicCategoryService AcademicCategoryService { get; }
    }
}
