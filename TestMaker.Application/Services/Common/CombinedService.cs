using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestMaker.Application.Interfaces;
using TestMaker.Application.Interfaces.Common;

namespace TestMaker.Application.Services.Common
{
    public class CombinedService : ICombinedService
    {
        public CombinedService(
        ITagService tagService,
        ITestService testService,
        IPostService postService,
        IAnswerService answerService,
        IPostCategoryService postCategoryService,
        IAcademicBranchService academicBranchService,
        IMultipleQuestionService multipleQuestionService,
        IAcademicCategoryService academicCategoryService)
        {
            TagService = tagService;
            TestService = testService;
            PostService = postService;
            AnswerService = answerService;
            PostCategoryService = postCategoryService;
            AcademicBranchService = academicBranchService;
            MultipleQuestionService = multipleQuestionService;
            AcademicCategoryService = academicCategoryService;
        }

        public ITagService TagService { get; }
        public ITestService TestService { get; }
        public IPostService PostService { get; }
        public IAnswerService AnswerService { get; }
        public IPostCategoryService PostCategoryService { get; }
        public IAcademicBranchService AcademicBranchService { get; }
        public IMultipleQuestionService MultipleQuestionService { get; }
        public IAcademicCategoryService AcademicCategoryService { get; }
    }
}
