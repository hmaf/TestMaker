using Microsoft.Extensions.DependencyInjection;
using TestMaker.Application.Interfaces;
using TestMaker.Application.Services;
using TestMaker.Domain.Interfaces;
using TestMaker.Infra.Data.Repository;

namespace TestMaker.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection service)
        {
            //Application Layer
            service.AddScoped<ITagService, TagService>();
            service.AddScoped<ITestService, TestService>();
            service.AddScoped<IPostService, PostService>();
            service.AddScoped<IAnswerService, AnswerService>();
            service.AddScoped<IPostCategoryService, PostCategoryService>();
            service.AddScoped<IAcademicBranchService, AcademicBranchService>();
            service.AddScoped<IMultipleQuestionService, MultipleQuestionService>();
            service.AddScoped<IAcademicCategoryService, AcademicCategoryService>();

            //Infra Data Layer
            service.AddScoped<ITagRepository, TagRepository>();
            service.AddScoped<ITestRepository, TestRepository>();
            service.AddScoped<IPostRepository, PostRepository>();
            service.AddScoped<IAnswerRepository, AnswerRepository>();
            service.AddScoped<IPostCategoryRepository, PostCategoryRepository>();
            service.AddScoped<IAcademicBranchRepository, AcademicBranchRepository>();
            service.AddScoped<IMultipleQuestionRepository, MultipleQuestionRepository>();
            service.AddScoped<IAcademicCategoryRepository, AcademicCategoryRepository>();

        }
    }
}
