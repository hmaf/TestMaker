using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestMaker.Application.Dtos.AcademicBranch;
using TestMaker.Application.Dtos.AcademicCategory;
using TestMaker.Application.Dtos.Answer;
using TestMaker.Application.Dtos.MultipleQuestion;
using TestMaker.Application.Dtos.Post;
using TestMaker.Application.Dtos.PostCategory;
using TestMaker.Application.Dtos.Tag;
using TestMaker.Application.Dtos.Test;
using TestMaker.Domain.Models;

namespace TestMaker.Application.Profile
{
    public class AutoMapperProfile : AutoMapper.Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Tag, TagDto>().ReverseMap(); 
            CreateMap<Test, TestDto>().ReverseMap(); 
            CreateMap<Post, PostDto>().ReverseMap(); 
            CreateMap<Answer, AnswerDto>().ReverseMap(); 
            CreateMap<PostCategory, PostCategoryDto>().ReverseMap(); 
            CreateMap<AcademicBranch, AcademicBranchDto>().ReverseMap(); 
            CreateMap<AcademicCategory, AcademicCategoryDto>().ReverseMap(); 
            CreateMap<MultipleQuestion, MultipleQuestionDto>().ReverseMap(); 
        }
    }
}
