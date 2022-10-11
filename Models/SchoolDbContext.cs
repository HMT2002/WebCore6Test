using Microsoft.EntityFrameworkCore;

namespace WebCore6Test.Models
{
    public class SchoolDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=.\mssqlserver01;Initial Catalog=SchoolDB;Integrated Security=True");
        }
        public SchoolDbContext()
        {

        }

        public DbSet<Student> Students { get; set; }

        public DbSet<Course> Courses { get; set; }

    }
}
