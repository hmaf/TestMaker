using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestMaker.Domain.Models;

namespace TestMaker.Infra.Data
{
    public class TaskMakerDbContext:DbContext
    {
        public TaskMakerDbContext(DbContextOptions<TaskMakerDbContext> options): base(options)
        {
            
        }

        public DbSet<AcademicBranch> AcademicBranch { get; set;}
        public DbSet<AcademicCategory> AcademicCategory { get; set;}
        public DbSet<Post> Post { get; set;}
        public DbSet<Tag> Tag { get; set;}
        public DbSet<Test> Test { get; set;}
        public DbSet<PostCategory> PostCategories { get; set;}
        public DbSet<MultipleQuestion> MultipleQuestions { get; set;}
        public DbSet<Answer> Answer { get; set; }
    }
}
