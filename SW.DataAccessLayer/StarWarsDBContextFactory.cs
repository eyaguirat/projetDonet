using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

using System.IO;

namespace SW.DataAccessLayer
{
    public class StarWarsDBContextFactory : IDesignTimeDbContextFactory<StarWarsDBContext>
    {
        public StarWarsDBContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var builder = new DbContextOptionsBuilder<StarWarsDBContext>();
            var connectionString = configuration.GetConnectionString("SW");

            builder.UseSqlite(connectionString);

            return new StarWarsDBContext(builder.Options);
        }
    }
}
