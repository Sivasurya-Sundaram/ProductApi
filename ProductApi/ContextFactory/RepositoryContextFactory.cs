using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Repostiory;

namespace ProductApi.ContextFactory
{
    public class RepositoryContextFactory : IDesignTimeDbContextFactory<RepositoryDbContext>
    {
        public RepositoryDbContext CreateDbContext(string[] args)
        {
            var configuration = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();
            var contextBuilder = new DbContextOptionsBuilder<RepositoryDbContext>().UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            return new RepositoryDbContext(contextBuilder.Options);
        }
    }
}
