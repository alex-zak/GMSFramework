using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using GMSFramework.Configuration;
using GMSFramework.Web;

namespace GMSFramework.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class GMSFrameworkDbContextFactory : IDesignTimeDbContextFactory<GMSFrameworkDbContext>
    {
        public GMSFrameworkDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<GMSFrameworkDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            GMSFrameworkDbContextConfigurer.Configure(builder, configuration.GetConnectionString(GMSFrameworkConsts.ConnectionStringName));

            return new GMSFrameworkDbContext(builder.Options);
        }
    }
}
