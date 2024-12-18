using HR.LeaveManagement.Core.HR.LeaveManagement.Domain;

namespace HR.LeaveManagement.Core.HR.LeaveManagement.Application.Persistence.Contracts;

public interface ILeaveRequestRepository : IGenericRepository<LeaveRequest>
{
    Task<LeaveRequest> GetLeaveRequestWithDetails(int id);
    Task<List<LeaveRequest>> GetLeaveRequestsWithDetails();
    Task ChangeApprovalStatus(LeaveRequest leaveRequest, bool? ApprovalStatus);
}