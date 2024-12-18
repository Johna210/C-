using HR.LeaveManagement.Core.HR.LeaveManagement.Application.Persistence.Contracts;
using HR.LeaveManagement.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace HR.LeaveManagement.Persistence;

public static class PersistenceServiceRegistration
{
    public static IServiceCollection ConfigurePersistenceServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<LeaveManagementDbContext>(options =>
            options.UseNpgsql(
                configuration.GetConnectionString("LeaveManagementConnectionString")));
        
        services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
        services.AddScoped<ILeaveTypeRepository, LeaveTypeRepository>();
        services.AddScoped<ILeaveRequestRepository, LeaveRequestRepository>();
        services.AddScoped<ILeaveAllocationRepository, LeaveAllocationRepository>();
        
        return services;
    }
}

