using HR.LeaveManagement.Core.HR.LeaveManagement.Application.DTOs;
using HR.LeaveManagement.Core.HR.LeaveManagement.Application.DTOs.LeaveTypeDto;
using MediatR;

namespace HR.LeaveManagement.Core.HR.LeaveManagement.Application.Features.LeaveTypes.Requests.Queries;

public class GetLeaveTypeListRequest: IRequest<List<LeaveTypeDto>>
{
       
}