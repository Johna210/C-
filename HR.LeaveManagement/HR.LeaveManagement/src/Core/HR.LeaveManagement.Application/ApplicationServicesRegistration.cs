using System.Reflection;

namespace HR.LeaveManagement.Core.HR.LeaveManagement.Application;

public static class ApplicationServicesRegistration
{
    public static void ConfigureApplicationServices(this IServiceCollection services)
    {
        services.AddAutoMapper(Assembly.GetExecutingAssembly());
    }
}