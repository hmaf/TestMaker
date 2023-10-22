using Microsoft.Extensions.DependencyInjection;
using TestMaker.Domain.Interfaces;
using TestMaker.Infra.Data.Repository;

namespace TestMaker.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection service)
        {
            //Application Layer
            

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
