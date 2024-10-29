using Gigler.Core.DataObjects;
using Microsoft.EntityFrameworkCore;

namespace Gigler.Manager
{
    public class GiglerDBContext : DbContext
    {
        public GiglerDBContext(DbContextOptions<GiglerDBContext> options) : base(options)
        {

        }

        public DbSet<Question> Questions { get; set; }
        public DbSet<QuestionTitle> QuestionTitles { get; set; }
    }
}
