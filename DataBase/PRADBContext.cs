using Microsoft.EntityFrameworkCore;
using PRA_WebAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace PRA_WebAPI.DataBase
{
    public class PRADBContext : DbContext
    {
        public PRADBContext(DbContextOptions<PRADBContext> options) : base(options)
        {

        }

        public DbSet<Answer> Answer { get; set; }
        public DbSet<Author> Author { get; set; }
        public DbSet<Game> Game { get; set; }
        public DbSet<Question> Question { get; set; }
        public DbSet<Quiz> Quiz { get; set; }

        public DbSet<PlayerRanking> PlayerRanking {get;set;}

        public DbSet<PlayerQuestionAnswer> PlayerQuestionAnswer { get; set; }
    }
}
