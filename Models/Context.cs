using Microsoft.EntityFrameworkCore;

namespace Models
{
    public class Context : DbContext
    {
        public DbSet<Aluno> Alunos { get; set; }
        public Context(DbContextOptions<Context> options) : base(options)
        {
            
        }
    }
}