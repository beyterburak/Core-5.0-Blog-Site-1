using Microsoft.EntityFrameworkCore;

namespace BlogApiDemo.DataAccessLayer
{
    public class Context1 : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=BURAK\\SQLEXPRESS;database=CoreBlogApiDb;integrated security=true;");
        }
        public DbSet<Employee> Employees { get; set; }
    }
}
