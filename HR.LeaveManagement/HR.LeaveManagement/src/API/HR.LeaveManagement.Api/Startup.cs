using HR.LeaveManagement.Core.HR.LeaveManagement.Application;
using HR.LeaveManagement.Infrastructure;
using HR.LeaveManagement.Persistence;
using HR.LeaveManagement.Infrastructure.HR.LeaveManagement.Infrastructure;

namespace HR.LeaveManagement.API;

public class Startup
{
    public IConfiguration Configuration { get; }

    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }   
    
    // This method gets called by the runtime. Use this method to add services to the container.
    public void ConfigureServices(IServiceCollection services)
    {
        services.ConfigureApplicationServices();
        services.ConfigurationPersistenceServices(Configuration);
        services.ConfigureInfrastructureServices(Configuration);
        services.AddControllers();
    }
    
}