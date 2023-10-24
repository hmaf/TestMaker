using AutoMapper;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TestMaker.Application.Interfaces;
using TestMaker.Application.Interfaces.Common;
using TestMaker.Application.Profile;
using TestMaker.Application.Services;
using TestMaker.Application.Services.Common;
using TestMaker.Domain.Interfaces;
using TestMaker.Infra.Data.Repository;

namespace TestMaker.Infra.IoC
{
    public static class DependencyContainer
    {
        public static IServiceCollection RegisterServices(this IServiceCollection service)
        {
            // Register AutoMapper
            var mapperConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new AutoMapperProfile());
                // افزودن پروفایل‌های دیگر اگر نیاز دارید
            });

            IMapper mapper = mapperConfig.CreateMapper();
            service.AddSingleton(mapper);

            // Application Layer
            service.AddScoped<ICombinedService, CombinedService>();
            service.AddScoped<ITagService, TagService>();
            service.AddScoped<ITestService, TestService>();
            service.AddScoped<IPostService, PostService>();
            service.AddScoped<IAnswerService, AnswerService>();
            service.AddScoped<IPostCategoryService, PostCategoryService>();
            service.AddScoped<IAcademicBranchService, AcademicBranchService>();
            service.AddScoped<IMultipleQuestionService, MultipleQuestionService>();
            service.AddScoped<IAcademicCategoryService, AcademicCategoryService>();

            // Register Generic Repository
            service.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));

            // Infra Data Layer
            service.AddScoped<ITagRepository, TagRepository>();
            service.AddScoped<ITestRepository, TestRepository>();
            service.AddScoped<IPostRepository, PostRepository>();
            service.AddScoped<IAnswerRepository, AnswerRepository>();
            service.AddScoped<IPostCategoryRepository, PostCategoryRepository>();
            service.AddScoped<IAcademicBranchRepository, AcademicBranchRepository>();
            service.AddScoped<IMultipleQuestionRepository, MultipleQuestionRepository>();
            service.AddScoped<IAcademicCategoryRepository, AcademicCategoryRepository>();

            return service;
        }
    }
}
