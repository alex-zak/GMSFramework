using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using GMSFramework.Authorization.Roles;
using GMSFramework.Authorization.Users;
using GMSFramework.MultiTenancy;

namespace GMSFramework.EntityFrameworkCore
{
    public class GMSFrameworkDbContext : AbpZeroDbContext<Tenant, Role, User, GMSFrameworkDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public GMSFrameworkDbContext(DbContextOptions<GMSFrameworkDbContext> options)
            : base(options)
        {
        }
    }
}
