using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace ExiManager.EntityFramework
{
    public class ExiManagerDbContextFactory : IDesignTimeDbContextFactory<ExiManagerDbContext>
    {
        public ExiManagerDbContext CreateDbContext(string[] args)
        {
            var options = new DbContextOptionsBuilder<ExiManagerDbContext>();
            options.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=ExiManagerDB;Trusted_Connection=True;");

            return new ExiManagerDbContext(options.Options);
        }
    }
}
