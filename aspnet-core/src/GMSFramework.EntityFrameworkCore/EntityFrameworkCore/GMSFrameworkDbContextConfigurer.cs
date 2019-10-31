using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace GMSFramework.EntityFrameworkCore
{
    public static class GMSFrameworkDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<GMSFrameworkDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<GMSFrameworkDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
