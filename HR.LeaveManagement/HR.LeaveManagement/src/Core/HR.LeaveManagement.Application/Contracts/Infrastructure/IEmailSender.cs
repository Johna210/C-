using HR.LeaveManagement.Core.HR.LeaveManagement.Application.Models;

namespace HR.LeaveManagement.Core.HR.LeaveManagement.Application.Contracts.Infrastructure;

public interface IEmailSender
{
    Task<bool> SendEmail(Email email);
}