using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace HR.LeaveManagement.Persistence;

public class LeaveManagementDbContextFactory : IDesignTimeDbContextFactory<LeaveManagementDbContext>
{
    public LeaveManagementDbContext CreateDbContext(string[] args)
    {
        var configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();

        var optionsBuilder = new DbContextOptionsBuilder<LeaveManagementDbContext>();
        var connectionString = configuration.GetConnectionString("LeaveManagementConnectionString");
    
        optionsBuilder.UseNpgsql(connectionString);

        return new LeaveManagementDbContext(optionsBuilder.Options);
    }
}