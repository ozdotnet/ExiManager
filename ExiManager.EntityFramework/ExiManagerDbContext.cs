using ExiManager.Shared.Model;
using Microsoft.EntityFrameworkCore;

namespace ExiManager.EntityFramework
{
    public class ExiManagerDbContext: DbContext
    {
        public DbSet<Folder> Folders { get; set; }
        public DbSet<File> Files { get; set; }
        public DbSet<ExiInfo> ExiInfos { get; set; }

        public ExiManagerDbContext(DbContextOptions options) : base(options)
        {

        }
    }
}
