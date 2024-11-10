using HR.LeaveManagement.Core.HR.LeaveManagement.Application.Contracts.Infrastructure;
using HR.LeaveManagement.Core.HR.LeaveManagement.Application.Models;
using HR.LeaveManagement.Infrastructure.HR.LeaveManagement.Infrastructure.Mail;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace HR.LeaveManagement.Infrastructure.HR.LeaveManagement.Infrastructure;

public class InfrastructureServicesRegistration
{
    public static IServiceCollection AddInfrastructureServices(IServiceCollection services,
        IConfiguration configuration)
    {
        services.Configure<EmailSettings>(configuration.GetSection("EmailSettings"));
        services.AddTransient<IEmailSender, EmailSender>();
        
        return services;
    }
}